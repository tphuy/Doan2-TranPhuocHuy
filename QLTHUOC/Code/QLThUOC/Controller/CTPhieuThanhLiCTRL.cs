using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class CTPhieuThanhLiCTRL
    {
        CTPhieuThanhLiDATA data = new CTPhieuThanhLiDATA();
        public void HienThiListViewCTPhieuThanhLi(ListView lvw, String ctPhieuThanhLi)
        {
            lvw.Items.Clear();
            DataTable tbl = data.LayDSCTPhieuThanhLi(ctPhieuThanhLi);
            tbl.Clear();
            tbl = data.LayDSCTPhieuThanhLi(ctPhieuThanhLi);
            int n = 0;
            foreach (DataRow row in tbl.Rows)
            {
                ListViewItem item = new ListViewItem();
                n++;
                item.Text = n.ToString();
                item.SubItems.Add(row["MAPHIEUTL"].ToString());
                item.SubItems.Add(row["MATHUOC"].ToString());                               

                item.Tag = row;

                lvw.Items.Add(item);
            }


        }
        public void Luu_CTPhieuThanhLi(ListView list)
        {
            DataTable tb = data.LayDSCTPhieuThanhLi();
            for (int i = 0; i < list.Items.Count; i++)
            {
                ListViewItem li = list.Items[i];
                DataRow row = tb.NewRow();
                row[0] = li.SubItems[1].Text;
                row[1] = li.SubItems[2].Text;

                tb.Rows.Add(row);
            }
            data.Update();
        }
    }
}
