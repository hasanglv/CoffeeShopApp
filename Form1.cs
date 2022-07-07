using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (namecombo.SelectedItem.ToString() == "LATTE")
            {
                if (typecombo.SelectedItem.ToString() == "FRAPP")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 6).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "ICE")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 7).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "HOT")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 5).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            ///
           else if (namecombo.SelectedItem.ToString() == "AMERICANO")
            {
                if (typecombo.SelectedItem.ToString() == "FRAPP")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 5.5).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "ICE")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 6.5).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "HOT")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 7.5).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (namecombo.SelectedItem.ToString() == "MOCHA")
            {
                if (typecombo.SelectedItem.ToString() == "FRAPP")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 6).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "ICE")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 7).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "HOT")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 9).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (namecombo.SelectedItem.ToString() == "CAPPUCCINO")
            {
                if (typecombo.SelectedItem.ToString() == "FRAPP")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 11).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "ICE")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 8).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "HOT")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 7.5).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (namecombo.SelectedItem.ToString() == "ESPRESSO")
            {
                if (typecombo.SelectedItem.ToString() == "FRAPP")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 10).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "ICE")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 4.5).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "HOT")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 9.5).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (namecombo.SelectedItem.ToString() == "FLAT WHITE")
            {
                if (typecombo.SelectedItem.ToString() == "FRAPP")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 12).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "ICE")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 13).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "HOT")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 9).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (namecombo.SelectedItem.ToString() == "AU LAIT")
            {
                if (typecombo.SelectedItem.ToString() == "FRAPP")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 8).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "ICE")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 8.5).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "HOT")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 7.5).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (namecombo.SelectedItem.ToString() == "MACCHIATO")
            {
                if (typecombo.SelectedItem.ToString() == "FRAPP")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 11).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "ICE")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 12).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "HOT")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 7).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (namecombo.SelectedItem.ToString() == "RISTRETTO")
            {
                if (typecombo.SelectedItem.ToString() == "FRAPP")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 10).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "ICE")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 7.5).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "HOT")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 10.5).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (namecombo.SelectedItem.ToString() == "LUNGO")
            {
                if (typecombo.SelectedItem.ToString() == "FRAPP")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 17).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "ICE")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 14.5).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "HOT")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 12.5).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);

            }
        }

        private void idtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            namecombo.Text = "";
            typecombo.Text = "";
            quantitycombo.Text = "";
            paytext.Text ="";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

