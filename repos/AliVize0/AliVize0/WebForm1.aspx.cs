using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliVize0
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    Panel1.BackColor = System.Drawing.Color.Red;
                    break;
                case 1:
                    Panel1.BackColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    Panel1.BackColor = System.Drawing.Color.Blue;
                    break;
                case 3:
                    Panel1.BackColor = System.Drawing.Color.Magenta;
                    break;
            }
            
            
            Label1.Text = DropDownList1.SelectedItem.ToString();
            Label2.Text=TextBox1.Text;
        }
    }
}
