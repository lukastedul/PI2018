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
        BindingList<Item> listOfItems = new BindingList<Item>();
        BindingList<BillItem> listBill = new BindingList<BillItem>();
        //BindingList<Item> listBill = new BindingList<Item>();

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
            /*
            int index = outputItems.SelectedIndex;
            listBill.Add(listOfItems[index]);

            float ukupnaCijena = 0;
            foreach (Item i in listOfItems)
            {
                ukupnaCijena += i.Price;
                outputBill.Text += i.ToString();
            }
            outputBill.Text += "pa jebote kaj je ovo?";
            */

            int counter = 0;
            bool start = false;

            outputBill.DataSource = null;

            int index = outputItems.SelectedIndex;

            if (listBill.Count == 0)
            {
                BillItem ni = new BillItem(listOfItems[index].Name, listOfItems[index].Price, listOfItems[index].Quantity);
                listBill.Add(ni);
                start = true;
            }
            else
            {
                foreach (BillItem item in listBill)
                {
                    if (item.Name == listOfItems[index].Name)
                    {
                        item.Price += item.Price;
                        item.Quantity += item.Quantity;

                        counter++;
                    }
                }
            }

            if (counter == 0 && start == false)
            {
                BillItem ni = new BillItem(listOfItems[index].Name, listOfItems[index].Price, listOfItems[index].Quantity);
                listBill.Add(ni);
            }

            outputBill.DataSource = listBill;

            MessageBox.Show("druga proba");
        }
    }
}
