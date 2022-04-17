
namespace Studnt_ClientSide
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
            this.btn_getStudent = new System.Windows.Forms.Button();
            this.label_Home_TITLE = new System.Windows.Forms.Label();
            this.Label_Addgarde = new System.Windows.Forms.Label();
            this.Label_S_Codemasar = new System.Windows.Forms.Label();
            this.textBox_CodeMasar = new System.Windows.Forms.TextBox();
            this.b_submit = new System.Windows.Forms.Button();
            this.textBox_Grade = new System.Windows.Forms.TextBox();
            this.textBox_Major = new System.Windows.Forms.TextBox();
            this.textBox_Lastname = new System.Windows.Forms.TextBox();
            this.textBox_Firstname = new System.Windows.Forms.TextBox();
            this.Label_S_Grade = new System.Windows.Forms.Label();
            this.Label_S_Major = new System.Windows.Forms.Label();
            this.Label_S_L_Name = new System.Windows.Forms.Label();
            this.Label_S_F_Name = new System.Windows.Forms.Label();
            this.lable_S_Id = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_teacherName = new System.Windows.Forms.Label();
            this.button_Delet = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_list = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_getStudent
            // 
            this.btn_getStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getStudent.Location = new System.Drawing.Point(253, 317);
            this.btn_getStudent.Name = "btn_getStudent";
            this.btn_getStudent.Size = new System.Drawing.Size(91, 35);
            this.btn_getStudent.TabIndex = 71;
            this.btn_getStudent.Text = "GetStudent";
            this.btn_getStudent.UseVisualStyleBackColor = true;
            this.btn_getStudent.Click += new System.EventHandler(this.btn_getStudent_Click);
            // 
            // label_Home_TITLE
            // 
            this.label_Home_TITLE.AutoSize = true;
            this.label_Home_TITLE.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Home_TITLE.ForeColor = System.Drawing.Color.OldLace;
            this.label_Home_TITLE.Location = new System.Drawing.Point(275, 9);
            this.label_Home_TITLE.Name = "label_Home_TITLE";
            this.label_Home_TITLE.Size = new System.Drawing.Size(170, 21);
            this.label_Home_TITLE.TabIndex = 68;
            this.label_Home_TITLE.Text = "Welcom In MasarGrade";
            // 
            // Label_Addgarde
            // 
            this.Label_Addgarde.AutoSize = true;
            this.Label_Addgarde.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Addgarde.Location = new System.Drawing.Point(274, 93);
            this.Label_Addgarde.Name = "Label_Addgarde";
            this.Label_Addgarde.Size = new System.Drawing.Size(161, 19);
            this.Label_Addgarde.TabIndex = 64;
            this.Label_Addgarde.Text = "Add grade to the student";
            // 
            // Label_S_Codemasar
            // 
            this.Label_S_Codemasar.AutoSize = true;
            this.Label_S_Codemasar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_S_Codemasar.Location = new System.Drawing.Point(163, 158);
            this.Label_S_Codemasar.Name = "Label_S_Codemasar";
            this.Label_S_Codemasar.Size = new System.Drawing.Size(84, 17);
            this.Label_S_Codemasar.TabIndex = 63;
            this.Label_S_Codemasar.Text = "Code masar";
            // 
            // textBox_CodeMasar
            // 
            this.textBox_CodeMasar.Location = new System.Drawing.Point(253, 158);
            this.textBox_CodeMasar.Name = "textBox_CodeMasar";
            this.textBox_CodeMasar.Size = new System.Drawing.Size(218, 20);
            this.textBox_CodeMasar.TabIndex = 62;
            // 
            // b_submit
            // 
            this.b_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_submit.Location = new System.Drawing.Point(383, 316);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(88, 35);
            this.b_submit.TabIndex = 59;
            this.b_submit.Text = "submit";
            this.b_submit.UseVisualStyleBackColor = true;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // textBox_Grade
            // 
            this.textBox_Grade.Location = new System.Drawing.Point(253, 280);
            this.textBox_Grade.Name = "textBox_Grade";
            this.textBox_Grade.Size = new System.Drawing.Size(218, 20);
            this.textBox_Grade.TabIndex = 58;
            // 
            // textBox_Major
            // 
            this.textBox_Major.Location = new System.Drawing.Point(253, 247);
            this.textBox_Major.Name = "textBox_Major";
            this.textBox_Major.Size = new System.Drawing.Size(218, 20);
            this.textBox_Major.TabIndex = 57;
            // 
            // textBox_Lastname
            // 
            this.textBox_Lastname.Location = new System.Drawing.Point(253, 216);
            this.textBox_Lastname.Name = "textBox_Lastname";
            this.textBox_Lastname.Size = new System.Drawing.Size(218, 20);
            this.textBox_Lastname.TabIndex = 56;
            // 
            // textBox_Firstname
            // 
            this.textBox_Firstname.Location = new System.Drawing.Point(253, 184);
            this.textBox_Firstname.Name = "textBox_Firstname";
            this.textBox_Firstname.Size = new System.Drawing.Size(218, 20);
            this.textBox_Firstname.TabIndex = 55;
            // 
            // Label_S_Grade
            // 
            this.Label_S_Grade.AutoSize = true;
            this.Label_S_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_S_Grade.Location = new System.Drawing.Point(163, 281);
            this.Label_S_Grade.Name = "Label_S_Grade";
            this.Label_S_Grade.Size = new System.Drawing.Size(48, 17);
            this.Label_S_Grade.TabIndex = 54;
            this.Label_S_Grade.Text = "Grade";
            // 
            // Label_S_Major
            // 
            this.Label_S_Major.AutoSize = true;
            this.Label_S_Major.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_S_Major.Location = new System.Drawing.Point(163, 247);
            this.Label_S_Major.Name = "Label_S_Major";
            this.Label_S_Major.Size = new System.Drawing.Size(43, 17);
            this.Label_S_Major.TabIndex = 53;
            this.Label_S_Major.Text = "Major";
            // 
            // Label_S_L_Name
            // 
            this.Label_S_L_Name.AutoSize = true;
            this.Label_S_L_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_S_L_Name.Location = new System.Drawing.Point(163, 216);
            this.Label_S_L_Name.Name = "Label_S_L_Name";
            this.Label_S_L_Name.Size = new System.Drawing.Size(76, 17);
            this.Label_S_L_Name.TabIndex = 52;
            this.Label_S_L_Name.Text = "Last Name";
            // 
            // Label_S_F_Name
            // 
            this.Label_S_F_Name.AutoSize = true;
            this.Label_S_F_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_S_F_Name.Location = new System.Drawing.Point(163, 184);
            this.Label_S_F_Name.Name = "Label_S_F_Name";
            this.Label_S_F_Name.Size = new System.Drawing.Size(76, 17);
            this.Label_S_F_Name.TabIndex = 51;
            this.Label_S_F_Name.Text = "First Name";
            // 
            // lable_S_Id
            // 
            this.lable_S_Id.AutoSize = true;
            this.lable_S_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_S_Id.Location = new System.Drawing.Point(163, 132);
            this.lable_S_Id.Name = "lable_S_Id";
            this.lable_S_Id.Size = new System.Drawing.Size(72, 17);
            this.lable_S_Id.TabIndex = 50;
            this.lable_S_Id.Text = "Student Id";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(253, 129);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(218, 20);
            this.textBox_Id.TabIndex = 49;
            // 
            // button_Login
            // 
            this.button_Login.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(550, 358);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(238, 80);
            this.button_Login.TabIndex = 72;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_teacherName
            // 
            this.label_teacherName.AutoSize = true;
            this.label_teacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teacherName.Location = new System.Drawing.Point(72, 71);
            this.label_teacherName.Name = "label_teacherName";
            this.label_teacherName.Size = new System.Drawing.Size(0, 20);
            this.label_teacherName.TabIndex = 73;
            // 
            // button_Delet
            // 
            this.button_Delet.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delet.Location = new System.Drawing.Point(253, 358);
            this.button_Delet.Name = "button_Delet";
            this.button_Delet.Size = new System.Drawing.Size(218, 31);
            this.button_Delet.TabIndex = 76;
            this.button_Delet.Text = "Delete";
            this.button_Delet.UseVisualStyleBackColor = true;
            this.button_Delet.Click += new System.EventHandler(this.button_Delet_Click);
            // 
            // button_logout
            // 
            this.button_logout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.Location = new System.Drawing.Point(12, 358);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(164, 80);
            this.button_logout.TabIndex = 77;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_list
            // 
            this.button_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_list.Location = new System.Drawing.Point(253, 395);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(218, 43);
            this.button_list.TabIndex = 78;
            this.button_list.Text = "List Students";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(550, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(238, 258);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_list);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_Delet);
            this.Controls.Add(this.label_teacherName);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.btn_getStudent);
            this.Controls.Add(this.label_Home_TITLE);
            this.Controls.Add(this.Label_Addgarde);
            this.Controls.Add(this.Label_S_Codemasar);
            this.Controls.Add(this.textBox_CodeMasar);
            this.Controls.Add(this.b_submit);
            this.Controls.Add(this.textBox_Grade);
            this.Controls.Add(this.textBox_Major);
            this.Controls.Add(this.textBox_Lastname);
            this.Controls.Add(this.textBox_Firstname);
            this.Controls.Add(this.Label_S_Grade);
            this.Controls.Add(this.Label_S_Major);
            this.Controls.Add(this.Label_S_L_Name);
            this.Controls.Add(this.Label_S_F_Name);
            this.Controls.Add(this.lable_S_Id);
            this.Controls.Add(this.textBox_Id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getStudent;
        private System.Windows.Forms.Label label_Home_TITLE;
        private System.Windows.Forms.Label Label_Addgarde;
        private System.Windows.Forms.Label Label_S_Codemasar;
        private System.Windows.Forms.TextBox textBox_CodeMasar;
        private System.Windows.Forms.Button b_submit;
        private System.Windows.Forms.TextBox textBox_Grade;
        private System.Windows.Forms.TextBox textBox_Major;
        private System.Windows.Forms.TextBox textBox_Lastname;
        private System.Windows.Forms.TextBox textBox_Firstname;
        private System.Windows.Forms.Label Label_S_Grade;
        private System.Windows.Forms.Label Label_S_Major;
        private System.Windows.Forms.Label Label_S_L_Name;
        private System.Windows.Forms.Label Label_S_F_Name;
        private System.Windows.Forms.Label lable_S_Id;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_teacherName;
        private System.Windows.Forms.Button button_Delet;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

