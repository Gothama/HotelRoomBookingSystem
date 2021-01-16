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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void RadioSingle_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 3;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 main = new Form2();
            main.Show();
        }

        private void RadioDouble_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 4;
        }

        private void RadioFamily_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 5;
        }
    }
}
