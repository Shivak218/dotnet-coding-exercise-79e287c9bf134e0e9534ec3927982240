using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiva_Project
{
    public interface IProduct
    {
        string Name { get; set; }

        decimal Price { get; set; }

        bool IsImported { get; set; }

        bool IsTaxable { get; set; }

        decimal SalesTax { get; set; }

    }

    public interface ITax
    {
        decimal BasicTax { get; set; }
        decimal ImportedTax { get; set; }
        IProduct ApplyTaxRates(IProduct pr);
    }

    public class TaxRates : ITax
    {
        decimal _basictax = 10.0m;
        decimal _importedtax = 5.0m;
        public decimal BasicTax
        {
            get
            {
                return _basictax;
            }

            set
            {
                _basictax = value;
            }
        }

        public decimal ImportedTax
        {
            get
            {
                return _importedtax;
            }

            set
            {
                _importedtax = value;
            }
        }

        public IProduct ApplyTaxRates(IProduct pr)
        {
            //Import tax is applicable at a rate of 5% on all imported goods, with no exemptions.            
            if (pr.IsImported == true && pr.IsTaxable == false)
            {
                //imported then 5%                
                pr.SalesTax = (pr.Price * 0.05m);
                pr.Price += pr.Price * 0.05m;
            }
            if (pr.IsImported == true && pr.IsTaxable == true)
            {
                //imported and taxable then 15%                
                pr.SalesTax = (pr.Price * 0.15m);
                pr.Price += pr.Price * 0.15m;
            }
            // Basic sales tax is applicable at a rate of 10 % on all goods except:Food,Book,Medical
            if (pr.IsImported == false && pr.IsTaxable == true)
            {
                pr.SalesTax = (pr.Price * 0.1m);
                pr.Price += pr.Price * 0.1m;
            }

            return pr;
        }

    }



    public class Books : IProduct
    {
        string _name = "Book";
        decimal _price = 0.0m;
        bool _isimported = false;
        bool _istaxable = false;
        decimal _taxrate = 0.0m;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public bool IsImported
        {
            get
            {
                return _isimported;
            }

            set
            {
                _isimported = value;
            }
        }

        public bool IsTaxable
        {
            get
            {
                return _istaxable;
            }

            set
            {
                _istaxable = value;
            }
        }

        public decimal SalesTax
        {
            get
            {
                return _taxrate;
            }

            set
            {
                _taxrate = value;
            }
        }
    }

    public class Music : IProduct
    {
        string _name = "Music";
        decimal _price = 0.0m;
        bool _isimported = false;
        bool _istaxable = true;
        decimal _taxrate = 0.0m;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public bool IsImported
        {
            get
            {
                return _isimported;
            }

            set
            {
                _isimported = value;
            }
        }

        public bool IsTaxable
        {
            get
            {
                return _istaxable;
            }

            set
            {
                _istaxable = value;
            }
        }

        public decimal SalesTax
        {
            get
            {
                return _taxrate;
            }

            set
            {
                _taxrate = value;
            }
        }
    }

    public class Food : IProduct
    {
        string _name = "Food";
        decimal _price = 0.0m;
        bool _isimported = false;
        bool _istaxable = false;
        decimal _taxrate = 0.0m;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public bool IsImported
        {
            get
            {
                return _isimported;
            }

            set
            {
                _isimported = value;
            }
        }

        public bool IsTaxable
        {
            get
            {
                return _istaxable;
            }

            set
            {
                _istaxable = value;
            }
        }

        public decimal SalesTax
        {
            get
            {
                return _taxrate;
            }

            set
            {
                _taxrate = value;
            }
        }
    }

    public class Medical : IProduct
    {
        string _name = "Medical";
        decimal _price = 0.0m;
        bool _isimported = false;
        bool _istaxable = false;
        decimal _taxrate = 0.0m;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public bool IsImported
        {
            get
            {
                return _isimported;
            }

            set
            {
                _isimported = value;
            }
        }

        public bool IsTaxable
        {
            get
            {
                return _istaxable;
            }

            set
            {
                _istaxable = value;
            }
        }

        public decimal SalesTax
        {
            get
            {
                return _taxrate;
            }

            set
            {
                _taxrate = value;
            }
        }
    }

    public class Perfume : IProduct
    {
        string _name = "Perfume";
        decimal _price = 0.0m;
        bool _isimported = false;
        bool _istaxable = true;
        decimal _taxrate = 0.0m;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public bool IsImported
        {
            get
            {
                return _isimported;
            }

            set
            {
                _isimported = value;
            }
        }

        public bool IsTaxable
        {
            get
            {
                return _istaxable;
            }

            set
            {
                _istaxable = value;
            }
        }

        public decimal SalesTax
        {
            get
            {
                return _taxrate;
            }

            set
            {
                _taxrate = value;
            }
        }
    }


    public enum enumProductType
    {
        Books,
        Music,
        Food,
        Medical,
        Perfume
    }

    public enum enumTaxRates
    {
        basicTaxRate,
        ImportedTaxRate
    }

    public interface ITaxRates { }

    /// <summary>
    /// Implementation of Factory - Used to create objects
    /// </summary>
    public class Factory
    {
        public Cart ApplyTaxRates(Cart cart)
        {
            IProduct prod = null;
            Cart Cart_Taxed = new Cart();

            foreach (var prods in cart.Products)
            {
                TaxRates tx = new TaxRates();
                switch (prods.GetType().Name)
                {
                    case "Books":
                        prod = tx.ApplyTaxRates(prods);
                        Cart_Taxed.Products.Add(prod);
                        break;
                    case "Music":
                        prod = tx.ApplyTaxRates(prods);
                        Cart_Taxed.Products.Add(prod);
                        break;
                    case "Medical":
                        prod = tx.ApplyTaxRates(prods);
                        Cart_Taxed.Products.Add(prod);
                        break;
                    case "Perfume":
                        prod = tx.ApplyTaxRates(prods);
                        Cart_Taxed.Products.Add(prod);
                        break;
                    case "Food":
                        prod = tx.ApplyTaxRates(prods);
                        Cart_Taxed.Products.Add(prod);
                        break;
                    default:
                        break;
                }
            }
            return Cart_Taxed;
        }

        public void CreateReceipt(List<Cart> lstcart)
        {
            StringBuilder receipt = new StringBuilder();
            int IdCart = 0;

            for (int i = 0; i < lstcart.Count(); i++)
            {
                decimal totalPrice = 0;
                decimal totalTax = 0;
                IdCart = i + 1;
                receipt.Append("CartID: " + IdCart.ToString() + Environment.NewLine);

                foreach (var product in lstcart[i].Products)
                {
                    receipt.Append("1 ");
                    totalTax += RoundingRule(product.SalesTax);
                    totalPrice += RoundingRule(product.Price);
                    receipt.Append(product.Name + " : " + RoundingRule(product.Price).ToString() + Environment.NewLine);
                }
                receipt.Append(" Total Sales Taxes: " + RoundingRule(totalTax).ToString("0.00") + Environment.NewLine);
                receipt.Append(" Total: " + RoundingRule(totalPrice).ToString("0.00") + Environment.NewLine);
                receipt.Append("=================================================================================" + Environment.NewLine);
            }


            System.Console.Out.WriteLine(receipt);

            System.Console.WriteLine("Press ESC to quit ...");
            do
            { while (!System.Console.KeyAvailable) { } }
            while (System.Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        public static decimal RoundingRule(decimal tax)
        {
            return Math.Round(tax, 2, MidpointRounding.AwayFromZero);
        }
    }

    public class BaseDomain
    {
        public int Id { get; set; }
    }

    public class Cart : BaseDomain
    {
        public Cart()
        {
            this.Products = new List<IProduct>();
        }

        public List<IProduct> Products { get; private set; }
    }



    class Program
    {

        static void Main(string[] args)
        {

            var cartId = 0;

            var cart1 = new Cart { Id = ++cartId };
            cart1.Products.Add(new Books { Name = "books", Price = 12.49m, IsImported = false });
            cart1.Products.Add(new Music { Name = "music CD", Price = 14.99m, IsImported = false });
            cart1.Products.Add(new Food { Name = "chocolate bar", Price = 0.85m, IsImported = false });

            var cart2 = new Cart { Id = ++cartId };
            cart2.Products.Add(new Food { Name = "box of chocolates", Price = 10.00m, IsImported = true });
            cart2.Products.Add(new Perfume { Name = "bottle of perfume", Price = 47.50m, IsImported = true });

            var cart3 = new Cart { Id = ++cartId };
            cart3.Products.Add(new Perfume { Name = "bottle of perfume", Price = 27.99m, IsImported = true });
            cart3.Products.Add(new Perfume { Name = "bottle of perfume", Price = 18.99m, IsImported = false });
            cart3.Products.Add(new Medical { Name = "packet of headache pills", Price = 9.75m, IsImported = false });
            cart3.Products.Add(new Food { Name = "box of chocolates", Price = 11.25m, IsImported = true });

            var carts = new[] { cart1, cart2, cart3 };

            Factory fact = new Factory();
            List<Cart> lstCarts = new List<Cart>();

            foreach (var cart in carts)
            {
                lstCarts.Add(fact.ApplyTaxRates(cart));
            }
            fact.CreateReceipt(lstCarts);

            var test = carts;
        }
    }
}