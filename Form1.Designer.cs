namespace 拦截检查
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblerror = new System.Windows.Forms.Label();
            this.btntianjia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbleixing = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl = new System.Windows.Forms.Label();
            this.txtoutputfilename = new System.Windows.Forms.TextBox();
            this.btnexporttoexcel = new System.Windows.Forms.Button();
            this.radioshijian = new System.Windows.Forms.RadioButton();
            this.radiosn = new System.Windows.Forms.RadioButton();
            this.txtsn = new System.Windows.Forms.TextBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblerror.Location = new System.Drawing.Point(137, 179);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 37);
            this.lblerror.TabIndex = 10;
            // 
            // btntianjia
            // 
            this.btntianjia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntianjia.Location = new System.Drawing.Point(724, 24);
            this.btntianjia.Name = "btntianjia";
            this.btntianjia.Size = new System.Drawing.Size(146, 55);
            this.btntianjia.TabIndex = 6;
            this.btntianjia.Text = "找信息/Tìm kiếm";
            this.btntianjia.UseVisualStyleBackColor = true;
            this.btntianjia.Click += new System.EventHandler(this.btntianjia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "项目/ Tên hàng";
            // 
            // cbleixing
            // 
            this.cbleixing.FormattingEnabled = true;
            this.cbleixing.Items.AddRange(new object[] {
            "SAMSUNG",
            "OPPO",
            "VIVO",
            "XIAOMI",
            "HUAWEI",
            "LENOVO",
            "MOTO",
            "SONY",
            "VICTORIA",
            "GOOGLE",
            "MEIZU",
            "MICROSOFT"});
            this.cbleixing.Location = new System.Drawing.Point(15, 25);
            this.cbleixing.Name = "cbleixing";
            this.cbleixing.Size = new System.Drawing.Size(152, 21);
            this.cbleixing.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Status,
            this.SN,
            this.Message,
            this.ServerTime});
            this.dataGridView1.Location = new System.Drawing.Point(39, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 462);
            this.dataGridView1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(367, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(555, 26);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(779, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "作者: 越南IT部";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "开始时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "\t结束时间";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(110, 582);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 13);
            this.lbl.TabIndex = 19;
            this.lbl.Text = "Output file name: ";
            // 
            // txtoutputfilename
            // 
            this.txtoutputfilename.Location = new System.Drawing.Point(206, 579);
            this.txtoutputfilename.Name = "txtoutputfilename";
            this.txtoutputfilename.Size = new System.Drawing.Size(186, 20);
            this.txtoutputfilename.TabIndex = 18;
            // 
            // btnexporttoexcel
            // 
            this.btnexporttoexcel.BackColor = System.Drawing.Color.LightGreen;
            this.btnexporttoexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexporttoexcel.Location = new System.Drawing.Point(402, 570);
            this.btnexporttoexcel.Name = "btnexporttoexcel";
            this.btnexporttoexcel.Size = new System.Drawing.Size(144, 37);
            this.btnexporttoexcel.TabIndex = 17;
            this.btnexporttoexcel.Text = "Export to CSV";
            this.btnexporttoexcel.UseVisualStyleBackColor = false;
            this.btnexporttoexcel.Click += new System.EventHandler(this.btnexporttoexcel_Click);
            // 
            // radioshijian
            // 
            this.radioshijian.AutoSize = true;
            this.radioshijian.Location = new System.Drawing.Point(245, 25);
            this.radioshijian.Name = "radioshijian";
            this.radioshijian.Size = new System.Drawing.Size(98, 17);
            this.radioshijian.TabIndex = 20;
            this.radioshijian.TabStop = true;
            this.radioshijian.Text = "时间/Thời gian";
            this.radioshijian.UseVisualStyleBackColor = true;
            this.radioshijian.CheckedChanged += new System.EventHandler(this.radioshijian_CheckedChanged);
            // 
            // radiosn
            // 
            this.radiosn.AutoSize = true;
            this.radiosn.Location = new System.Drawing.Point(245, 62);
            this.radiosn.Name = "radiosn";
            this.radiosn.Size = new System.Drawing.Size(69, 17);
            this.radiosn.TabIndex = 21;
            this.radiosn.TabStop = true;
            this.radiosn.Text = "条码/SN";
            this.radiosn.UseVisualStyleBackColor = true;
            this.radiosn.CheckedChanged += new System.EventHandler(this.radiosn_CheckedChanged);
            // 
            // txtsn
            // 
            this.txtsn.Location = new System.Drawing.Point(367, 59);
            this.txtsn.Name = "txtsn";
            this.txtsn.Size = new System.Drawing.Size(191, 20);
            this.txtsn.TabIndex = 22;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // SN
            // 
            this.SN.DataPropertyName = "SN";
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.Width = 200;
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.Width = 150;
            // 
            // ServerTime
            // 
            this.ServerTime.DataPropertyName = "ServerTime";
            this.ServerTime.HeaderText = "ServerTime";
            this.ServerTime.Name = "ServerTime";
            this.ServerTime.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 610);
            this.Controls.Add(this.txtsn);
            this.Controls.Add(this.radiosn);
            this.Controls.Add(this.radioshijian);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtoutputfilename);
            this.Controls.Add(this.btnexporttoexcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.cbleixing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btntianjia);
            this.Name = "Form1";
            this.Text = "拦截查询_v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btntianjia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbleixing;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtoutputfilename;
        private System.Windows.Forms.Button btnexporttoexcel;
        private System.Windows.Forms.RadioButton radioshijian;
        private System.Windows.Forms.RadioButton radiosn;
        private System.Windows.Forms.TextBox txtsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerTime;
    }
}

