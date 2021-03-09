using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string customerName = tbCustomerName.Text;
            var dateOut = dtRented.Value;
            var dateIn = dtReturned.Value;
            var carType = cbTypeOfCar.SelectedItem.ToString();
            double cost = Convert.ToDouble(tbCost.Text);
            var isValid = true;


            if(string.IsNullOrWhiteSpace(customerName )|| string.IsNullOrWhiteSpace(carType))
            {
                isValid = false;
                MessageBox.Show("Please Enter Missing Data");
            }

            if(dateOut > dateIn)
            {
                isValid = false;
                MessageBox.Show("Illegal Dte Selection");

            }

            //if(is valid== true) 
            if (isValid )
            {
                MessageBox.Show($"Customer Name:{customerName}\n\r" +
                               $"Date Rented:{dateOut}\n\r" +
                               $"Date Returned:{dateIn}\n\r" +
                               $"Cost:{cost}\n\r" +
                               $"Type Of Car:{carType}\n\r" +
                               $"Thank You For Doing Business With Cooper Car Rental!");
            }


            

        }
    }
}
