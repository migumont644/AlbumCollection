using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumCollection
{
    public partial class Form1 : Form
    {
        List<string> orderList = new List<string>();
        List<string> sortedList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            notexistLabel.Text = "";
            orderList.Add(albumInfoBox.Text);
            sortedList.Add(albumInfoBox.Text);

            orderLabel.Text = "";
            for (int i = 0; i < orderList.Count(); i++)

            {
                orderLabel.Text += "\n" + orderList[i];
                        
            }

            sortedList.Sort();
            sortLabel.Text = "";            
            for (int i = 0; i < sortedList.Count(); i++)
            {             
                sortLabel.Text += "\n" + sortedList[i];
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (sortedList.Contains(albumInfoBox.Text))
            {
                sortedList.Remove(albumInfoBox.Text);
                orderList.Remove(albumInfoBox.Text);
                sortedList.Sort();
                sortLabel.Text = "";
                for (int i = 0; i < sortedList.Count(); i++)
                {
                    sortLabel.Text += "\n" + sortedList[i];
                }
                
                orderLabel.Text = "";      
                for (int i = 0; i < orderList.Count(); i++)

                {
                    orderLabel.Text += "\n" + orderList[i];

                }
            }
            else
            {
                notexistLabel.Text = $"{albumInfoBox.Text} does not exist in the database";
            }
        }
    }
}
