using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms1
{
    public partial class Form1 : Form
    {
        List<Trosak> listaTroskova = new List<Trosak>();

        public Form1()
        {
            InitializeComponent();

            List<string> listaKategorija = new List<string>();
            listaKategorija.Add("hrana");
            listaKategorija.Add("zabava");
            listaKategorija.Add("zdravlje");
            listaKategorija.Add("edukacija");

            comboBox1.DataSource = listaKategorija;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trosak t = new Trosak( float.Parse(textBox1.Text) , comboBox1.SelectedItem.ToString() );

            listaTroskova.Add(t);

            listBox1.DataSource = null; //ovo sam trebao dodat da mi se listbox updejta sa novim poljem
            listBox1.DataSource = listaTroskova;
        }
    }
}
