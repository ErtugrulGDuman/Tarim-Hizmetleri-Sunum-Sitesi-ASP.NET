using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliHocaDers8
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int toplami = 0;
            for (int i = 1; i <= 100; i++)
            {
                toplami=toplami+i;
                Label1.Text=toplami.ToString();
            } 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i <= 500; i++)
            {
                toplam=toplam+i;
                Label2.Text=toplam.ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(TextBox1.Text);
            int sonuc = 1;
            for(int i = 1; i <= a; i++)
            {
                sonuc=sonuc*i;
            }
            Label3.Text=sonuc.ToString();
        }
    }
}