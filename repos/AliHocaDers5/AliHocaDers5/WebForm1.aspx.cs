using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliHocaDers5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            ListBox1.Items.Clear();
            int sayi;
            Random rastgele = new Random();
            for (int i = 1; i <= 10; i++) {
                sayi = rastgele.Next(0, 1000);
                ListBox1.Items.Add(sayi.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            int sayi;
            Label1.Text=count.ToString();
            for (int i = 0; i <= 10; i++) {
                sayi = Convert.ToInt32(ListBox1.Items[i].Text);
                count = count + sayi;
                    }
            Label1.Text = count.ToString();

        }
    }
}