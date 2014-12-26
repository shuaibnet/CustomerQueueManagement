using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagement
{
    public partial class CustomerQueueUI : Form
    {
        public CustomerQueueUI()
        {
            InitializeComponent();
        }
       
        //Complain aCompain = new Complain();
        Queue<Complain> complains = new Queue<Complain>();
        Queue<ListViewItem> items = new Queue<ListViewItem>();
        int counter = 1;

        private void enQButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            Complain complain = new Complain();
            complain.serial = counter.ToString();
            complain.name = nameTextBox.Text;
            complain.complain = complainTextBox.Text;
            complains.Enqueue(complain);

            item.Text = complain.serial;
            item.SubItems.Add(complain.name);
            item.SubItems.Add(complain.complain);
            items.Enqueue(item);

            complainListView.Items.Add(item);
            counter++;
            complainTextBox.Clear();
            nameTextBox.Clear();
            MessageBox.Show(complain.serial + "is the Serial number for" + complain.name);
        }

        private void deQButton_Click(object sender, EventArgs e)
        {
            if(complains.Count > 0)
            {
                serialDQTextBox.Text = complains.First().serial;
                nameDQTextBox.Text = complains.First().name;
                complainDQTextBox.Text = complains.First().complain;
                complains.Dequeue();
                complainListView.Items[0].Remove();
                
            }
            else
            {
                MessageBox.Show("No Complain int he Queue");
            }
        }
    }
}
