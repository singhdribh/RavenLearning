using Raven.Client.Documents;
using RavenLearning;
using RavenLearning.Mutations;
using RavenLearning.Queries;
using RavenLearning.Schema;
using System.Security.Cryptography.X509Certificates;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
services.AddGraphQLServer()
    //.AddQueryType(x => x.Name("Query")).AddType<AuctionQueries>().AddType<AuctionType>()
    //.AddMutationType<AuctionMutations>()
   .AddRavenProjections();
//services.AddSingleton<IDocumentStore>(_ =>
//new DocumentStore
//{
//    Urls = new[] { configuration.GetValue<string>("RavenUri") },
//    Database = configuration.GetValue<string>("RavenDbName"),
//    Certificate = new X509Certificate2("RavenCert.pfx", configuration.GetValue<string>("RavenPassword"))
//}.Initialize());


var app = builder.Build();
app.SeedData();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
    endpoints.MapGraphQLVoyager("ui/voyager");
});
app.MapGet("/", () => "Hello World!");

app.Run();
