using System;
using LinqToXmlDataBinding;
partial class a{
	public void kuku(object o,EventArgs e){
		Console.WriteLine("Kuku !");
		pageClass wk=new pageClass();
		wk.InitializeComponent();
		wk.Show();
		L2XDBForm l2xdbform = new L2XDBForm();
		l2xdbform.Show();
		
		
		
		
		
	}
	
}