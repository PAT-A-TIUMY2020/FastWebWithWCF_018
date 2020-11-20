using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FastWebWichWCF
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = client.add(double.Parse(Textbox1.Text), double.Parse(Textbox2.Text)).ToString(); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Text = client.Divide(double.Parse(Textbox1.Text), double.Parse(Textbox2.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox3.Text = client.Multipli(double.Parse(Textbox1.Text), double.Parse(Textbox2.Text)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox3.Text = client.Sub(double.Parse(Textbox1.Text), double.Parse(Textbox2.Text)).ToString();
        }
    }
}