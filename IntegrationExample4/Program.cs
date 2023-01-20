using IntegrationExample4.Factory;
using IntegrationExample4.Models;
using IntegrationExample4.Interfaces;

Client client = new Client()
{
    Id = 1,
    Name = "Sage Client"
};

Invoice invoice = new Invoice()
{
    Id = 1,
    Name = "Sage Client"
};


Func<string> tokenRetrievalFunc = GetToken;
Func<string> tokenSaveFunc = SaveToken;

AccountingProviderFactory factory = new AccountingProviderFactory(tokenRetrievalFunc, tokenSaveFunc);

var clientProvider = factory.Client("Sage");
var invoiceProvider = factory.Invoice("Sage");

clientProvider.CreateClient(client,
            (result) => {
                //Do something with the returned Client object
                Console.WriteLine("Client created with ID: " + result.Id);
            },
            (ex) => {
                // do something with the exception
                Console.WriteLine("Error occured while creating client: " + ex.Message);
            }
);

invoiceProvider.CreateInvoice(invoice,
            (result) => {
                //Do something with the returned Client object
                Console.WriteLine("Invoice created with ID: " + result.Id);
            },
            (ex) => {
                // do something with the exception
                Console.WriteLine("Error occured while creating invoice: " + ex.Message);
            }
);

string GetToken()
{
    Console.WriteLine("Retrieving Token from KOST");
    //Logic for getting token from KOST
    return "Token";
}

string SaveToken()
{
    Console.WriteLine("Saving new Token in KOST");
    //Logic for saving token in KOST
    return "Success";
}