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
    public partial class FormLapPhieuDatHang : Form
    {
        LapPhieuDatHangCTRL ctrlPhieuDatHang = new LapPhieuDatHangCTRL();
        CTPhieuDatHangCTRL ctrlCTPhieuDatHang = new CTPhieuDatHangCTRL();
        public FormLapPhieuDatHang()
        {
            InitializeComponent();
        }

        private void FormLapPhieuDatHang_Load(object sender, EventArgs e)
        {
            ctrlPhieuDatHang.HienThiListViewLapPhieuDatHang(listView2);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listView2.SelectedItems.GetEnumerator();

            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                TBoxMaPhieuDH.Text = item.SubItems[1].Text;
                CBoxMaKH.Text = item.SubItems[2].Text;
                CBoxMaHT.Text = item.SubItems[3].Text;
                DateTimePickerNgayGiao.Text = item.SubItems[4].Text;
                TBoxNoiGiao.Text = item.SubItems[5].Text;
                DateTimePickerNgayLap.Text = item.SubItems[6].Text;
                TBoxTongTien.Text = item.SubItems[7].Text;
                CBoxMaNV.Text = item.SubItems[8].Text;
                ctrlCTPhieuDatHang.HienThiListViewCTPhieuDatHang(listView1, item.SubItems[1].Text);
             
            }
        }

        private void ButtonChon_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem((this.listView1.Items.Count + 1).ToString());
            li.SubItems.Add(this.TBoxCTMaPhieuDH.Text);
            li.SubItems.Add(this.CBoxMaThuoc.Text);
            li.SubItems.Add(this.TBoxSoLuong.Text);
            
            this.listView1.Items.Add(li);
        }

        private void ItemLuu_Click(object sender, EventArgs e)
        {
            ctrlPhieuDatHang.Luu_PhieuDatHang(TBoxMaPhieuDH, CBoxMaKH, CBoxMaHT, DateTimePickerNgayGiao, TBoxNoiGiao, DateTimePickerNgayLap, TBoxTongTien, CBoxMaNV);
            ctrlCTPhieuDatHang.Luu_CTPhieuDatHang(listView1);
            MessageBox.Show("Đã thêm thành công");
        }
    }
}