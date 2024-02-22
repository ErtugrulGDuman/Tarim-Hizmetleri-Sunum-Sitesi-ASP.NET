using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliHocaDers3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Fiyat = 100;
            double KdvliFiyat;
            KdvliFiyat = (Fiyat * 18)/100 + Fiyat;
            Response.Write(KdvliFiyat);
            Response.Write("<br>");


            double Toplam = 0.117;
            double x = 0.87;
            if (Toplam > x)
            {
                Response.Write("Toplam > x"+ Toplam);
            }
            else
            {
                Response.Write(x > Toplam + x);
            }
        }
    }
}

