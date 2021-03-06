using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using QLThUOC.Controller;

namespace QLThUOC
{
    public partial class FormLapPhieuThanhLi : Form
    {
        LapPhieuThanhLiCTRL ctrlPhieuThanhLi = new LapPhieuThanhLiCTRL();
        CTPhieuThanhLiCTRL ctrlCTPhieuThanhLi = new CTPhieuThanhLiCTRL();
        public FormLapPhieuThanhLi()
        {
            InitializeComponent();
        }

        private void FormLapPhieuThanhLi_Load(object sender, EventArgs e)
        {
            ctrlPhieuThanhLi.HienThiListViewLapPhieuThanhLi(listView2);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listView2.SelectedItems.GetEnumerator();

            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                TBoxMaPhieuTL.Text = item.SubItems[1].Text;
                CBoxMaKho.Text = item.SubItems[2].Text;
                DateTimePickerNgayThanh.Text = item.SubItems[3].Text;
                CBoxMaNV.Text = item.SubItems[4].Text;
                ctrlCTPhieuThanhLi.HienThiListViewCTPhieuThanhLi(listView1, item.SubItems[1].Text);
                
            }
        }

        private void ButtonChon_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem((this.listView1.Items.Count + 1).ToString());
            li.SubItems.Add(this.TBoxCTMaPhieuTL.Text);
            li.SubItems.Add(this.CBoxMaThuoc.Text);
            
            this.listView1.Items.Add(li);
        }

        private void ItemLuu_Click(object sender, EventArgs e)
        {
            ctrlPhieuThanhLi.Luu_PhieuThanhLi(TBoxMaPhieuTL, CBoxMaKho, DateTimePickerNgayThanh, CBoxMaNV);
            ctrlCTPhieuThanhLi.Luu_CTPhieuThanhLi(listView1);
            MessageBox.Show("Đã thêm thành công");
        }

    }
}