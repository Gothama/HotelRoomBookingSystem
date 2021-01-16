using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRoomBookingSystem
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
           
        }
        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "USERNAME" && txtPassword.Text == "1234")
            {
                 this.Hide();
                 Form2 main = new Form2();
                 main.Show();
            }
            else
            {
                txtPassword.Clear();
                txtUserName.Clear();
                MessageBox.Show("Pls Enter the correct password and username to enter");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
