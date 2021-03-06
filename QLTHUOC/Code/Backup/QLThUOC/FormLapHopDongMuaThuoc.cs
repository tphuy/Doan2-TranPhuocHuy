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
    public partial class FormLapHopDongMuaThuoc : Form
    {
        LapHopDongMuaThuocCTRL ctrlHDMT = new LapHopDongMuaThuocCTRL();
        CTHopDongMuaThuocCTRL ctrlCTHDMT = new CTHopDongMuaThuocCTRL();
        public FormLapHopDongMuaThuoc()
        {
            InitializeComponent();
        }

        private void FormLapHopDongMuaThuoc_Load(object sender, EventArgs e)
        {
            ctrlHDMT.HienThiListViewLapHopDong(listView2);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            IEnumerator ie = listView2.SelectedItems.GetEnumerator();

            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;


                TBoxMaHD.Text = item.SubItems[1].Text;
                DateTimePickerNgayLap.Text = item.SubItems[2].Text;
                DateTimePickerNgayNhan.Text = item.SubItems[3].Text;
                TBoxNoiNhan.Text = item.SubItems[4].Text;
                TBoxTongTien.Text = item.SubItems[5].Text;
                TBoxSoLanGiao.Text = item.SubItems[6].Text;
                CBoxMaNCC.Text = item.SubItems[7].Text;
                CBoxMaNV.Text = item.SubItems[8].Text;
                ctrlCTHDMT.HienThiListViewCTHopDong(listView1, item.SubItems[1].Text);
            }
        }

        private void ItemLuu_Click(object sender, EventArgs e)
        {
            ctrlHDMT.Luu_HDMT(TBoxMaHD, DateTimePickerNgayLap, DateTimePickerNgayNhan, TBoxNoiNhan, TBoxTongTien, TBoxSoLanGiao, CBoxMaNCC, CBoxMaNV);
            ctrlCTHDMT.Luu_CTHDMT(listView1);
            MessageBox.Show("Đã thêm thành công");
        }

        private void ButtonChon_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem((this.listView1.Items.Count + 1).ToString());
            li.SubItems.Add(this.TBoxCTMaHD.Text);
            li.SubItems.Add(this.CBoxMaThuoc.Text);
            li.SubItems.Add(this.TBoxSoLuong.Text);
            li.SubItems.Add(this.TBoxDonGia.Text);
            li.SubItems.Add(this.TBoxThanhTien.Text);
            this.listView1.Items.Add(li);
            
        }

     
    }
}