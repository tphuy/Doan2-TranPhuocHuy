using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class LoaiKhachHangCTRL
    {
        LoaiKhachHangDATA data = new LoaiKhachHangDATA();
        public void HienThiLoaiKhachHang(TextBox txtMaLoai, TextBox txtTenLoai, DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSLoaiKhachHang();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            txtMaLoai.DataBindings.Add("Text", bs, "MALOAIKH");
            txtTenLoai.DataBindings.Add("Text", bs, "TENLOAIKH");
        }
        public DataGridViewComboBoxColumn LoadComboBox()
        {
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.DataSource = data.LayDSLoaiKhachHang();
            cb.DisplayMember = "TENLOAIKH";
            cb.ValueMember = "MALOAIKH";
            cb.HeaderText = "Tên loại khách hàng";
            cb.DataPropertyName = "MALOAIKH";
            return cb;
        }
        public void HienThiComboBoxMaLoaiKH(ComboBox cmd)
        {
            LoaiKhachHangDATA dataLoaiKH = new LoaiKhachHangDATA();
            cmd.DataSource = dataLoaiKH.LayDSLoaiKhachHang();
            cmd.DisplayMember = "TENLOAIKH";
            cmd.ValueMember = "MALOAIKH";
            cmd.SelectedValue = "MALOAIKH";
        }
        public void Update()
        {
            data.Update();
        }
    }
}
