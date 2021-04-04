using System;
using System.Configuration;
using Npgsql;
using mypgModel;
using System.Data.EntityClient;
class app{
static void Main(){
ConnectionStringSettings settingCollection = ConfigurationManager.ConnectionStrings["MypgEntitiesConnectionString"];

EntityConnectionStringBuilder builder = new EntityConnectionStringBuilder(settingCollection.ConnectionString);
NpgsqlConnectionStringBuilder npgsqlBuilder = new NpgsqlConnectionStringBuilder(builder.ProviderConnectionString);
//With the help of NpgsqlConnectionStringBuilder it would be possible to assemble ConnectionString without taking it from 
// a *.exe.config file,  using EntityConnectionStringBuilder in conjuction with  NpgsqlConnectionStringBuilder.
//Console.WriteLine(settingCollection.ConnectionString);
//Console.WriteLine(builder.ConnectionString);

//NpgsqlConnectionStringBuilder npgsqlCSB = new NpgsqlConnectionStringBuilder();
//npgsqlCSB.Add();
//Console.WriteLine(settingCollection.ConnectionString);


//builder.ProviderConnectionString=npgsqlBuilder.ConnectionString;
//var context = new mypgEntities (builder.ProviderConnectionString);
string connstr="metadata=.\\mypg.csdl|.\\mypg.ssdl|.\\mypg.msl; provider=Npgsql; provider connection string=\"HOST=localhost;PORT=5432;PROTOCOL=3;DATABASE=mypg;USER ID=postgres;PASSWORD=44332211;SSL=False;SSLMODE=Disable;TIMEOUT=15;SEARCHPATH=;POOLING=True;CONNECTIONLIFETIME=15;MINPOOLSIZE=1;MAXPOOLSIZE=20;SYNCNOTIFICATION=False;COMMANDTIMEOUT=20;ENLIST=False;PRELOADREADER=False;USEEXTENDEDTYPES=False;INTEGRATED SECURITY=False;COMPATIBLE=2.0.12.0;APPLICATIONNAME=\"" ;
var context = new mypgEntities (connstr);

NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=44332211;Database=mypg;");
    conn.Open();
    conn.Close();
var mystr=context.mystrings;
var s="";
foreach(var str in mystr)s+=(str.mystr+" ");
Console.WriteLine(s);
/*Console.WriteLine();
Console.WriteLine(builder.ConnectionString);
Console.WriteLine();
Console.WriteLine(settingCollection.ConnectionString==builder.ConnectionString); //True !!*/

}
}