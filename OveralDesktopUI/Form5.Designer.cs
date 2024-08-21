namespace Trang57
{
    partial class Form1
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnButtonFlat = new System.Windows.Forms.Button();
            this.rbPopup = new System.Windows.Forms.RadioButton();
            this.rbFlat = new System.Windows.Forms.RadioButton();
            this.ckbMauNen = new System.Windows.Forms.CheckBox();
            this.ckbMauChu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.ForeColor = System.Drawing.Color.Black;
            this.btnButton.Location = new System.Drawing.Point(41, 49);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(87, 23);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnButtonFlat
            // 
            this.btnButtonFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButtonFlat.Location = new System.Drawing.Point(41, 142);
            this.btnButtonFlat.Name = "btnButtonFlat";
            this.btnButtonFlat.Size = new System.Drawing.Size(87, 23);
            this.btnButtonFlat.TabIndex = 1;
            this.btnButtonFlat.Text = "Button Flat";
            this.btnButtonFlat.UseVisualStyleBackColor = true;
            this.btnButtonFlat.Click += new System.EventHandler(this.btnButtonFlat_Click);
            // 
            // rbPopup
            // 
            this.rbPopup.AutoSize = true;
            this.rbPopup.Location = new System.Drawing.Point(174, 155);
            this.rbPopup.Name = "rbPopup";
            this.rbPopup.Size = new System.Drawing.Size(80, 17);
            this.rbPopup.TabIndex = 2;
            this.rbPopup.TabStop = true;
            this.rbPopup.Text = "Kiểu Popup";
            this.rbPopup.UseVisualStyleBackColor = true;
            this.rbPopup.CheckedChanged += new System.EventHandler(this.rbPopup_CheckedChanged);
            // 
            // rbFlat
            // 
            this.rbFlat.AutoSize = true;
            this.rbFlat.Location = new System.Drawing.Point(174, 122);
            this.rbFlat.Name = "rbFlat";
            this.rbFlat.Size = new System.Drawing.Size(66, 17);
            this.rbFlat.TabIndex = 3;
            this.rbFlat.TabStop = true;
            this.rbFlat.Text = "Kiểu Flat";
            this.rbFlat.UseVisualStyleBackColor = true;
            this.rbFlat.CheckedChanged += new System.EventHandler(this.rbFlat_CheckedChanged);
            // 
            // ckbMauNen
            // 
            this.ckbMauNen.AutoSize = true;
            this.ckbMauNen.Location = new System.Drawing.Point(174, 55);
            this.ckbMauNen.Name = "ckbMauNen";
            this.ckbMauNen.Size = new System.Drawing.Size(112, 17);
            this.ckbMauNen.TabIndex = 4;
            this.ckbMauNen.Text = "Thay đổi màu nền";
            this.ckbMauNen.UseVisualStyleBackColor = true;
            this.ckbMauNen.CheckedChanged += new System.EventHandler(this.ckbMauNen_CheckedChanged);
            // 
            // ckbMauChu
            // 
            this.ckbMauChu.AutoSize = true;
            this.ckbMauChu.Location = new System.Drawing.Point(174, 32);
            this.ckbMauChu.Name = "ckbMauChu";
            this.ckbMauChu.Size = new System.Drawing.Size(112, 17);
            this.ckbMauChu.TabIndex = 5;
            this.ckbMauChu.Text = "Thay đổi màu chữ";
            this.ckbMauChu.UseVisualStyleBackColor = true;
            this.ckbMauChu.CheckedChanged += new System.EventHandler(this.ckbMauChu_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbMauChu);
            this.Controls.Add(this.ckbMauNen);
            this.Controls.Add(this.rbFlat);
            this.Controls.Add(this.rbPopup);
            this.Controls.Add(this.btnButtonFlat);
            this.Controls.Add(this.btnButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnButtonFlat;
        private System.Windows.Forms.RadioButton rbPopup;
        private System.Windows.Forms.RadioButton rbFlat;
        private System.Windows.Forms.CheckBox ckbMauNen;
        private System.Windows.Forms.CheckBox ckbMauChu;
    }
}

