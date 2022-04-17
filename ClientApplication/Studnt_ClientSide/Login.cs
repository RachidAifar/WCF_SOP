using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studnt_ClientSide
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tBoxpass.UseSystemPasswordChar = true;
        }

        private void button_Loginn_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
      
    }
}
