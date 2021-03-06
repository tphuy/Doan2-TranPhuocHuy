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
    public partial class FormLapPhieuXuatKho : Form
    {
        LapPhieuXuatKhoCTRL ctrlPhieuXuatKho = new LapPhieuXuatKhoCTRL();
        CTPhieuXuatKhoCTRL ctrlCTPhieuXuatKho = new CTPhieuXuatKhoCTRL();
        public FormLapPhieuXuatKho()
        {
            InitializeComponent();
        }

         private void FormLapPhieuXuatKho_Load(object sender, EventArgs e)
        {
            ctrlPhieuXuatKho.HienThiListViewLapPhieuXuatKho(listView2);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listView2.SelectedItems.GetEnumerator();

            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                TBoxMaPhieuXK.Text = item.SubItems[1].Text;
                CBoxMaKH.Text = item.SubItems[2].Text;
                CBoxMaKho.Text = item.SubItems[3].Text;
                DateTimePickerNgayXuatKho.Text = item.SubItems[4].Text;
                CBoxMaNV.Text = item.SubItems[5].Text;             
                ctrlCTPhieuXuatKho.HienThiListViewCTPhieuXuatKho(listView1,item.SubItems[1].Text);
            }
        }

        private void ButtonChon_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem((this.listView1.Items.Count + 1).ToString());
            li.SubItems.Add(this.TBoxCTMaPhieuXK.Text);
            li.SubItems.Add(this.CBoxMaThuoc.Text);
            li.SubItems.Add(this.TextBoxSoLuong.Text);
          
            this.listView1.Items.Add(li);
        }

        private void ItemLuu_Click(object sender, EventArgs e)
        {
            ctrlPhieuXuatKho.Luu_PhieuXuatKho(TBoxMaPhieuXK, CBoxMaKH, CBoxMaKho, DateTimePickerNgayXuatKho, CBoxMaNV);
            ctrlCTPhieuXuatKho.Luu_CTPhieuXuatKho(listView1);
            MessageBox.Show("Đã thêm thành công");
        }
    }
}