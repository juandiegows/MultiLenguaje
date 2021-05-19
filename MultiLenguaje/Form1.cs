using MultiLenguaje.Lenguajes;
using MultiLenguaje.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLenguaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Strings.mensaje);
        }

        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Idioma);
            /*lblLenguaje.Text = Strings.lblLenguaje;
            lblnuevo.Text = Strings.lblnuevo;
            ckActivo.Text = Strings.ckActivo;
            btnMensaje.Text = Strings.btnMensaje;
            this.Text = Strings.titulo;
            btnAplicar.Text = Strings.btnAplicar;*/
            Idioma.CambiarTexto(this.Controls);
            this.Text = Strings.titulo;

        }
        
       public void LlenarIdiomaCombobox()
        {
            comboBox1.DataSource = Idioma.ObtenerIdiomas();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "CultureInfo";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarIdioma();
            LlenarIdiomaCombobox();
        }

      
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Settings.Default.Idioma = comboBox1.SelectedValue.ToString();
            CargarIdioma();
        }
    }
}
