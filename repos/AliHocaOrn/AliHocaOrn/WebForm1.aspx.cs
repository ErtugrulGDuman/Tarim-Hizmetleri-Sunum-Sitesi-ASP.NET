using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliHocaOrn
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int sayac = 0;
            do
            {
                Response.Write(sayac);
                Response.Write("<br>");
                sayac++;
            }
            while (sayac <= 100);
        }
    }
}