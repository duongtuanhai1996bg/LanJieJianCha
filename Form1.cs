using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;
using System.Text;
using System.Reflection;

namespace 拦截检查
{
    public partial class Form1 : Form
    {
        string sfc;
        public Form1()
        {
            InitializeComponent();
            cbleixing.Text = "----SELECT----";
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkconnection();
            
        }

        private void checkconnection()
        {
            Console.WriteLine("Getting Connection ...");
            SqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                Console.WriteLine("Connection successful!");
                this.BackColor = System.Drawing.Color.PowderBlue;
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                this.BackColor = System.Drawing.Color.Tomato;
                lblerror.Text = "ERROR " + e.Message;
            }

            Console.Read();
        }

        private void btntianjia_Click(object sender, EventArgs e)
        {
            DateTime kaishi = dateTimePicker1.Value;
            DateTime jieshu = dateTimePicker2.Value;       
            TimeSpan sh = jieshu.Subtract(kaishi);

            if (sh.TotalDays > 1)
            {
                MessageBox.Show("不能跳过24个小时\nKhông được quá 24 tiếng");
            }
            //Console.WriteLine(sh.TotalDays.ToString());
            else
            {
                try
                {
                    switch (cbleixing.SelectedItem.ToString())
                    {
                        case "OPPO":
                            sfc = "SFCOPPO";
                            break;
                        case "VIVO":
                            sfc = "SFCVIVO";
                            break;
                        case "MOTO":
                            sfc = "SFCMOTO";
                            break;
                        case "LENOVO":
                            sfc = "SFCLENOVO";
                            break;
                        case "GOOGLE":
                            sfc = "SFCGOOGLE";
                            break;
                        case "HUAWEI":
                            sfc = "SFCHUAWEI";
                            break;
                        case "SAMSUNG":
                            sfc = "SFCSAMSUNG";
                            break;
                        case "XIAOMI":
                            sfc = "SFCXIAOMI";
                            break;
                        case "MICROSOFT":
                            sfc = "SFCMICROSOFT";
                            break;
                        case "MEIZU":
                            sfc = "SFCMEIZU";
                            break;
                        case "NOVO":
                            sfc = "SFCNOVO";
                            break;
                        case "VICTORIA":
                            sfc = "SFCVICTORIA";
                            break;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("选择客户! \nChưa chọn tên hàng!");
                }
                Console.WriteLine(sfc);
                SqlConnection conn = DBUtils.GetDBConnection(sfc);
                conn.Open();
                Console.WriteLine("Connection successful!");
                string sql1 = "select * from [" + sfc + "].[dbo].[T_InterceptDetails_Log] where ServerTime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                string sql2= "select * from [" + sfc + "].[dbo].[T_InterceptDetails_Log] where SN = '" + txtsn.Text.Trim() + "'";
                string sql = "";
                if (radioshijian.Checked)
                {
                    txtsn.Enabled = false;
                    dateTimePicker1.Enabled = true;
                    dateTimePicker2.Enabled = true;
                    sql = sql1;
                }
                if (radiosn.Checked)
                {
                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = false;
                    txtsn.Enabled = true;
                    sql = sql2;
                }
                try
                {
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    DataColumn Col = new DataColumn("STT", typeof(int));
                    dt.Columns.Add(Col);
                    da.Fill(dt);
                    conn.Close();
                    dataGridView1.DataSource = dt;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    }
                    // Start Excel and get Application object.  
                    DataSet dataSet = new DataSet();
                    dataSet.Tables.Add(dt);
                }
                catch (Exception err)
                {
                    Console.WriteLine("ERR");
                }
                //MessageBox.Show(dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("Không có dữ liệu\n没有记录！");
                }
                Console.Read();
            }
            
        }


        private void txttiaoma_Enter(object sender, EventArgs e)
        {
            //lblwei.Text = txttiaoma.Text.Length.ToString();
        }

        private void txttiaoma_MouseEnter(object sender, EventArgs e)
        {
            //lblwei.Text = txttiaoma.Text.Length.ToString();
        }

        private void btnexporttoexcel_Click(object sender, EventArgs e)
        {
            if (txtoutputfilename.Text == "")
            {
                MessageBox.Show("输入 Output file name!!", "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                 
                var folderBrowserDialog2 = new FolderBrowserDialog();

                // Show the FolderBrowserDialog.
                DialogResult result = folderBrowserDialog2.ShowDialog();
                string folderName;
                string filename;
                folderName = folderBrowserDialog2.SelectedPath;
                filename = txtoutputfilename.Text;
                string path = folderName + "/" + filename + ".csv";
                using (TextWriter tw = new StreamWriter(path))
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dataGridView1.Columns.Count - 1)
                            {
                                tw.Write(",");
                            }
                        }
                        tw.WriteLine();
                    }
                }
                MessageBox.Show("导出数据以使Excel成功\n" + folderName + "\\" + filename + ".csv", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }


        private void radiosn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioshijian.Checked)
            {
                txtsn.Enabled = false;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            if (radiosn.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                txtsn.Enabled = true;
            }
        }

        private void radioshijian_CheckedChanged(object sender, EventArgs e)
        {
            if (radioshijian.Checked)
            {
                txtsn.Enabled = false;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            if (radiosn.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                txtsn.Enabled = true;
            }
        }
    }
}
