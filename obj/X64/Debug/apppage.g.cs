﻿#pragma checksum "..\..\..\apppage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "664CA5439BDCFFE914F0CA9876E5DBD9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;




/// <summary>
/// pageClass
/// </summary>
public partial class pageClass : System.Windows.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 8 "..\..\..\apppage.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.Grid myGrid;
    
    #line default
    #line hidden
    
    
    #line 18 "..\..\..\apppage.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.ComboBox myCombie;
    
    #line default
    #line hidden
    
    
    #line 21 "..\..\..\apppage.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.Label myL;
    
    #line default
    #line hidden
    
    
    #line 22 "..\..\..\apppage.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.TextBlock myText;
    
    #line default
    #line hidden
    
    
    #line 25 "..\..\..\apppage.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.Button myB;
    
    #line default
    #line hidden
    
    private bool _contentLoaded;
    
    
    #line 3 "..\..\..\apppage.xaml"

void heavilyLoaded(object o,EventArgs e){Console.WriteLine(@"heavilyLoaded DisplayMemberPath");
appage_loaded(o,e);
}

    #line default
    #line hidden
    
    
    /// <summary>
    /// InitializeComponent
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent() {
        if (_contentLoaded) {
            return;
        }
        _contentLoaded = true;
        System.Uri resourceLocater = new System.Uri("/app;component/apppage.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\..\apppage.xaml"
        System.Windows.Application.LoadComponent(this, resourceLocater);
        
        #line default
        #line hidden
    }
    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
    void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
        
        #line 2 "..\..\..\apppage.xaml"
        ((pageClass)(target)).Loaded += new System.Windows.RoutedEventHandler(this.heavilyLoaded);
        
        #line default
        #line hidden
        return;
            case 2:
        this.myGrid = ((System.Windows.Controls.Grid)(target));
        return;
            case 3:
        this.myCombie = ((System.Windows.Controls.ComboBox)(target));
        return;
            case 4:
        this.myL = ((System.Windows.Controls.Label)(target));
        return;
            case 5:
        this.myText = ((System.Windows.Controls.TextBlock)(target));
        return;
            case 6:
        this.myB = ((System.Windows.Controls.Button)(target));
        
        #line 25 "..\..\..\apppage.xaml"
        this.myB.Click += new System.Windows.RoutedEventHandler(this.myBClick);
        
        #line default
        #line hidden
        return;
            }
        this._contentLoaded = true;
    }
}

