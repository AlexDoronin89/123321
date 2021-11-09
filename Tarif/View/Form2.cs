using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarif
{
    public partial class Form1 : Form
    {
        private List<Tariffs> _tariffs;
        public Form1()
        {
            InitializeComponent();
            _tariffs = new List<Tariffs>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tariffs.Add(new Tariffs("Мой разговор",200 , 5,0));
            _tariffs.Add(new Tariffs("Мой онлайн", 500, 15, 0));
            _tariffs.Add(new Tariffs("Мой онлайн+", 800, 50, 0));
            _tariffs.Add(new Tariffs("Игровой", 700, 30, 100));
            foreach (var item in _tariffs)
            {
                listBoxTariffs.Items.Add(item.Name);
            }
        }

        private void listBoxTariffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in _tariffs)
            {
                if (item.Name == listBoxTariffs.SelectedItem.ToString())
                {
                    textBoxGygabytes.Text = item.Gygabytes.ToString();
                    textBoxMinutes.Text = item.Minutes.ToString();
                    textBoxMessages.Text = item.Messages.ToString();
                    textBoxPrice.Text = item.Price.ToString();
                }
               
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            buttonRegister.Enabled = true;
        }
    }
}
