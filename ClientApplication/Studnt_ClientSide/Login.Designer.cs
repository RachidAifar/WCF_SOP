
namespace Studnt_ClientSide
{
    partial class Login
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
            this.label_loginf = new System.Windows.Forms.Label();
            this.Lable_pass = new System.Windows.Forms.Label();
            this.tBox_name = new System.Windows.Forms.TextBox();
            this.tBoxpass = new System.Windows.Forms.TextBox();
            this.button_Loginn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_loginf
            // 
            this.label_loginf.AutoSize = true;
            this.label_loginf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginf.Location = new System.Drawing.Point(90, 68);
            this.label_loginf.Name = "label_loginf";
            this.label_loginf.Size = new System.Drawing.Size(51, 20);
            this.label_loginf.TabIndex = 0;
            this.label_loginf.Text = "Name";
            // 
            // Lable_pass
            // 
            this.Lable_pass.AutoSize = true;
            this.Lable_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_pass.Location = new System.Drawing.Point(59, 103);
            this.Lable_pass.Name = "Lable_pass";
            this.Lable_pass.Size = new System.Drawing.Size(78, 20);
            this.Lable_pass.TabIndex = 1;
            this.Lable_pass.Text = "Password";
            // 
            // tBox_name
            // 
            this.tBox_name.Location = new System.Drawing.Point(150, 68);
            this.tBox_name.Name = "tBox_name";
            this.tBox_name.Size = new System.Drawing.Size(100, 20);
            this.tBox_name.TabIndex = 2;
            // 
            // tBoxpass
            // 
            this.tBoxpass.Location = new System.Drawing.Point(150, 103);
            this.tBoxpass.Name = "tBoxpass";
            this.tBoxpass.Size = new System.Drawing.Size(100, 20);
            this.tBoxpass.TabIndex = 3;
            // 
            // button_Loginn
            // 
            this.button_Loginn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Loginn.Location = new System.Drawing.Point(146, 144);
            this.button_Loginn.Name = "button_Loginn";
            this.button_Loginn.Size = new System.Drawing.Size(104, 49);
            this.button_Loginn.TabIndex = 4;
            this.button_Loginn.Text = "Login";
            this.button_Loginn.UseVisualStyleBackColor = true;
            this.button_Loginn.Click += new System.EventHandler(this.button_Loginn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 259);
            this.Controls.Add(this.button_Loginn);
            this.Controls.Add(this.tBoxpass);
            this.Controls.Add(this.tBox_name);
            this.Controls.Add(this.Lable_pass);
            this.Controls.Add(this.label_loginf);
            this.Name = "Login";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_loginf;
        private System.Windows.Forms.Label Lable_pass;
        private System.Windows.Forms.Button button_Loginn;
        public System.Windows.Forms.TextBox tBoxpass;
        public System.Windows.Forms.TextBox tBox_name;
    }
}