using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPurchaseApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string customerName;
        private double totalPrice;
        private double numberOfTickets;
        private double unitPrice;
        
        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            customerName = customerNameTextBox.Text;
            unitPrice = 10;
            numberOfTickets = Convert.ToDouble(noOfTicketsTextBox.Text);
            totalPrice = unitPrice*numberOfTickets;
            MessageBox.Show(customerName + " Please Pay " + totalPrice + " Taka to Purchase "+ numberOfTickets + " Ticket");
            customerNameTextBox.Text = "";
            noOfTicketsTextBox.Text = "";
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name : "+customerName + "\n" +"Number of Tickets : "+ numberOfTickets +"\n" + " Unit Price "+unitPrice+ "\n"+  "Total Price : " + totalPrice );
        }

       

      
    }
}
