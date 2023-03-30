using API_NET.Domain;

namespace API_NET.Repository
{
    public class ProductRepository
    {
        public static List<Product> Product { get; set; }


        public static void Add(Product product)
        {

            if (Product == null)
            {
                Product = new List<Product>();

            }

            Product.Add(product);
        }

        public static Product GetBy(string code)
        {
            return Product.FirstOrDefault(x => x.Code == code);

        }

        public static Product Edit(string code, Product codes)
        {
            var edit = Product.FirstOrDefault(x => x.Code == code);
            edit = codes;

            return edit;
        }

        public static List<Product> BuscarTodos()
        {
            return Product;
        }

        public static List<Product> Remove(Product product)
        {
            Product.Remove(product);

            return Product;

        }

        public static void Init(IConfiguration configuration)
        {
            var products = configuration.GetSection("Products").Get<List<Product>>();
            Product = products;
        }
    }
}
