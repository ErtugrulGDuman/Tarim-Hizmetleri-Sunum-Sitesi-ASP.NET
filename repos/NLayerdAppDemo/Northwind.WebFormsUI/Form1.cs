using Northwind.Business.Concrete;

namespace Northwind.WebFormsUI
{
    public class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductManager productManager = new();
            dgwProduct.DataSource = productManager.GetAll();
        }
    }
}