namespace Hvk_prjQLCT
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONGTRINH2210900109BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoang_Van_Khai_2210900109_03DataSet = new Hvk_prjQLCT.Hoang_Van_Khai_2210900109_03DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPhong = new System.Windows.Forms.ComboBox();
            this.TxtNHT = new System.Windows.Forms.DateTimePicker();
            this.TxtNKC = new System.Windows.Forms.DateTimePicker();
            this.TxtTCT = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtMCT = new System.Windows.Forms.TextBox();
            this.Txtpb = new System.Windows.Forms.Label();
            this.Txtdd = new System.Windows.Forms.Label();
            this.Txtng = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btsua = new System.Windows.Forms.Button();
            this.btdatlai = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.cONGTRINH_2210900109TableAdapter = new Hvk_prjQLCT.Hoang_Van_Khai_2210900109_03DataSetTableAdapters.CONGTRINH_2210900109TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONGTRINH2210900109BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoang_Van_Khai_2210900109_03DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCTDataGridViewTextBoxColumn,
            this.tenCTDataGridViewTextBoxColumn,
            this.ngayKCDataGridViewTextBoxColumn,
            this.ngayHTDataGridViewTextBoxColumn,
            this.diaDiemDataGridViewTextBoxColumn,
            this.maPhongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cONGTRINH2210900109BindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(791, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // maCTDataGridViewTextBoxColumn
            // 
            this.maCTDataGridViewTextBoxColumn.DataPropertyName = "MaCT";
            this.maCTDataGridViewTextBoxColumn.HeaderText = "MaCT";
            this.maCTDataGridViewTextBoxColumn.Name = "maCTDataGridViewTextBoxColumn";
            // 
            // tenCTDataGridViewTextBoxColumn
            // 
            this.tenCTDataGridViewTextBoxColumn.DataPropertyName = "TenCT";
            this.tenCTDataGridViewTextBoxColumn.HeaderText = "TenCT";
            this.tenCTDataGridViewTextBoxColumn.Name = "tenCTDataGridViewTextBoxColumn";
            // 
            // ngayKCDataGridViewTextBoxColumn
            // 
            this.ngayKCDataGridViewTextBoxColumn.DataPropertyName = "NgayKC";
            this.ngayKCDataGridViewTextBoxColumn.HeaderText = "NgayKC";
            this.ngayKCDataGridViewTextBoxColumn.Name = "ngayKCDataGridViewTextBoxColumn";
            // 
            // ngayHTDataGridViewTextBoxColumn
            // 
            this.ngayHTDataGridViewTextBoxColumn.DataPropertyName = "NgayHT";
            this.ngayHTDataGridViewTextBoxColumn.HeaderText = "NgayHT";
            this.ngayHTDataGridViewTextBoxColumn.Name = "ngayHTDataGridViewTextBoxColumn";
            // 
            // diaDiemDataGridViewTextBoxColumn
            // 
            this.diaDiemDataGridViewTextBoxColumn.DataPropertyName = "DiaDiem";
            this.diaDiemDataGridViewTextBoxColumn.HeaderText = "DiaDiem";
            this.diaDiemDataGridViewTextBoxColumn.Name = "diaDiemDataGridViewTextBoxColumn";
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            // 
            // cONGTRINH2210900109BindingSource
            // 
            this.cONGTRINH2210900109BindingSource.DataMember = "CONGTRINH_2210900109";
            this.cONGTRINH2210900109BindingSource.DataSource = this.hoang_Van_Khai_2210900109_03DataSet;
            // 
            // hoang_Van_Khai_2210900109_03DataSet
            // 
            this.hoang_Van_Khai_2210900109_03DataSet.DataSetName = "Hoang_Van_Khai_2210900109_03DataSet";
            this.hoang_Van_Khai_2210900109_03DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.TxtNHT);
            this.groupBox1.Controls.Add(this.TxtNKC);
            this.groupBox1.Controls.Add(this.TxtTCT);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtMCT);
            this.groupBox1.Controls.Add(this.Txtpb);
            this.groupBox1.Controls.Add(this.Txtdd);
            this.groupBox1.Controls.Add(this.Txtng);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thông tin chi tiết ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONGTRINH2210900109BindingSource, "MaPhong", true));
            this.txtMaPhong.FormattingEnabled = true;
            this.txtMaPhong.Location = new System.Drawing.Point(457, 115);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(200, 21);
            this.txtMaPhong.TabIndex = 11;
            // 
            // TxtNHT
            // 
            this.TxtNHT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONGTRINH2210900109BindingSource, "NgayHT", true));
            this.TxtNHT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtNHT.Location = new System.Drawing.Point(457, 31);
            this.TxtNHT.Name = "TxtNHT";
            this.TxtNHT.Size = new System.Drawing.Size(200, 20);
            this.TxtNHT.TabIndex = 10;
            // 
            // TxtNKC
            // 
            this.TxtNKC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONGTRINH2210900109BindingSource, "NgayKC", true));
            this.TxtNKC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtNKC.Location = new System.Drawing.Point(99, 115);
            this.TxtNKC.Name = "TxtNKC";
            this.TxtNKC.Size = new System.Drawing.Size(200, 20);
            this.TxtNKC.TabIndex = 9;
            this.TxtNKC.ValueChanged += new System.EventHandler(this.TxtNKK_ValueChanged);
            // 
            // TxtTCT
            // 
            this.TxtTCT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONGTRINH2210900109BindingSource, "TenCT", true));
            this.TxtTCT.Location = new System.Drawing.Point(99, 72);
            this.TxtTCT.Name = "TxtTCT";
            this.TxtTCT.Size = new System.Drawing.Size(200, 20);
            this.TxtTCT.TabIndex = 8;
            this.TxtTCT.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONGTRINH2210900109BindingSource, "DiaDiem", true));
            this.textBox2.Location = new System.Drawing.Point(457, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 7;
            // 
            // txtMCT
            // 
            this.txtMCT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONGTRINH2210900109BindingSource, "MaCT", true));
            this.txtMCT.Location = new System.Drawing.Point(99, 31);
            this.txtMCT.Name = "txtMCT";
            this.txtMCT.Size = new System.Drawing.Size(200, 20);
            this.txtMCT.TabIndex = 6;
            // 
            // Txtpb
            // 
            this.Txtpb.AutoSize = true;
            this.Txtpb.Location = new System.Drawing.Point(378, 118);
            this.Txtpb.Name = "Txtpb";
            this.Txtpb.Size = new System.Drawing.Size(59, 13);
            this.Txtpb.TabIndex = 5;
            this.Txtpb.Text = "Phòng ban";
            // 
            // Txtdd
            // 
            this.Txtdd.AutoSize = true;
            this.Txtdd.Location = new System.Drawing.Point(378, 75);
            this.Txtdd.Name = "Txtdd";
            this.Txtdd.Size = new System.Drawing.Size(53, 13);
            this.Txtdd.TabIndex = 4;
            this.Txtdd.Text = "Địa Điểm ";
            // 
            // Txtng
            // 
            this.Txtng.AutoSize = true;
            this.Txtng.Location = new System.Drawing.Point(378, 31);
            this.Txtng.Name = "Txtng";
            this.Txtng.Size = new System.Drawing.Size(50, 13);
            this.Txtng.TabIndex = 3;
            this.Txtng.Text = "Ngày HT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ngày khởi công ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên công trình ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã công trình ";
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(83, 219);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "sửa ";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btdatlai
            // 
            this.btdatlai.Location = new System.Drawing.Point(199, 218);
            this.btdatlai.Name = "btdatlai";
            this.btdatlai.Size = new System.Drawing.Size(75, 23);
            this.btdatlai.TabIndex = 3;
            this.btdatlai.Text = "đặt lại ";
            this.btdatlai.UseVisualStyleBackColor = true;
            this.btdatlai.Click += new System.EventHandler(this.btdatlai_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(318, 219);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 4;
            this.btxoa.Text = "xóa ";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(444, 219);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 5;
            this.btthoat.Text = "thoát ";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // cONGTRINH_2210900109TableAdapter
            // 
            this.cONGTRINH_2210900109TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 509);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btdatlai);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONGTRINH2210900109BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoang_Van_Khai_2210900109_03DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtMaPhong;
        private System.Windows.Forms.DateTimePicker TxtNHT;
        private System.Windows.Forms.DateTimePicker TxtNKC;
        private System.Windows.Forms.TextBox TxtTCT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtMCT;
        private System.Windows.Forms.Label Txtpb;
        private System.Windows.Forms.Label Txtdd;
        private System.Windows.Forms.Label Txtng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btdatlai;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthoat;
        private Hoang_Van_Khai_2210900109_03DataSet hoang_Van_Khai_2210900109_03DataSet;
        private System.Windows.Forms.BindingSource cONGTRINH2210900109BindingSource;
        private Hoang_Van_Khai_2210900109_03DataSetTableAdapters.CONGTRINH_2210900109TableAdapter cONGTRINH_2210900109TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
    }
}

