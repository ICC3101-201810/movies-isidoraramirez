using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ultimo_lab
{
    
    public partial class Form1 : Form
    {
        public BaseDeDatos basededatos = new BaseDeDatos();
        
        public Form1()
        {
            InitializeComponent();
            panel_menu.Location = new Point(0,0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_bienvenida.Hide();
            panel_menu.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;

        }

        private void txtbox_click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = "🔎 Search...";
            }
        }

        private void listBox_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
