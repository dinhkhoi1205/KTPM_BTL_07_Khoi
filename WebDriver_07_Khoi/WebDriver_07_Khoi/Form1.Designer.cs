using System;

namespace WebDriver_07_Khoi
{
    partial class Form_07_Khoi
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
            this.btnLogIn_07_Khoi = new System.Windows.Forms.Button();
            this.btnSignUpAccount_07_Khoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogIn_07_Khoi
            // 
            this.btnLogIn_07_Khoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn_07_Khoi.Location = new System.Drawing.Point(258, 102);
            this.btnLogIn_07_Khoi.Name = "btnLogIn_07_Khoi";
            this.btnLogIn_07_Khoi.Size = new System.Drawing.Size(274, 54);
            this.btnLogIn_07_Khoi.TabIndex = 0;
            this.btnLogIn_07_Khoi.Text = "Đăng nhập tài khoản";
            this.btnLogIn_07_Khoi.UseVisualStyleBackColor = true;
            this.btnLogIn_07_Khoi.Click += new System.EventHandler(this.btnLogIn_07_Khoi_Click);
            // 
            // btnSignUpAccount_07_Khoi
            // 
            this.btnSignUpAccount_07_Khoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUpAccount_07_Khoi.Location = new System.Drawing.Point(258, 221);
            this.btnSignUpAccount_07_Khoi.Name = "btnSignUpAccount_07_Khoi";
            this.btnSignUpAccount_07_Khoi.Size = new System.Drawing.Size(274, 49);
            this.btnSignUpAccount_07_Khoi.TabIndex = 1;
            this.btnSignUpAccount_07_Khoi.Text = "Đăng kí tài khoản";
            this.btnSignUpAccount_07_Khoi.UseVisualStyleBackColor = true;
            this.btnSignUpAccount_07_Khoi.Click += new System.EventHandler(this.btnSignUpAccount_07_Khoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kiểm thử chức năng trên Wikidepia";
            // 
            // Form_07_Khoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignUpAccount_07_Khoi);
            this.Controls.Add(this.btnLogIn_07_Khoi);
            this.Name = "Form_07_Khoi";
            this.Text = "07_Khoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnLogIn_07_Khoi;
        private System.Windows.Forms.Button btnSignUpAccount_07_Khoi;
        private System.Windows.Forms.Label label1;
    }
}

