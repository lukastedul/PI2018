using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgraciTimovi
{
    public partial class Form1 : Form
    {
        List<Igrac> listaIgraca = new List<Igrac>();
        BindingSource igraciBS = new BindingSource();

        List<Tim> listaTimova = new List<Tim>();
        BindingSource timoviBS = new BindingSource();


        public Form1()
        {
            InitializeComponent();

            igraciBS.DataSource = listaIgraca;
            outputIgraci.DataSource = igraciBS;

            timoviBS.DataSource = listaTimova;
            outputTimovi.DataSource = timoviBS;
        }

        private void actionNoviIgrac_Click(object sender, EventArgs e)
        {
            Igrac i = new Igrac(inputIgrac.Text);
            listaIgraca.Add(i);

            inputIgrac.Clear();
            igraciBS.ResetBindings(false);
        }

        private void actionNoviTim_Click(object sender, EventArgs e)
        {
            Tim t = new Tim(inputTim.Text);
            listaTimova.Add(t);

            inputTim.Clear();
            timoviBS.ResetBindings(false);
        }

        private void actionIgracUTim_Click(object sender, EventArgs e)
        {
            Tim odabraniTim = (Tim)outputTimovi.SelectedItem;
            Igrac odabraniIgrac = (Igrac)outputIgraci.SelectedItem;

            if (odabraniTim.DodajIgraca(odabraniIgrac)) //dodavanje igraca u tim
            {
                MessageBox.Show("Ne smije biti više od 11 igrača u timu!");
            }

            listaIgraca.Remove(odabraniIgrac); //brisanje tog igraca iz liste svih igraca

            igraciBS.ResetBindings(false); // refresh igraci listboxa

            osvjeziTimove(); //refresh igraciUTimu listboxa
        }

        public void osvjeziTimove()
        {
            Tim odabraniTim = (Tim)outputTimovi.SelectedItem;

            outputIgraciUTimu.DataSource = null;
            outputIgraciUTimu.DataSource = odabraniTim.listaIgracaUTimu;
        }

        private void outputTimovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            osvjeziTimove();
        }

        private void actionIgracVan_Click(object sender, EventArgs e)
        {
            Tim odabraniTim = (Tim)outputTimovi.SelectedItem;
            Igrac odabraniIgrac = (Igrac)outputIgraciUTimu.SelectedItem;

            odabraniTim.IzbrisiIgraca(odabraniIgrac); //brisanje igraca iz tima
            listaIgraca.Add(odabraniIgrac); //dodavanje natrag u listu svih igraca

            osvjeziTimove(); //refresh igraciUTimu listboxa
            igraciBS.ResetBindings(false); // refresh igraci listboxa
        }

        //ovo je samo da mogu stisnut enter kod dodavanja nogog igraca, umjesto da klikam button za dodavanje
        private void inputIgrac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actionNoviIgrac_Click(this, new EventArgs());
            }
        }

        //ista stvar samo za timove
        private void inputTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                actionNoviTim_Click(this, new EventArgs());
            }
        }
    }
}
