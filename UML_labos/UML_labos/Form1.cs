using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_labos
{
    public partial class Form1 : Form
    {
        List<Item> listOfItems = new List<Item>();
        List<Item> listBill = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void actionAdd_Click(object sender, EventArgs e)
        {
            outputItems.DataSource = null;
            

            Item i = new Item( inputName.Text , float.Parse(inputPrice.Text) , int.Parse(inputQuantity.Text) );
            listOfItems.Add(i);

            inputName.Clear();
            inputPrice.Clear();
            inputQuantity.Clear();

            outputItems.DataSource = listOfItems;
        }

        private void actionAddToBill_Click(object sender, EventArgs e)
        {
            //var itemToAdd = outputItems.SelectedIndex;
            listBill.Add((outputItems.SelectedIndexq));
            //outputBill.Text = 
        }
    }
}
