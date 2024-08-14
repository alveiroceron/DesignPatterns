namespace Factory.Console
{
    //clase abstracta la cual va a crear fabricas
    // Creator
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    // Concrete Creator (fabric)
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;
        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }
        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    // Concrete Creator 
    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;
        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }
        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }



    // Product
    public interface ISale
    {
        public void Sell(decimal total);
    }

    // Concrete product
    public class StoreSale : ISale
    {
        private decimal _extra;

        public StoreSale(decimal extra)
        {
            _extra = extra;
        }
        public void Sell(decimal total)
        {
            System.Console.WriteLine($"La venta en TIENDA tiene un total de {total + _extra}");
        }
    }

    // Concrete product
    public class InternetSale : ISale
    {
        private decimal _disscount;

        public InternetSale(decimal disccount)
        {
            _disscount = disccount;
        }
        public void Sell(decimal total)
        {
            System.Console.WriteLine($"La venta en INTERNET tiene un total de {total - _disscount}");
        }
    }

}
