using IntegrationExample4.Factory;
using IntegrationExample4.Models;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Data;

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

KDBcontext context = new KDBcontext();

//This is what Neil will have to add to his Startup.cs class
//services.AddDbContext<KDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//services.AddSingleton<IntegrationFactory>(provider => new IntegrationFactory(provider.GetService<KDbContext>()));

var factory = new IntegrationFactory(context);

int userID = 1;
IGateway gateway = new Gateway(userID);

factory.CreateConnection("Sage", gateway);

//Connect to the accounting provider
AccountingProvider providerFactory = factory.CreateAccountingProvider(gateway);

//Create the Entities for that accounting provider and do an upsert
providerFactory.Client().Upsert(client);
providerFactory.Invoice().Upsert(invoice);

//Disconnect the current accounting provider
factory.Disconnect(gateway);
