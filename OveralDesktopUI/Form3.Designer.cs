namespace Trang52
{
    partial class frmDemoListBoxs
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
            this.lbDanhsach = new System.Windows.Forms.ListBox();
            this.lblDanhsach = new System.Windows.Forms.Label();
            this.lblDanhSachChon = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbDanhsachChon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbDanhsach.FormattingEnabled = true;
            this.lbDanhsach.Items.AddRange(new object[] {
           "AP",
            "An ",
            "BC",
            "AX",
            "Ax",
            "Ok" });
            this.lbDanhsach.Location = new System.Drawing.Point(23, 28);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhsach.Size = new System.Drawing.Size(233, 186);
            this.lbDanhsach.TabIndex = 0;
            this.lbDanhsach.SelectedIndexChanged += new System.EventHandler(this.lbDanhsach_SelectedIndexChanged);
            // 
            // lblDanhsach
            // 
            this.lblDanhsach.AutoSize = true;
            this.lblDanhsach.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDanhsach.Location = new System.Drawing.Point(20, 9);
            this.lblDanhsach.Name = "lblDanhsach";
            this.lblDanhsach.Size = new System.Drawing.Size(121, 13);
            this.lblDanhsach.TabIndex = 2;
            this.lblDanhsach.Text = "Danh sách sinh viên lớp";
            this.lblDanhsach.Click += new System.EventHandler(this.lblDanhsach_Click);
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.AutoSize = true;
            this.lblDanhSachChon.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDanhSachChon.Location = new System.Drawing.Point(393, 9);
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(190, 13);
            this.lblDanhSachChon.TabIndex = 3;
            this.lblDanhSachChon.Text = "Danh sách sinh viên tham gia bóng đá";
            this.lblDanhSachChon.Click += new System.EventHandler(this.lblDanhSachChon_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Chọn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(294, 130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbDanhsachChon
            // 
            this.lbDanhsachChon.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbDanhsachChon.FormattingEnabled = true;
            this.lbDanhsachChon.Location = new System.Drawing.Point(396, 28);
            this.lbDanhsachChon.Name = "lbDanhsachChon";
            this.lbDanhsachChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhsachChon.Size = new System.Drawing.Size(233, 186);
            this.lbDanhsachChon.TabIndex = 6;
            this.lbDanhsachChon.SelectedIndexChanged += new System.EventHandler(this.lbDanhsachChon_SelectedIndexChanged);
            // 
            // frmDemoListBoxs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDanhsachChon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDanhSachChon);
            this.Controls.Add(this.lblDanhsach);
            this.Controls.Add(this.lbDanhsach);
            this.Name = "frmDemoListBoxs";
            this.Text = "Listboxs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhsach;
        private System.Windows.Forms.Label lblDanhsach;
        private System.Windows.Forms.Label lblDanhSachChon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lbDanhsachChon;
    }
}

