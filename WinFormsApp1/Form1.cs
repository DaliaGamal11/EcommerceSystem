using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly EcommerceDbContext _context;
        private List<Product> _products;
        public Form1()
        {
            InitializeComponent();
            _context = new EcommerceDbContext();
        }

        // Constructor that accepts a List<Product> and chains to the parameterless constructor
        public Form1(List<Product> products) : this() // Call parameterless constructor first
        {
            _products = products; // Initialize the _products field
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (_products != null)
            {
                var products = _products.Select(p => new { name = p.ProductName, price = p.Price, id = p.ProductId, description = p.Description }).ToList();
                ProductList.DataSource = products;
            }
            else
            {
                var products =_context.Products.Select(p => new { name = p.ProductName, price = p.Price, id = p.ProductId, description = p.Description }).ToList();
                ProductList.DataSource = products;
            }
        
        }
    }
}
