using System;
using System.Configuration;
using Npgsql;
using System.Data.EntityClient;
using mypgModel;
using System.Data.Objects;
partial class pageClass{

void appage_loaded(object o,EventArgs e){
string connstr="metadata=.\\PostgresMypgEdm\\mypg.csdl|.\\PostgresMypgEdm\\mypg.ssdl|.\\PostgresMypgEdm\\mypg.msl; provider=Npgsql; provider connection string='host=LOCALHOST;port=5432;protocol=3;database=mypg;user id=postgres;password=44332211;ssl=False;sslmode=Disable;timeout=15;pooling=True;connectionlifetime=15;minpoolsize=1;maxpoolsize=20;syncnotification=False;commandtimeout=20;enlist=False;preloadreader=False;useextendedtypes=False;integrated security=False;compatible=2.0.12.0'";
var context=new mypgEntities(connstr);
var col=context.mystrings;
myCombie.DataContext=col;
//myCombie.DataContext=col.Execute(MergeOption.AppendOnly);
Console.WriteLine("myCombie.DataContext=col;");
Console.WriteLine(myCombie.Name);
Console.WriteLine(".exe to the native directory");
}
void myBClick(object o,EventArgs e){myText.Text+="\u3332";}
}
