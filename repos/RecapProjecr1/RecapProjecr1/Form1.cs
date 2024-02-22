namespace RecapProjecr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataGridView GetDgvProduct()
        {
            return dgvProduct;
        }

        private void Form1_Load(object sender, EventArgs e, DataGridView dgvProduct)
        {
            try
            {
                using (NorthWindContext context = new NorthWindContext())
                {
                    dgvProduct.DataSource = context.Products.ToList();
                }
            }
            catch
            {

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}