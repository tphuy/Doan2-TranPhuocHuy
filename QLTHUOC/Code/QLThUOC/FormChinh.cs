using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLThUOC.Controller;

namespace QLThUOC
{
    public partial class FormChinh : Form
    {
        FormNhaCungCap fm1 = null;
        FormNhanVien fm2 = null;
        FormKhachHang fm3 = null;
        FormLapHopDongMuaThuoc fm4 = null;
        FormPhanCongDiaBan fm5 = null;
        FormThuoc fm6 = null;
        FormLapPhieuNhanHang fm7 = null;
        FormLapPhieuNhapKho fm8 = null;
        FormLapPhieuXuatKho fm9 = null;
        FormThanhToanLuong fm10 = null;
        FormTinhHinhBanThuoc fm11 = null;
        FormTinhHinhLamViec fm12 = null;
        FormDangNhap fm13 = null;
        FormTrinhDuocVien fm14 = null;
        FormKho fm15 = null;
        FormLoThuoc fm16 = null;
        FormDonViTinh fm17 = null;
        FormHinhThucThanhToan fm18 = null;
        FormLoaiKhachHang fm19 = null;
        FormLoaiThuoc fm20 = null;
        FormLapPhieuThanhLi fm21 = null;
        FormLapPhieuDatHang fm22 = null;
        FormDiaBan fm23 = null;
        FormTKKhachHang fm24 = null;
        FormTKNhaCungCap fm25 = null;
        FormTKNhanVien fm26 = null;
        FormTKThuoc fm27 = null;
        FormTKLoThuoc fm28 = null;
        FormTKTrinhDuocVien fm29 = null;
        FormDesigner fm30 = null;
        FormTKPhieuNhanHang fm31 = null;
        FormTKPhieuNhapKho fm32 = null;
        FormTKPhieuXuatKho fm33 = null;
        FormTKPhieuThanhLi fm34 = null;
        FormTKPhieuDatHang fm35 = null;
        FormTKHopDongMuaThuoc fm36 = null;
        FormReportNhaCC fm37 = null;
        FormReportNhanVien fm38 = null;
        FormReportKhachHang fm39 = null;
        FormReportPhanCong fm40 = null;
        FormReportThuoc fm41 = null;
        FormReportPhieuNhanHang fm42 = null;
        FormReportPhieuNhapKho fm43 = null;
        FormReportPhieuXuatKho fm44 = null;
        public FormChinh()
        {
            InitializeComponent();

        }

