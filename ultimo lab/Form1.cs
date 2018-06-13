using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ultimo_lab
{
    
    public partial class Form1 : Form
    {
        BaseDeDatos basededatos;
        public Form1()
        {
            InitializeComponent();
            panel_menu.Location = new Point(0,0);
            panel_peliculas.Location = new Point(0, 0);
            panel_actores.Location = new Point(0, 0);
            panel_directores.Location = new Point(0, 0);
            panel_productores.Location = new Point(0, 0);

            if (File.Exists("../../Serialize.bin"))
            {
                BinaryFormatter bin = new BinaryFormatter();
                Stream stream = new FileStream("../../Serialize.bin", FileMode.Open, FileAccess.Read);
                basededatos = new BaseDeDatos();
                basededatos = (BaseDeDatos)bin.Deserialize(stream);
                stream.Close();
            }
            else
            {
                basededatos = new BaseDeDatos();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel_bienvenida.Hide();
            panel_menu.Visible = true;
            timer_bienvenido.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            if(textBox1.TextLength > 3)
            {
                basededatos.SeleccionarTodo(textBox1.Text.ToString());
                listBox_search.Refresh();
                listBox_search.Items.Add(basededatos.SeleccionarTodo(textBox1.Text.ToString()));
            }
            

        }

        private void txtbox_click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }



        private void listBox_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
            Stream stream = new FileStream("../../Serialize.bin", FileMode.OpenOrCreate, FileAccess.Write);
            bin.Serialize(stream, basededatos);
            stream.Close();
            this.Close();
        }

        private void listBox_peliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_peliculas_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false; ;
            panel_peliculas.Visible = true;
            foreach(Pelicula pelicula in basededatos.peliculas)
            {
                listBox_peliculas.Items.Add(pelicula.nombre);
            }
        }

        private void peliculas_dobleclick(object sender, EventArgs e)
        {

        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = true;
            panel_peliculas.Visible = false;
            panel_actores.Visible = false;
            panel_directores.Visible = false;
            panel_productores.Visible = false;
        }

        private void button_actores_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false; ;
            panel_actores.Visible = true;
            foreach (Actor persona in basededatos.SeleccionarActores())
            {
                
                listBox_peliculas.Items.Add(persona.nombre);
                
            }
        }

        private void button_directores_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false; ;
            panel_directores.Visible = true;
            foreach (Director persona in basededatos.SeleccionarDirectores())
            {
                listBox_peliculas.Items.Add(persona.nombre);
            }
        }

        private void button_productores_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false; ;
            panel_productores.Visible = true;
            foreach (Productor persona in basededatos.SeleccionarProductores())
            {
                listBox_peliculas.Items.Add(persona.nombre);
            }
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
