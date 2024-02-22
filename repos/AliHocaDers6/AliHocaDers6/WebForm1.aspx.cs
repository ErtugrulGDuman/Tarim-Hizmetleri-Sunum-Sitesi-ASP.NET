using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliHocaDers6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sayi =0;
            for(int i = 0; i <= 100; i++)
            {
                sayi = sayi + i;
            }
            Label1.Text= sayi.ToString();
            int sonuc=1, a=5;
            for (int i = 1; i <= a; i++)
            {
                sonuc = sonuc * i;
            }
            Literal1.Text= sonuc.ToString();
        }
    }
}