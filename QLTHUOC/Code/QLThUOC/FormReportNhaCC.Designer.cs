namespace QLThUOC
{
    partial class FormReportNhaCC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonXem = new System.Windows.Forms.Button();
            //this.CrystalReportViewerNhaCungCap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Nhà Cung Cấp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonXem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 67);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            //this.panel2.Controls.Add(this.CrystalReportViewerNhaCungCap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 264);
            this.panel2.TabIndex = 1;
            // 
            // ButtonXem
            // 
            this.ButtonXem.Location = new System.Drawing.Point(67, 18);
            this.ButtonXem.Name = "ButtonXem";
            this.ButtonXem.Size = new System.Drawing.Size(316, 23);
            this.ButtonXem.TabIndex = 0;
            this.ButtonXem.Text = "Xem danh sách Nhà Cung Cấp";
            this.ButtonXem.UseVisualStyleBackColor = true;
            this.ButtonXem.Click += new System.EventHandler(this.ButtonXem_Click);
            // 
            // CrystalReportViewerNhaCungCap
            // 
            //this.CrystalReportViewerNhaCungCap.ActiveViewIndex = -1;
            //this.CrystalReportViewerNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //this.CrystalReportViewerNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.CrystalReportViewerNhaCungCap.Location = new System.Drawing.Point(0, 0);
            //this.CrystalReportViewerNhaCungCap.Name = "CrystalReportViewerNhaCungCap";
            //this.CrystalReportViewerNhaCungCap.SelectionFormula = "";
            //this.CrystalReportViewerNhaCungCap.Size = new System.Drawing.Size(432, 264);
            //this.CrystalReportViewerNhaCungCap.TabIndex = 0;
            //this.CrystalReportViewerNhaCungCap.ViewTimeSelectionFormula = "";
            // 
            // FormReportNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReportNhaCC";
            this.Text = "FormReportNhaCC";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonXem;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewerNhaCungCap;
    }
}