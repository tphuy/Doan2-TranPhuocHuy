namespace QLThUOC
{
    partial class FormLapPhieuDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLapPhieuDatHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colMaPhieuDH = new System.Windows.Forms.ColumnHeader();
            this.colMaKH = new System.Windows.Forms.ColumnHeader();
            this.colMaHT = new System.Windows.Forms.ColumnHeader();
            this.colNgayGiao = new System.Windows.Forms.ColumnHeader();
            this.colNoiGiao = new System.Windows.Forms.ColumnHeader();
            this.colNgayLap = new System.Windows.Forms.ColumnHeader();
            this.colTongTien = new System.Windows.Forms.ColumnHeader();
            this.colMaNV = new System.Windows.Forms.ColumnHeader();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colCTSTT = new System.Windows.Forms.ColumnHeader();
            this.colCTMaPhieuDH = new System.Windows.Forms.ColumnHeader();
            this.colMaThuoc = new System.Windows.Forms.ColumnHeader();
            this.colSoLuong = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBoxCTMaPhieuDH = new System.Windows.Forms.TextBox();
            this.ButtonHuyBo = new System.Windows.Forms.Button();
            this.ButtonChon = new System.Windows.Forms.Button();
            this.TBoxSoLuong = new System.Windows.Forms.TextBox();
            this.CBoxMaThuoc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ItemThem = new XPExplorerBar.TaskItem();
            this.ItemThoat = new XPExplorerBar.TaskItem();
            this.ItemXoa = new XPExplorerBar.TaskItem();
            this.ItemLuu = new XPExplorerBar.TaskItem();
            this.DateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.CBoxMaNV = new System.Windows.Forms.ComboBox();
            this.CBoxMaHT = new System.Windows.Forms.ComboBox();
            this.CBoxMaKH = new System.Windows.Forms.ComboBox();
            this.TBoxTongTien = new System.Windows.Forms.TextBox();
            this.TBoxNoiGiao = new System.Windows.Forms.TextBox();
            this.TBoxMaPhieuDH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 578);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu đặt hàng";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listView2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(7, 408);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(773, 191);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin đặt  hàng";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colMaPhieuDH,
            this.colMaKH,
            this.colMaHT,
            this.colNgayGiao,
            this.colNoiGiao,
            this.colNgayLap,
            this.colTongTien,
            this.colMaNV});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(767, 170);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colMaPhieuDH
            // 
            this.colMaPhieuDH.Text = "Mã phiếu";
            this.colMaPhieuDH.Width = 87;
            // 
            // colMaKH
            // 
            this.colMaKH.Text = "Mã khách hàng";
            this.colMaKH.Width = 135;
            // 
            // colMaHT
            // 
            this.colMaHT.Text = "Mã hình thức";
            this.colMaHT.Width = 110;
            // 
            // colNgayGiao
            // 
            this.colNgayGiao.Text = "Ngày giao";
            this.colNgayGiao.Width = 100;
            // 
            // colNoiGiao
            // 
            this.colNoiGiao.Text = "Nơi giao";
            this.colNoiGiao.Width = 86;
            // 
            // colNgayLap
            // 
            this.colNgayLap.Text = "Ngày lập";
            this.colNgayLap.Width = 85;
            // 
            // colTongTien
            // 
            this.colTongTien.Text = "Tổng tiền";
            this.colTongTien.Width = 92;
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã nhân viên";
            this.colMaNV.Width = 117;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listView1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(512, 190);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết đặt hàng";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCTSTT,
            this.colCTMaPhieuDH,
            this.colMaThuoc,
            this.colSoLuong});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(506, 169);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colCTSTT
            // 
            this.colCTSTT.Text = "STT";
            // 
            // colCTMaPhieuDH
            // 
            this.colCTMaPhieuDH.Text = "Mã phiếu";
            this.colCTMaPhieuDH.Width = 92;
            // 
            // colMaThuoc
            // 
            this.colMaThuoc.Text = "Mã thuốc";
            this.colMaThuoc.Width = 85;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 91;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBoxCTMaPhieuDH);
            this.groupBox3.Controls.Add(this.ButtonHuyBo);
            this.groupBox3.Controls.Add(this.ButtonChon);
            this.groupBox3.Controls.Add(this.TBoxSoLuong);
            this.groupBox3.Controls.Add(this.CBoxMaThuoc);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(524, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 190);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết đặt hàng";
            // 
            // TBoxCTMaPhieuDH
            // 
            this.TBoxCTMaPhieuDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxCTMaPhieuDH.Location = new System.Drawing.Point(105, 23);
            this.TBoxCTMaPhieuDH.Name = "TBoxCTMaPhieuDH";
            this.TBoxCTMaPhieuDH.Size = new System.Drawing.Size(100, 20);
            this.TBoxCTMaPhieuDH.TabIndex = 12;
            // 
            // ButtonHuyBo
            // 
            this.ButtonHuyBo.Location = new System.Drawing.Point(124, 114);
            this.ButtonHuyBo.Name = "ButtonHuyBo";
            this.ButtonHuyBo.Size = new System.Drawing.Size(75, 23);
            this.ButtonHuyBo.TabIndex = 11;
            this.ButtonHuyBo.Text = "Hủy bỏ";
            this.ButtonHuyBo.UseVisualStyleBackColor = true;
            // 
            // ButtonChon
            // 
            this.ButtonChon.Location = new System.Drawing.Point(43, 114);
            this.ButtonChon.Name = "ButtonChon";
            this.ButtonChon.Size = new System.Drawing.Size(75, 23);
            this.ButtonChon.TabIndex = 10;
            this.ButtonChon.Text = "Chọn";
            this.ButtonChon.UseVisualStyleBackColor = true;
            this.ButtonChon.Click += new System.EventHandler(this.ButtonChon_Click);
            // 
            // TBoxSoLuong
            // 
            this.TBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxSoLuong.Location = new System.Drawing.Point(105, 75);
            this.TBoxSoLuong.Name = "TBoxSoLuong";
            this.TBoxSoLuong.Size = new System.Drawing.Size(69, 20);
            this.TBoxSoLuong.TabIndex = 7;
            // 
            // CBoxMaThuoc
            // 
            this.CBoxMaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMaThuoc.FormattingEnabled = true;
            this.CBoxMaThuoc.Location = new System.Drawing.Point(105, 48);
            this.CBoxMaThuoc.Name = "CBoxMaThuoc";
            this.CBoxMaThuoc.Size = new System.Drawing.Size(83, 21);
            this.CBoxMaThuoc.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Số lượng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Mã thuốc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã phiếu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.DateTimePickerNgayLap);
            this.groupBox2.Controls.Add(this.DateTimePickerNgayGiao);
            this.groupBox2.Controls.Add(this.CBoxMaNV);
            this.groupBox2.Controls.Add(this.CBoxMaHT);
            this.groupBox2.Controls.Add(this.CBoxMaKH);
            this.groupBox2.Controls.Add(this.TBoxTongTien);
            this.groupBox2.Controls.Add(this.TBoxNoiGiao);
            this.groupBox2.Controls.Add(this.TBoxMaPhieuDH);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 185);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin đặt hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ItemThem);
            this.groupBox4.Controls.Add(this.ItemThoat);
            this.groupBox4.Controls.Add(this.ItemXoa);
            this.groupBox4.Controls.Add(this.ItemLuu);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 51);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // ItemThem
            // 
            this.ItemThem.BackColor = System.Drawing.Color.Transparent;
            this.ItemThem.Image = ((System.Drawing.Image)(resources.GetObject("ItemThem.Image")));
            this.ItemThem.Location = new System.Drawing.Point(134, 21);
            this.ItemThem.Name = "ItemThem";
            this.ItemThem.Size = new System.Drawing.Size(78, 16);
            this.ItemThem.TabIndex = 3;
            this.ItemThem.Text = "Thêm";
            this.ItemThem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ItemThem.UseVisualStyleBackColor = false;
            // 
            // ItemThoat
            // 
            this.ItemThoat.BackColor = System.Drawing.Color.Transparent;
            this.ItemThoat.Image = ((System.Drawing.Image)(resources.GetObject("ItemThoat.Image")));
            this.ItemThoat.Location = new System.Drawing.Point(209, 21);
            this.ItemThoat.Name = "ItemThoat";
            this.ItemThoat.Size = new System.Drawing.Size(69, 16);
            this.ItemThoat.TabIndex = 2;
            this.ItemThoat.Text = "Thoát";
            this.ItemThoat.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ItemThoat.UseVisualStyleBackColor = false;
            // 
            // ItemXoa
            // 
            this.ItemXoa.BackColor = System.Drawing.Color.Transparent;
            this.ItemXoa.Image = ((System.Drawing.Image)(resources.GetObject("ItemXoa.Image")));
            this.ItemXoa.Location = new System.Drawing.Point(71, 21);
            this.ItemXoa.Name = "ItemXoa";
            this.ItemXoa.Size = new System.Drawing.Size(58, 16);
            this.ItemXoa.TabIndex = 1;
            this.ItemXoa.Text = "Xóa";
            this.ItemXoa.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ItemXoa.UseVisualStyleBackColor = false;
            // 
            // ItemLuu
            // 
            this.ItemLuu.BackColor = System.Drawing.Color.Transparent;
            this.ItemLuu.Image = ((System.Drawing.Image)(resources.GetObject("ItemLuu.Image")));
            this.ItemLuu.Location = new System.Drawing.Point(6, 21);
            this.ItemLuu.Name = "ItemLuu";
            this.ItemLuu.Size = new System.Drawing.Size(59, 16);
            this.ItemLuu.TabIndex = 0;
            this.ItemLuu.Text = "Lưu";
            this.ItemLuu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ItemLuu.UseVisualStyleBackColor = false;
            this.ItemLuu.Click += new System.EventHandler(this.ItemLuu_Click);
            // 
            // DateTimePickerNgayLap
            // 
            this.DateTimePickerNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerNgayLap.Location = new System.Drawing.Point(472, 49);
            this.DateTimePickerNgayLap.Name = "DateTimePickerNgayLap";
            this.DateTimePickerNgayLap.Size = new System.Drawing.Size(215, 20);
            this.DateTimePickerNgayLap.TabIndex = 17;
            // 
            // DateTimePickerNgayGiao
            // 
            this.DateTimePickerNgayGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerNgayGiao.Location = new System.Drawing.Point(126, 101);
            this.DateTimePickerNgayGiao.Name = "DateTimePickerNgayGiao";
            this.DateTimePickerNgayGiao.Size = new System.Drawing.Size(215, 20);
            this.DateTimePickerNgayGiao.TabIndex = 16;
            // 
            // CBoxMaNV
            // 
            this.CBoxMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMaNV.FormattingEnabled = true;
            this.CBoxMaNV.Location = new System.Drawing.Point(472, 100);
            this.CBoxMaNV.Name = "CBoxMaNV";
            this.CBoxMaNV.Size = new System.Drawing.Size(80, 21);
            this.CBoxMaNV.TabIndex = 15;
            // 
            // CBoxMaHT
            // 
            this.CBoxMaHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMaHT.FormattingEnabled = true;
            this.CBoxMaHT.Location = new System.Drawing.Point(126, 74);
            this.CBoxMaHT.Name = "CBoxMaHT";
            this.CBoxMaHT.Size = new System.Drawing.Size(80, 21);
            this.CBoxMaHT.TabIndex = 14;
            // 
            // CBoxMaKH
            // 
            this.CBoxMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxMaKH.FormattingEnabled = true;
            this.CBoxMaKH.Location = new System.Drawing.Point(126, 48);
            this.CBoxMaKH.Name = "CBoxMaKH";
            this.CBoxMaKH.Size = new System.Drawing.Size(80, 21);
            this.CBoxMaKH.TabIndex = 13;
            // 
            // TBoxTongTien
            // 
            this.TBoxTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxTongTien.Location = new System.Drawing.Point(472, 75);
            this.TBoxTongTien.Name = "TBoxTongTien";
            this.TBoxTongTien.Size = new System.Drawing.Size(100, 20);
            this.TBoxTongTien.TabIndex = 12;
            // 
            // TBoxNoiGiao
            // 
            this.TBoxNoiGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxNoiGiao.Location = new System.Drawing.Point(472, 21);
            this.TBoxNoiGiao.Name = "TBoxNoiGiao";
            this.TBoxNoiGiao.Size = new System.Drawing.Size(252, 20);
            this.TBoxNoiGiao.TabIndex = 10;
            // 
            // TBoxMaPhieuDH
            // 
            this.TBoxMaPhieuDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxMaPhieuDH.Location = new System.Drawing.Point(126, 23);
            this.TBoxMaPhieuDH.Name = "TBoxMaPhieuDH";
            this.TBoxMaPhieuDH.Size = new System.Drawing.Size(80, 20);
            this.TBoxMaPhieuDH.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã nhân viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tổng tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày lập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nơi giao:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày giao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hình thức:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // FormLapPhieuDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 578);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLapPhieuDatHang";
            this.Text = "FormLapPhieuDatHang";
            this.Load += new System.EventHandler(this.FormLapPhieuDatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxTongTien;
        private System.Windows.Forms.TextBox TBoxNoiGiao;
        private System.Windows.Forms.TextBox TBoxMaPhieuDH;
        private System.Windows.Forms.ComboBox CBoxMaNV;
        private System.Windows.Forms.ComboBox CBoxMaHT;
        private System.Windows.Forms.ComboBox CBoxMaKH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TBoxSoLuong;
        private System.Windows.Forms.ComboBox CBoxMaThuoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateTimePickerNgayLap;
        private System.Windows.Forms.DateTimePicker DateTimePickerNgayGiao;
        private System.Windows.Forms.GroupBox groupBox4;
        private XPExplorerBar.TaskItem ItemThem;
        private XPExplorerBar.TaskItem ItemThoat;
        private XPExplorerBar.TaskItem ItemXoa;
        private XPExplorerBar.TaskItem ItemLuu;
        private System.Windows.Forms.Button ButtonHuyBo;
        private System.Windows.Forms.Button ButtonChon;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox TBoxCTMaPhieuDH;
        private System.Windows.Forms.ColumnHeader colCTSTT;
        private System.Windows.Forms.ColumnHeader colCTMaPhieuDH;
        private System.Windows.Forms.ColumnHeader colMaThuoc;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colMaPhieuDH;
        private System.Windows.Forms.ColumnHeader colMaKH;
        private System.Windows.Forms.ColumnHeader colMaHT;
        private System.Windows.Forms.ColumnHeader colNgayGiao;
        private System.Windows.Forms.ColumnHeader colNoiGiao;
        private System.Windows.Forms.ColumnHeader colNgayLap;
        private System.Windows.Forms.ColumnHeader colTongTien;
        private System.Windows.Forms.ColumnHeader colMaNV;
    }
}