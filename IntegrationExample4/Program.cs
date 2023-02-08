using IntegrationExample4.Factory;
using IntegrationExample4.Models;
using IntegrationExample4.Interfaces;
using IntegrationExample4.Data;

//This is just an example object of the DBcontext object that we will use in EF core
KDBcontext context = new KDBcontext();

int userID = 1;

IClient client = new Client()
{
    Id = 1,
    Name = "Sage Client",
    GUID = null,
    UserID = userID
};

IInvoice invoice = new Invoice()
{
    Id = 1,
    Name = "Sage Invoice",
    GUID = null,
    UserID = userID
};

//This is what Neil will have to add to his Startup.cs class
//services.AddDbContext<KDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//services.AddSingleton<IntegrationFactory>(provider => new IntegrationFactory(provider.GetService<KDbContext>()));

var factory = new IntegrationFactory(context);

IGateway gateway = new Gateway(userID);

//Connect to the accounting provider
factory.CreateConnection("Sage", gateway);

//Create our providerFactory that will handle calls to the api
AccountingProvider providerFactory = factory.CreateAccountingProvider(gateway);

//Create the Entities for that accounting provider and do an upsert
providerFactory.Client().Upsert(client);
providerFactory.Invoice().Upsert(invoice);

//Disconnect the current accounting provider
factory.Disconnect(gateway);
