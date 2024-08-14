// fabrica creadora de objetos
// 1 creador (clase abstracta) --> concrete creator (fabric)
// 1 product (interface)  --> concrete product


using Factory.Console;

// create fabrics
SaleFactory storeSaleFactory = new StoreSaleFactory(10);
SaleFactory internetSaleFactory = new InternetSaleFactory(10);

//create objects of type Isale

ISale sale1 = storeSaleFactory.GetSale();
sale1.Sell(15);

ISale sale2 = internetSaleFactory.GetSale();
sale1.Sell(15);

