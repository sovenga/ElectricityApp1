﻿

#pragma checksum "D:\Mod\Documents\ElectricityApp\ElectricityApp\ElectricityApp.Shared\RegisterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A9484A1B046B5AE7098776811D9FDBC2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectricityApp
{
    partial class RegisterPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 19 "..\..\..\RegisterPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBlock)(target)).SelectionChanged += this.TextBlock_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 24 "..\..\..\RegisterPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnRegister_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 29 "..\..\..\RegisterPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnBack_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


