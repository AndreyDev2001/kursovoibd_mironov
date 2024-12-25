namespace SYBDKR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            ManagersForm managersForm = new ManagersForm();
            managersForm.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersForm suppliersForm = new SuppliersForm();
            suppliersForm.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }

        private void btnPremises_Click(object sender, EventArgs e)
        {
            PremisesForm premisesForm = new PremisesForm();
            premisesForm.Show();
        }
    }
}
