using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLThUOC.Controller;
using QLThUOC.DataLayer;

namespace QLThUOC
{
    public partial class FormLapPhieuNhanHang : Form
    {
        LapPhieuNhanHangCTRL ctrlPhieuNhanHang = new LapPhieuNhanHangCTRL();
        CTPhieuNhanHangCTRL ctrlCTPhieuNhanHang = new CTPhieuNhanHangCTRL();
        public FormLapPhieuNhanHang()
        {
            InitializeComponent();
        }

        private void FormLapPhieuNhanHang_Load(object sender, EventArgs e)
        {
            ctrlPhieuNhanHang.HienThiListViewLapPhieuNhanHang(listView2);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listView2.SelectedItems.GetEnumerator();

            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                TBoxMaPhieuNH.Text = item.SubItems[1].Text;
                CBoxMaHopDong.Text = item.SubItems[2].Text;
                DateTimePickerNgayGiao.Text = item.SubItems[3].Text;
                TBoxTongTien.Text = item.SubItems[4].Text;
                CBoxMaNV.Text = item.SubItems[5].Text;
                ctrlCTPhieuNhanHang.HienThiListViewCTPhieuNhanHang(listView1, item.SubItems[1].Text);
            }
        }

        private void ButtonChon_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem((this.listView1.Items.Count + 1).ToString());
            li.SubItems.Add(this.TBoxCTMaPhieuNH.Text);
            li.SubItems.Add(this.CBoxMaThuoc.Text);
            li.SubItems.Add(this.TextBoxSoluong.Text);
            li.SubItems.Add(this.TextBoxDonGia.Text);
            li.SubItems.Add(this.TextBoxThanhTien.Text);
           
            this.listView1.Items.Add(li);
        }

        private void ItemLuu_Click(object sender, EventArgs e)
        {
            ctrlPhieuNhanHang.Luu_PhieuNhanHang(TBoxMaPhieuNH, CBoxMaHopDong, DateTimePickerNgayGiao, TBoxTongTien, CBoxMaNV);
            ctrlCTPhieuNhanHang.Luu_CTPhieuNhanHang(listView1);
            MessageBox.Show("Đã thêm thành công");
        }

        private void ButtonHuyBo_Click(object sender, EventArgs e)
        {

        }
       
        

    }
}