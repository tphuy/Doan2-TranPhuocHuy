using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class ThuocCTRL
    {
        ThuocDATA data = new ThuocDATA();
        public void HienThiThuoc(TextBox txtMaThuoc,TextBox txtTenThuoc,ComboBox ctxMaDVT,TextBox txtSoLuong,TextBox txtDonGiaMua,TextBox txtDonGiaBan,ComboBox ctxMaLoaiThuoc,DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSThuoc();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            txtMaThuoc.DataBindings.Add("Text", bs, "MATHUOC");
            txtTenThuoc.DataBindings.Add("Text", bs, "TENTHUOC");
            ctxMaDVT.DataBindings.Add("SelectedValue", bs, "MADVT");
            txtSoLuong.DataBindings.Add("Text", bs, "SOLUONG");
            txtDonGiaMua.DataBindings.Add("Text", bs, "DONGIAMUA");
            txtDonGiaBan.DataBindings.Add("Text", bs, "DONGIABAN");
            ctxMaLoaiThuoc.DataBindings.Add("SelectedValue", bs, "MALOAITHUOC");
            //Load ComboBoxMaDVT
            DonViTinhCTRL ctrlDVT = new DonViTinhCTRL();
            ctrlDVT.HienThiComboBoxMaDVT(ctxMaDVT);
            dg.Columns.Add(ctrlDVT.LoadComboBoxMaDVT());
            dg.Columns.Remove("MADVT");
            //Load ComboBoxMaLoaiThuoc
            LoaiThuocCTRL ctrlLoaiThuoc = new LoaiThuocCTRL();
            ctrlLoaiThuoc.HienThiComboBoxMaLoaiThuoc(ctxMaLoaiThuoc);
            dg.Columns.Add(ctrlLoaiThuoc.LoadComboBoxMaLoaiThuoc());
            dg.Columns.Remove("MALOAITHUOC");
        }
        public DataGridViewComboBoxColumn LoadComboBoxMaThuoc()
        {
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.DataSource = data.LayDSThuoc();
            cb.DisplayMember = "TENTHUOC";
            cb.ValueMember = "MATHUOC";
            cb.HeaderText = "Tên thuốc";
            cb.DataPropertyName = "MATHUOC";
            return cb;
        }
        public void HienThiComboBoxMaThuoc(ComboBox cmd)
        {
            ThuocDATA dataThuoc = new ThuocDATA();
            cmd.DataSource = dataThuoc.LayDSThuoc();
            cmd.DisplayMember = "TENTHUOC";
            cmd.ValueMember = "MATHUOC";
            cmd.SelectedValue = "MATHUOC";
        }
        public void TimKiemThuoc(TextBox txtMaThuoc, ComboBox ctxChonTenThuoc, TextBox txtTenThuoc, DataGridView dg)
        {
            DataTable table = data.TimKiemThuoc(txtMaThuoc.Text, ctxChonTenThuoc.Text, txtTenThuoc.Text);
            dg.DataSource = table;
        }
        public void Update()
        {
            data.Update();
        }
    }
}
