using IntegrationExample4.Factory;
using IntegrationExample4.Models;
using IntegrationExample4.Interfaces;

IClient client = new Client()
{
    Id = 1,
    Name = "Sage Client",
    GUID = null,
    UserID = 1
};

IInvoice invoice = new Invoice()
{
    Id = 1,
    Name = "Sage Invoice",
    GUID = null,
    UserID = 1
};

var factory = new IntegrationFactory();

int userID = 1;
IGateway gateway = new Gateway(userID);

factory.CreateConnection("Sage", gateway);

//Connect to the accounting provider
AccountingProvider providerFactory = factory.CreateAccountingProvider(gateway);

//Create the Entities for that accounting provider
var clientProvider = providerFactory.Client();
var invoiceProvider = providerFactory.Invoice();

//Make the crud calls to the accounting provider 
var sageClient = clientProvider.Upsert(client);
var sageInvoice = invoiceProvider.Upsert(invoice);

//Disconnect the current accounting provider
factory.Disconnect(gateway, providerFactory);
