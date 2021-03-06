using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class DiaBanCTRL
    {
        DiaBanDATA data = new DiaBanDATA();
        public void HienThiDiaBan(TextBox txtMaDB, TextBox txtDiaChi,TextBox txtGhiChu, DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSDiaBan();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            txtMaDB.DataBindings.Add("Text", bs, "MADB");
            txtDiaChi.DataBindings.Add("Text", bs, "DIACHIDB");
            txtGhiChu.DataBindings.Add("Text", bs, "GHICHU");
        }
        public DataGridViewComboBoxColumn LoadComBoxMaDB()
        {
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            cb.DataSource = data.LayDSDiaBan();
            cb.DisplayMember = "DIACHIDB";
            cb.ValueMember = "MADB";
            cb.HeaderText = "Địa Chỉ";
            cb.DataPropertyName = "MADB";
            return cb;
        }
        public void HienThiComboBoxMaDB(ComboBox cmd)
        {
            DiaBanDATA dataDiaBan = new DiaBanDATA();
            cmd.DataSource = dataDiaBan.LayDSDiaBan();
            cmd.DisplayMember = "DIACHIDB";
            cmd.ValueMember = "MADB";
            cmd.SelectedValue = "MADB";
        }
        public void Update()
        {
            data.Update();
        }
    }
}