        private void NhaCungCapStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm1 == null || fm1.IsDisposed)
            {
                fm1 = new FormNhaCungCap();
                fm1.MdiParent = this;
                fm1.Show();
            }
        }

        private void NhanVien_Click(object sender, EventArgs e)
        {
            if (fm2 == null || fm2.IsDisposed)
            {
                fm2 = new FormNhanVien();
                fm2.MdiParent = this;
                fm2.Show();
            }
        }

        private void KhachHang_Click(object sender, EventArgs e)
        {
            if (fm3 == null || fm3.IsDisposed)
            {
                fm3 = new FormKhachHang();
                fm3.MdiParent = this;
                fm3.Show();
            }
        }


        private void PhanCongDiaBan_Click(object sender, EventArgs e)
        {
            if (fm5 == null || fm5.IsDisposed)
            {
                fm5 = new FormPhanCongDiaBan();
                fm5.MdiParent = this;
                fm5.Show();
            }

        }
        private void LapHoaDonNhanHang_Click(object sender, EventArgs e)
        {
            if (fm7 == null || fm7.IsDisposed)
            {
                fm7 = new FormLapPhieuNhanHang();
                fm7.MdiParent = this;
                fm7.Show();
            }
        }

        private void LapPhieuNhapKho_Click(object sender, EventArgs e)
        {
            if (fm8 == null || fm8.IsDisposed)
            {
                fm8 = new FormLapPhieuNhapKho();
                fm8.MdiParent = this;
                fm8.Show();
            }
        }

        private void LapPhieuXuatKho_Click(object sender, EventArgs e)
        {
            if (fm9 == null || fm9.IsDisposed)
            {
                fm9 = new FormLapPhieuXuatKho();
                fm9.MdiParent = this;
                fm9.Show();
            }
        }
        private void TinhHinhBanThuoc_Click(object sender, EventArgs e)
        {
            if (fm11 == null || fm11.IsDisposed)
            {
                fm11 = new FormTinhHinhBanThuoc();
                fm11.MdiParent = this;
                fm11.Show();
            }
        }

        private void TinhHinhLamViec_Click(object sender, EventArgs e)
        {
            if (fm12 == null || fm12.IsDisposed)
            {
                fm12 = new FormTinhHinhLamViec();
                fm12.MdiParent = this;
                fm12.Show();
            }
        }
       /* private void DangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap();
        }*/


        private void TrinhDuocVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (fm14 == null || fm14.IsDisposed)
                {
                    fm14 = new FormTrinhDuocVien();
                    fm14.MdiParent = this;
                    fm14.Show();
                }
        }

        private void Thuoc_Click(object sender, EventArgs e)
        {
            if (fm6 == null || fm6.IsDisposed)
            {
                fm6 = new FormThuoc();
                fm6.MdiParent = this;
                fm6.Show();
            }
        }

        private void ThoatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm15 == null || fm15.IsDisposed)
            {
                fm15 = new FormKho();
                fm15.MdiParent = this;
                fm15.Show();
            }
        }

        private void LoThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm16 == null || fm16.IsDisposed)
            {
                fm16 = new FormLoThuoc();
                fm16.MdiParent = this;
                fm16.Show();
            }
        }

        private void DonViTinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm17 == null || fm17.IsDisposed)
            {
                fm17 = new FormDonViTinh();
                fm17.MdiParent = this;
                fm17.Show();
            }
        }

        private void HinhThucThanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm18 == null || fm18.IsDisposed)
            {
                fm18 = new FormHinhThucThanhToan();
                fm18.MdiParent = this;
                fm18.Show();
            }
        }

        private void LoaiKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm19 == null || fm19.IsDisposed)
            {
                fm19 = new FormLoaiKhachHang();
                fm19.MdiParent = this;
                fm19.Show();
            }
        }

        private void LoaiThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm20 == null || fm20.IsDisposed)
            {
                fm20 = new FormLoaiThuoc();
                fm20.MdiParent = this;
                fm20.Show();
            }
        }

        private void LapHopDongMuaThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm4 == null || fm4.IsDisposed)
            {
                fm4 = new FormLapHopDongMuaThuoc();
                fm4.MdiParent = this;
                fm4.Show();
            }

        }

        private void LapPhieuThanhLiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm21 == null || fm21.IsDisposed)
            {
                fm21 = new FormLapPhieuThanhLi();
                fm21.MdiParent = this;
                fm21.Show();
            }
        }

        private void LapPhieuDatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm22 == null || fm22.IsDisposed)
            {
                fm22 = new FormLapPhieuDatHang();
                fm22.MdiParent = this;
                fm22.Show();
            }
        }

        private void ThanhToanLuong_Click(object sender, EventArgs e)
        {      
            if (fm10 == null || fm10.IsDisposed)
            {
                fm10 = new FormThanhToanLuong();
                fm10.MdiParent = this;
                fm10.Show();
            }
        
        }

        private void DiaBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm23 == null || fm23.IsDisposed)
            {
                fm23 = new FormDiaBan();
                fm23.MdiParent = this;
                fm23.Show();
            }
        }

        private void TKKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm24 == null || fm24.IsDisposed)
            {
                fm24 = new FormTKKhachHang();
                fm24.MdiParent = this;
                fm24.Show();
            }
        }

        private void TKNhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm25 == null || fm25.IsDisposed)
            {
                fm25 = new FormTKNhaCungCap();
                fm25.MdiParent = this;
                fm25.Show();
            }
        }

        private void TKNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm26 == null || fm26.IsDisposed)
            {
                fm26 = new FormTKNhanVien();
                fm26.MdiParent = this;
                fm26.Show();
            }
        }

        private void TKThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm27 == null || fm27.IsDisposed)
            {
                fm27 = new FormTKThuoc();
                fm27.MdiParent = this;
                fm27.Show();
            }
        }

        private void TKLoThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm28 == null || fm28.IsDisposed)
            {
                fm28 = new FormTKLoThuoc();
                fm28.MdiParent = this;
                fm28.Show();
            }
        }

        private void TKTrinhDuocVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fm29 == null || fm29.IsDisposed)
            {
                fm29 = new FormTKTrinhDuocVien();
                fm29.MdiParent = this;
                fm29.Show();
            }
        }

        private void NguoiThietKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm30 == null || fm30.IsDisposed)
            {
                fm30 = new FormDesigner();
                fm30.MdiParent = this;
                fm30.Show();
            }
        }

        private void TKPhieuNhanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm31 == null || fm31.IsDisposed)
            {
                fm31 = new FormTKPhieuNhanHang();
                fm31.MdiParent = this;
                fm31.Show();
            }
        }

        private void TKPhieuNKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm32 == null || fm32.IsDisposed)
            {
                fm32 = new FormTKPhieuNhapKho();
                fm32.MdiParent = this;
                fm32.Show();
            }
        }

        private void TKPhieuXuatKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm33 == null || fm33.IsDisposed)
            {
                fm33 = new FormTKPhieuXuatKho();
                fm33.MdiParent = this;
                fm33.Show();
            }
        }

        private void TKPhieuThanhLiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm34 == null || fm34.IsDisposed)
            {
                fm34 = new FormTKPhieuThanhLi();
                fm34.MdiParent = this;
                fm34.Show();
            }
        }

        private void TKPhieuDatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm35 == null || fm35.IsDisposed)
            {
                fm35 = new FormTKPhieuDatHang();
                fm35.MdiParent = this;
                fm35.Show();
            }
        }

        private void TKHopDongMuaThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm36 == null || fm36.IsDisposed)
            {
                fm36 = new FormTKHopDongMuaThuoc();
                fm36.MdiParent = this;
                fm36.Show();
            }
        }
        private void FormChinh_Shown(object sender, EventArgs e)
        {
        TiepTuc:
            if (fm13 == null || fm13.IsDisposed)

                fm13 = new FormDangNhap();


            if (fm13.ShowDialog() == DialogResult.OK)
            {
                String tendangnhap = fm13.txtBoxTen.Text;
                String matkhau = fm13.txtBoxMatKhau.Text;
                NhanVienCTRL ctrlNhanVien = new NhanVienCTRL();
                int ketqua = ctrlNhanVien.DangNhap(tendangnhap, matkhau);

                switch (ketqua)
                {
                    case 0:
                        MessageBox.Show("Không tồn tại người dùng này trong hệ thống");
                        goto TiepTuc;

                    case 1:
                        MessageBox.Show("Đăng nhập thành công");
                        break;


                    case 2:
                        MessageBox.Show("Sai mật khẩu");
                        goto TiepTuc;
                }
            }
            else
                this.Close();
        }

        private void NhaCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm37 == null || fm37.IsDisposed)
            {
                fm37 = new FormReportNhaCC();
                fm37.MdiParent = this;
                fm37.Show();
            }
        }

        private void NhanVientoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm38 == null || fm38.IsDisposed)
            {
                fm38 = new FormReportNhanVien();
                fm38.MdiParent = this;
                fm38.Show();
            }
        }

        private void KhachHangtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm39 == null || fm39.IsDisposed)
            {
                fm39 = new FormReportKhachHang();
                fm39.MdiParent = this;
                fm39.Show();
            }
        }

        private void PhanCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm40 == null || fm40.IsDisposed)
            {
                fm40 = new FormReportPhanCong();
                fm40.MdiParent = this;
                fm40.Show();
            }
        }

        private void ThuoctoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm41 == null || fm41.IsDisposed)
            {
                fm41 = new FormReportThuoc();
                fm41.MdiParent = this;
                fm41.Show();
            }
        }

        private void PhieuNhanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm42 == null || fm42.IsDisposed)
            {
                fm42 = new FormReportPhieuNhanHang();
                fm42.MdiParent = this;
                fm42.Show();
            }
        }

        private void PhieuNhapKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm43 == null || fm43.IsDisposed)
            {
                fm43 = new FormReportPhieuNhapKho();
                fm43.MdiParent = this;
                fm43.Show();
            }
        }

        private void PhieuXuatKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fm44 == null || fm44.IsDisposed)
            {
                fm44 = new FormReportPhieuXuatKho();
                fm44.MdiParent = this;
                fm44.Show();
            }
        }

        private void HuongDanSuDung_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.TableOfContents);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (fm7 == null || fm7.IsDisposed)
            {
                fm7 = new FormLapPhieuNhanHang();
                fm7.MdiParent = this;
                fm7.Show();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (fm8 == null || fm8.IsDisposed)
            {
                fm8 = new FormLapPhieuNhapKho();
                fm8.MdiParent = this;
                fm8.Show();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (fm9 == null || fm9.IsDisposed)
            {
                fm9 = new FormLapPhieuXuatKho();
                fm9.MdiParent = this;
                fm9.Show();
            }
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (fm4 == null || fm4.IsDisposed)
            {
                fm4 = new FormLapHopDongMuaThuoc();
                fm4.MdiParent = this;
                fm4.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (fm21 == null || fm21.IsDisposed)
            {
                fm21 = new FormLapPhieuThanhLi();
                fm21.MdiParent = this;
                fm21.Show();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (fm22 == null || fm22.IsDisposed)
            {
                fm22 = new FormLapPhieuDatHang();
                fm22.MdiParent = this;
                fm22.Show();
            }
        }

        private void taskItem1_Click(object sender, EventArgs e)
        {
            if (fm1 == null || fm1.IsDisposed)
            {
                fm1 = new FormNhaCungCap();
                fm1.MdiParent = this;
                fm1.Show();
            }
        }

        private void taskItem2_Click(object sender, EventArgs e)
        {
            if (fm2 == null || fm2.IsDisposed)
            {
                fm2 = new FormNhanVien();
                fm2.MdiParent = this;
                fm2.Show();
            }
        }

        private void taskItem3_Click(object sender, EventArgs e)
        {
            if (fm3 == null || fm3.IsDisposed)
            {
                fm3 = new FormKhachHang();
                fm3.MdiParent = this;
                fm3.Show();
            }
        }

        private void taskItem10_Click(object sender, EventArgs e)
        {
            if (fm14 == null || fm14.IsDisposed)
            {
                fm14 = new FormTrinhDuocVien();
                fm14.MdiParent = this;
                fm14.Show();
            }
        }

        private void taskItem4_Click(object sender, EventArgs e)
        {
            if (fm5 == null || fm5.IsDisposed)
            {
                fm5 = new FormPhanCongDiaBan();
                fm5.MdiParent = this;
                fm5.Show();
            }
        }

        private void taskItem6_Click(object sender, EventArgs e)
        {
            if (fm6 == null || fm6.IsDisposed)
            {
                fm6 = new FormThuoc();
                fm6.MdiParent = this;
                fm6.Show();
            }
        }

        private void taskItem7_Click(object sender, EventArgs e)
        {
            if (fm7 == null || fm7.IsDisposed)
            {
                fm7 = new FormLapPhieuNhanHang();
                fm7.MdiParent = this;
                fm7.Show();
            }
        }

        private void taskItem9_Click(object sender, EventArgs e)
        {
            if (fm8 == null || fm8.IsDisposed)
            {
                fm8 = new FormLapPhieuNhapKho();
                fm8.MdiParent = this;
                fm8.Show();
            }
        }

        private void taskItem8_Click(object sender, EventArgs e)
        {
            if (fm9 == null || fm9.IsDisposed)
            {
                fm9 = new FormLapPhieuXuatKho();
                fm9.MdiParent = this;
                fm9.Show();
            }
        }

        private void taskItem5_Click(object sender, EventArgs e)
        {
            if (fm4 == null || fm4.IsDisposed)
            {
                fm4 = new FormLapHopDongMuaThuoc();
                fm4.MdiParent = this;
                fm4.Show();
            }
        }

        private void taskItem11_Click(object sender, EventArgs e)
        {
            if (fm21 == null || fm21.IsDisposed)
            {
                fm21 = new FormLapPhieuThanhLi();
                fm21.MdiParent = this;
                fm21.Show();
            }
        }

        private void taskItem12_Click(object sender, EventArgs e)
        {
            if (fm22 == null || fm22.IsDisposed)
            {
                fm22 = new FormLapPhieuDatHang();
                fm22.MdiParent = this;
                fm22.Show();
            }
        }

        private void taskItem13_Click(object sender, EventArgs e)
        {
            if (fm24 == null || fm24.IsDisposed)
            {
                fm24 = new FormTKKhachHang();
                fm24.MdiParent = this;
                fm24.Show();
            }
        }

        private void taskItem14_Click(object sender, EventArgs e)
        {
            if (fm25 == null || fm25.IsDisposed)
            {
                fm25 = new FormTKNhaCungCap();
                fm25.MdiParent = this;
                fm25.Show();
            }
        }

        private void taskItem15_Click(object sender, EventArgs e)
        {
            if (fm31 == null || fm31.IsDisposed)
            {
                fm31 = new FormTKPhieuNhanHang();
                fm31.MdiParent = this;
                fm31.Show();
            }
        }

        private void taskItem16_Click(object sender, EventArgs e)
        {
            if (fm32 == null || fm32.IsDisposed)
            {
                fm32 = new FormTKPhieuNhapKho();
                fm32.MdiParent = this;
                fm32.Show();
            }
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {

        }

        private void expando2_StateChanged(object sender, XPExplorerBar.ExpandoEventArgs e)
        {

        }
    }
}