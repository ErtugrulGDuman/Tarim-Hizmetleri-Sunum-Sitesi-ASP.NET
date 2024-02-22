using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliHocaSonDers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Label1.Text = "";
            ListBox1.Items.Clear();
            int sayi;
            Random rnd = new Random();
            for (int i = 1; i <= 50; i++)
            {
                sayi = rnd.Next(0,1000);
                ListBox1.Items.Add(i + ". -  " + Convert.ToString(sayi));
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayi;
            for(int i=0; i<=49; i++)
            {
                sayi = Convert.ToInt32(ListBox1.Items[i].Text);
                toplam = toplam + sayi;
            }
            Label1.Text = toplam.ToString();
        }
    }
}