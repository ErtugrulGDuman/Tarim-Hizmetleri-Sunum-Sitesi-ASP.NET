using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliHocaDers2i
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(Sayi.Text);
            if (sayi > 0)
            {
                Sonuc.Text="Girdiğiniz sayı pozitif";
            }
            else if (sayi < 0)
            {
                Sonuc.Text="Girdiğiniz sayı negatif";
            }
            else
            {
                Sonuc.Text="Girdiğiniz sayı '0' ";
            }
            Label1.Text = DateTime.Now-Calendar1 =Sonuc
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            int DogumTarihi = Convert.ToInt16(Calendar1);
        }
    }
}