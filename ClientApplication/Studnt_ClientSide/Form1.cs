using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Forms;
using Studnt_ClientSide.ServiceStudent;

namespace Studnt_ClientSide
{
    public partial class Form1 : Form
    {
        List<Students> students;
        private Teachers _teacher;
        public Form1()
        {
            InitializeComponent();
           
            button_Login.Enabled = true;
            DataGrideview();
            UpdateDataGrideview();
           
        }
        void DataGrideview()
        {
            try
            {
                if (_teacher == null)
                {
                    dataGridView1.Hide();
                }


                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Add("textBox_Id", "Student Id");
                dataGridView1.Columns["textBox_Id"].Width = 30;

                dataGridView1.Columns.Add("textBox_Firstname", "First Name");
                dataGridView1.Columns["textBox_Firstname"].Width = 70;

                dataGridView1.Columns.Add("textBox_Lastname", "Last Name");
                dataGridView1.Columns["textBox_Lastname"].Width = 60;

                dataGridView1.Columns.Add("textBox_Grade", "Grade");
                dataGridView1.Columns["textBox_Grade"].Width = 40;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void UpdateDataGrideview()
        {
           dataGridView1.Rows.Clear();
           Service1Client client = new Service1Client();
           try
           {
             
                    List<Students> students;
                     students = client.List().ToList();
                    foreach (Students item in students)
                    {
                        string[] row = new string[]
                        {
                           item.Id.ToString(),
                           item.First_name.ToString(),
                           item.Last_name.ToString(),
                           item.Grade.ToString()
                        };
                        dataGridView1.Rows.Add(row);
                    }
              
           }
            catch (FaultException<SqlConnectionFailed> Fex)
           {
                MessageBox.Show(Fex.Message);
           }
        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            if(_teacher != null)
            {
                try
                {
                   
                    button_Delet.Enabled = false;
                    button_list.Enabled = false;
                    btn_getStudent.Enabled = false;
                    ServiceStudent.Service1Client client = new ServiceStudent.Service1Client();
                    ServiceStudent.Students student = new ServiceStudent.Students();
                    student.Id = Convert.ToInt32(textBox_Id.Text);
                    student.Codemasar = textBox_CodeMasar.Text;
                    student.First_name = textBox_Firstname.Text;
                    student.Last_name = textBox_Lastname.Text;
                    student.Major = textBox_Major.Text;
                    student.Grade = Convert.ToInt32(textBox_Grade.Text);
                    if (int.Parse(textBox_Grade.Text) > 5 || int.Parse(textBox_Grade.Text) < 0)
                        throw new Exception("The grade must be auther 1,2,3,4 or 5");
                   
                        client.Addgrades(student);


                    // MessageBox.Show("you submet succifully Student: "+ textBox_Firstname.Text);
                }
                catch (EndpointNotFoundException)
                {
                    MessageBox.Show("Problem with the server!");
                }
                catch (FaultException<ArgumentFault>)
                {
                    MessageBox.Show("Wrong or missing parameter/parameters!");
                }
                catch (FaultException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException)
                {
                    MessageBox.Show("The format of an argument/arguments is invalid!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("You need to login first!");

        }

        private void btn_getStudent_Click(object sender, EventArgs e)
        {
            if(_teacher != null)
            { 
                try
                {

                    btn_getStudent.Enabled = false;
                    button_Delet.Enabled = false;
                    button_list.Enabled = false;
                    b_submit.Enabled = false;
                    textBox_Firstname.Enabled=false;
                    textBox_Firstname.Enabled = false;
                    textBox_CodeMasar.Enabled = false;
                    textBox_Firstname.Enabled = false;
                    textBox_Lastname.Enabled = false;
                    textBox_Major.Enabled = false;
                    textBox_Grade.Enabled = false;
                    ServiceStudent.Service1Client client = new ServiceStudent.Service1Client();
                    ServiceStudent.Students student = client.GetStudent(Convert.ToInt32(textBox_Id.Text));
                    textBox_CodeMasar.Text = student.Codemasar;
                    textBox_Firstname.Text = student.First_name;
                    textBox_Lastname.Text = student.Last_name;
                    textBox_Major.Text = student.Major;
                    textBox_Grade.Text = Convert.ToInt32(student.Grade).ToString();

                  //  MessageBox.Show("You Get Student" + textBox_Firstname.Text);
                  
                    
                }
                catch (EndpointNotFoundException)
                {
                   MessageBox.Show("Problem with the server!");
                }
                catch (FaultException<SqlConnectionFailed>)
                {
                    MessageBox.Show("You have problem in your prameter this student it is not exicet in our system please check the list of student");
                }
                catch (FaultException<ArgumentFault>)
                {
                     MessageBox.Show("Wrong or missing parameter/parameters!");
                }
              
                catch (FaultException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException)
                {
                    MessageBox.Show("The format of an argument/arguments is invalid!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("You need to login first!");

        }
           
      

        private void button_Login_Click(object sender, EventArgs e)
        {
            var Login = new Login();
            Login.ShowDialog();
            if(Login.tBox_name.Text!="" && Login.tBoxpass.Text != "")
            {

               try
               {
                    button_Login.Enabled = false;
                    ServiceStudent.Service1Client client = new Service1Client();
                     this._teacher = client.Login(Login.tBox_name.Text, Login.tBoxpass.Text);
                    textBox_Id.Text = String.Empty;
                    textBox_CodeMasar.Text = String.Empty;
                    textBox_Firstname.Text = String.Empty;
                    textBox_Lastname.Text = String.Empty;
                    textBox_Major.Text = String.Empty;
                    textBox_Grade.Text = String.Empty;








                }
               catch (FaultException<UnsuccessfullLoginFault>)
               {
                   MessageBox.Show("Unsuccessful login!");
               }
               catch (Exception ex)
               {
                    button_Login.Enabled = true;
                    MessageBox.Show(ex.Message);
               }
            }
            else
            {
                MessageBox.Show("Please Enter your name and password");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button_logout_Click(object sender, EventArgs e)
        {
            button_Login.Enabled = true;
            button_Delet.Enabled = true;
            button_list.Enabled = true;
            b_submit.Enabled = true;
            btn_getStudent.Enabled = true;
            button_Login.Enabled = true;
        }

        private void button_Delet_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_Firstname.Enabled = false;
                textBox_Firstname.Enabled = false;
                textBox_CodeMasar.Enabled = false;
                textBox_Firstname.Enabled = false;
                textBox_Lastname.Enabled = false;
                textBox_Major.Enabled = false;
                textBox_Grade.Enabled = false;
                ServiceStudent.Service1Client client = new ServiceStudent.Service1Client();
                ServiceStudent.Students student = client.Delete(Convert.ToInt32(textBox_Id.Text));
                textBox_CodeMasar.Text = student.Codemasar;
                textBox_Firstname.Text = student.First_name;
                textBox_Lastname.Text = student.Last_name;
                textBox_Major.Text = student.Major;
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //  textBox_Grade.Text = Convert.ToInt32(student.Grade).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            try
            {
                if (_teacher != null)
                {
                    dataGridView1.Show();
                }
                else
                    MessageBox.Show("please Login first");
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
