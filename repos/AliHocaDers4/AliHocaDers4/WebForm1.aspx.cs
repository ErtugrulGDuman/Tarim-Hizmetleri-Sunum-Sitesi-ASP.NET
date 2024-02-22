using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliHocaDers4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int gun = (int)DateTime.Now.DayOfWeek;
            switch (gun)
            {
                case 1:
                    Response.Write("Pazartesi");
                    break;
                case 2:
                    Response.Write("Salı");
                    break;
                case 3:
                    Response.Write("Çarşamba");
                    break;
                case 4:
                    Response.Write("Perşembe");
                    break;
                case 5:
                    Response.Write("Cuma");
                    break;
                case 6:
                    Response.Write("Cumartesi");
                    break;
                case 7:
                    Response.Write("Pazar");
                    break;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Text = TextBox1.Text + TextBox2.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int yas, gunumuz, dTarihi;
            gunumuz = DateTime.Now.Day;
            dTarihi = Calendar1.SelectedDate.Day;
            yas = gunumuz - dTarihi;
            Label6.Text = yas.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write(DropDownList1.SelectedItem.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label7.Text = (DropDownList1.SelectedItem.Text);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            byte days;
            days = Convert.ToByte(TextBox1.Text);
            switch (days)
            {
                case 1:
                    Label9.Text=("Monday");
                    break;
                case 2:
                    Label9.Text = ("Tuesday");
                    break;
                case 3:
                    Label9.Text = ("Wednesday");
                    break;
                case 4:
                    Label9.Text = ("Thursday");
                    break;
                case 5:
                    Label9.Text = ("Friday");
                    break;
                case 6:
                    Label9.Text = ("Saturday");
                    break;
                case 7:
                    Label9.Text = ("Sunday");
                    break;
            }
        }
    }}