namespace HaMinhTrung_0279
{
    partial class GUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtxeploai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateNS = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xepLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHONGTINSINHVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doAnMonHocDataSet1 = new HaMinhTrung_0279.DoAnMonHocDataSet1();
            this.tHONGTINSINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btexport = new System.Windows.Forms.Button();
            this.tHONGTINSINHVIENTableAdapter1 = new HaMinhTrung_0279.DoAnMonHocDataSet1TableAdapters.THONGTINSINHVIENTableAdapter();
            this.btImport = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btBrowse = new System.Windows.Forms.Button();
            this.txtTextbox = new System.Windows.Forms.TextBox();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINSINHVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnMonHocDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINSINHVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtxeploai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdiem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateNS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(103, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1039, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin và điểm sinh viên";
            // 
            // txtxeploai
            // 
            this.txtxeploai.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtxeploai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxeploai.Location = new System.Drawing.Point(893, 79);
            this.txtxeploai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtxeploai.Name = "txtxeploai";
            this.txtxeploai.Size = new System.Drawing.Size(132, 30);
            this.txtxeploai.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(813, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Xếp loại:";
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(715, 130);
            this.txtdiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(57, 30);
            this.txtdiem.TabIndex = 9;
            this.txtdiem.TextChanged += new System.EventHandler(this.txtdiem_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(645, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điểm:";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(492, 130);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(136, 30);
            this.txtdiachi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ:";
            // 
            // dateNS
            // 
            this.dateNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNS.Location = new System.Drawing.Point(492, 65);
            this.dateNS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNS.Name = "dateNS";
            this.dateNS.Size = new System.Drawing.Size(280, 27);
            this.dateNS.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(161, 134);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(217, 30);
            this.txtTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sinh viên:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(161, 60);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(217, 30);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý điểm sinh viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSinhVien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(103, 322);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1039, 299);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển thị thông tin";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoGenerateColumns = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.tenSVDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn,
            this.xepLoaiDataGridViewTextBoxColumn});
            this.dgvSinhVien.DataSource = this.tHONGTINSINHVIENBindingSource1;
            this.dgvSinhVien.Location = new System.Drawing.Point(6, 27);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(1027, 263);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSVDataGridViewTextBoxColumn
            // 
            this.tenSVDataGridViewTextBoxColumn.DataPropertyName = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.HeaderText = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSVDataGridViewTextBoxColumn.Name = "tenSVDataGridViewTextBoxColumn";
            this.tenSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Diem";
            this.diemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.Width = 125;
            // 
            // xepLoaiDataGridViewTextBoxColumn
            // 
            this.xepLoaiDataGridViewTextBoxColumn.DataPropertyName = "XepLoai";
            this.xepLoaiDataGridViewTextBoxColumn.HeaderText = "XepLoai";
            this.xepLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xepLoaiDataGridViewTextBoxColumn.Name = "xepLoaiDataGridViewTextBoxColumn";
            this.xepLoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tHONGTINSINHVIENBindingSource1
            // 
            this.tHONGTINSINHVIENBindingSource1.DataMember = "THONGTINSINHVIEN";
            this.tHONGTINSINHVIENBindingSource1.DataSource = this.doAnMonHocDataSet1;
            // 
            // doAnMonHocDataSet1
            // 
            this.doAnMonHocDataSet1.DataSetName = "DoAnMonHocDataSet1";
            this.doAnMonHocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHONGTINSINHVIENBindingSource
            // 
            this.tHONGTINSINHVIENBindingSource.DataMember = "THONGTINSINHVIEN";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btThem.Location = new System.Drawing.Point(109, 641);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(147, 68);
            this.btThem.TabIndex = 14;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btXoa.Location = new System.Drawing.Point(333, 641);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(139, 68);
            this.btXoa.TabIndex = 15;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btThoat.Location = new System.Drawing.Point(1007, 641);
            this.btThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(129, 68);
            this.btThoat.TabIndex = 16;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btReset.Location = new System.Drawing.Point(796, 641);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(131, 68);
            this.btReset.TabIndex = 17;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSua.Location = new System.Drawing.Point(568, 641);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(133, 68);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btexport
            // 
            this.btexport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btexport.Location = new System.Drawing.Point(1187, 349);
            this.btexport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btexport.Name = "btexport";
            this.btexport.Size = new System.Drawing.Size(129, 68);
            this.btexport.TabIndex = 19;
            this.btexport.Text = "Export";
            this.btexport.UseVisualStyleBackColor = false;
            this.btexport.Click += new System.EventHandler(this.btexport_Click);
            // 
            // tHONGTINSINHVIENTableAdapter1
            // 
            this.tHONGTINSINHVIENTableAdapter1.ClearBeforeFill = true;
            // 
            // btImport
            // 
            this.btImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btImport.Location = new System.Drawing.Point(1187, 451);
            this.btImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(129, 68);
            this.btImport.TabIndex = 20;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = false;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSave.Location = new System.Drawing.Point(1187, 544);
            this.btSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(129, 68);
            this.btSave.TabIndex = 21;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btBrowse
            // 
            this.btBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btBrowse.Location = new System.Drawing.Point(1187, 252);
            this.btBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(129, 68);
            this.btBrowse.TabIndex = 22;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = false;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // txtTextbox
            // 
            this.txtTextbox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextbox.Location = new System.Drawing.Point(1345, 268);
            this.txtTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTextbox.Name = "txtTextbox";
            this.txtTextbox.Size = new System.Drawing.Size(197, 30);
            this.txtTextbox.TabIndex = 12;
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 721);
            this.Controls.Add(this.txtTextbox);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btexport);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI";
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINSINHVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAnMonHocDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINSINHVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateNS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.TextBox txtxeploai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btexport;
      
        private System.Windows.Forms.BindingSource tHONGTINSINHVIENBindingSource;
       
        private DoAnMonHocDataSet1 doAnMonHocDataSet1;
        private System.Windows.Forms.BindingSource tHONGTINSINHVIENBindingSource1;
        private DoAnMonHocDataSet1TableAdapters.THONGTINSINHVIENTableAdapter tHONGTINSINHVIENTableAdapter1;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.TextBox txtTextbox;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xepLoaiDataGridViewTextBoxColumn;
    }
}

