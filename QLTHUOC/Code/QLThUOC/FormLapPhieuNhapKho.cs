using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLThUOC.Controller;

namespace QLThUOC
{
    public partial class FormLapPhieuNhapKho : Form
    {
        LapPhieuNhapKhoCTRL ctrlPhieuNhapKho = new LapPhieuNhapKhoCTRL();
        CTPhieuNhapKhoCTRL ctrlCTPhieuNhapKho = new CTPhieuNhapKhoCTRL();
        public FormLapPhieuNhapKho()
        {
            InitializeComponent();
        }

        private void FormLapPhieuNhapKho_Load(object sender, EventArgs e)
        {
            ctrlPhieuNhapKho.HienThiListViewLapPhieuNhapKho(listView2);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listView2.SelectedItems.GetEnumerator();

            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                TBoxMaPhieuNK.Text = item.SubItems[1].Text;                
                DateTimePickerNgayNhapKho.Text = item.SubItems[2].Text;                
                CBoxMaNV.Text = item.SubItems[3].Text;
                CBoxMaKho.Text = item.SubItems[4].Text;
               ctrlCTPhieuNhapKho.HienThiListViewCTPhieuNhapKho(listView1, item.SubItems[1].Text);
            }
        }

        private void ButtonChon_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem((this.listView1.Items.Count + 1).ToString());
            li.SubItems.Add(this.TBoxCTMaPhieuNK.Text);
            li.SubItems.Add(this.CBoxMaThuoc.Text);         
            this.listView1.Items.Add(li);
        }

        private void ItemLuu_Click(object sender, EventArgs e)
        {
            ctrlPhieuNhapKho.Luu_PhieuNhapKho(TBoxMaPhieuNK, DateTimePickerNgayNhapKho, CBoxMaNV, CBoxMaKho);
            ctrlCTPhieuNhapKho.Luu_CTPhieuNhapKho(listView1);
            MessageBox.Show("Đã thêm thành công");
        }
    }
}