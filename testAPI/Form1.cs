using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aping;
using System.Net;
using System.Collections.Specialized;

namespace testAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApIng myAping = new ApIng("DA02vQ9zQJTy0aDnSp0Do2mc8LTY8o1a","2904561Y","1/01/1980");
                //List<ProductsList> myProduct = myAping.requestProducts();
                //Customer toTest1 = myAping.requestCustomerProfile();
                //CustomerContract toTest2 = myAping.requestCustomerContract();
                //CustomerFinancialInformation toTest3 = myAping.requestCustomerFinancialInformation();
                //List<ProductsList> toTest4 = myAping.requestProducts();
                //PrepareForTransfer ToTest5 = myAping.requestPrepareForTransfer();
            MoneyTransfer toTransfer = new MoneyTransfer();
            toTransfer.from = new Aping.From{productNumber ="14650100911708338200"};
            toTransfer.to = new Aping.To { productNumber = "14650100932025956187", titular = "PEPE PEREZ PEREZ" };
            toTransfer.currency = "EUR";
            toTransfer.operationDate = "29/03/2014";
            toTransfer.concept = "this is a first test";
            toTransfer.amount = 100.5d;
                //UpdateTransfer toTest6 = myAping.requestUpdateTransfer(ToTest5.id, toTransfer);
                //ConfirmationOfTransfer toTest7 = myAping.requestConfirmationOfTransfer("1,1", ToTest5.id);
            ConfirmationOfTransfer fullPayment = myAping.EasyTransfer(toTransfer, "1,1");
            MessageBox.Show(fullPayment.ToString());
            myAping.LogOut();
          
        }
    }
}
