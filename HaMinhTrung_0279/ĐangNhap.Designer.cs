namespace HaMinhTrung_0279
{
    partial class ĐangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btLOGIN = new System.Windows.Forms.Button();
            this.btOUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(201, 56);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(293, 30);
            this.txtTK.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(201, 121);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(293, 30);
            this.txtMK.TabIndex = 3;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // btLOGIN
            // 
            this.btLOGIN.BackColor = System.Drawing.Color.IndianRed;
            this.btLOGIN.Location = new System.Drawing.Point(201, 194);
            this.btLOGIN.Name = "btLOGIN";
            this.btLOGIN.Size = new System.Drawing.Size(112, 62);
            this.btLOGIN.TabIndex = 4;
            this.btLOGIN.Text = "Đăng Nhập";
            this.btLOGIN.UseVisualStyleBackColor = false;
            this.btLOGIN.Click += new System.EventHandler(this.btLOGIN_Click);
            // 
            // btOUT
            // 
            this.btOUT.BackColor = System.Drawing.Color.RosyBrown;
            this.btOUT.Location = new System.Drawing.Point(382, 194);
            this.btOUT.Name = "btOUT";
            this.btOUT.Size = new System.Drawing.Size(112, 62);
            this.btOUT.TabIndex = 5;
            this.btOUT.Text = "Thoát";
            this.btOUT.UseVisualStyleBackColor = false;
            this.btOUT.Click += new System.EventHandler(this.btOUT_Click);
            // 
            // ĐangNhap
            // 
            this.AcceptButton = this.btLOGIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 331);
            this.Controls.Add(this.btOUT);
            this.Controls.Add(this.btLOGIN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ĐangNhap";
            this.Text = "ĐangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btLOGIN;
        private System.Windows.Forms.Button btOUT;
    }
}