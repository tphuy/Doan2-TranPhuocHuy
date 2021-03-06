using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class TrinhDuocVienCTRL
    {
        TrinhDuocVienDATA data = new TrinhDuocVienDATA();
        public void HienThiTDVien(TextBox txtMaTDV,TextBox txtHoTenTDV,TextBox txtDiaChi,TextBox txtGioiTinh,TextBox txtDienThoai,DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDLTDVien();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            txtMaTDV.DataBindings.Add("Text", bs, "MATDV");
            txtHoTenTDV.DataBindings.Add("Text", bs, "HOTENTDV");
            txtGioiTinh.DataBindings.Add("Text", bs, "GIOITINH");
            txtDiaChi.DataBindings.Add("Text", bs, "DIACHI");
            txtDienThoai.DataBindings.Add("Text", bs, "DIENTHOAI");
        }
        public DataGridViewComboBoxColumn LoadComboxMATDV()
        {
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.DataSource = data.LayDLTDVien();
            cb.DisplayMember = "HOTENTDV";
            cb.ValueMember = "MATDV";
            cb.HeaderText = "Tên trình dược viên";
            cb.DataPropertyName = "MATDV";
            return cb;
        }
        public void HienThiComboBoxMaTDV(ComboBox cmd)
        {
            TrinhDuocVienDATA dataTDV = new TrinhDuocVienDATA();
            cmd.DataSource = dataTDV.LayDLTDVien();
            cmd.DisplayMember = "HOTENTDV";
            cmd.ValueMember = "MATDV";
            cmd.SelectedValue = "MATDV";
        }
        public void TimKiemTDV(TextBox txtMaTDV, ComboBox ctxChonTenTDV, TextBox txtTenTDV, ComboBox ctxChonDiaChi, TextBox txtDiaChi, DataGridView dg)
        {
            DataTable table = data.TimKiemTDV(txtMaTDV.Text, ctxChonTenTDV.Text, txtTenTDV.Text, ctxChonDiaChi.Text, txtDiaChi.Text);
            dg.DataSource = table;
        }
        public void Update()
        {
            data.Update();
        }
    }
}
