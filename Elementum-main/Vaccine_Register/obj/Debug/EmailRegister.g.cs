﻿#pragma checksum "..\..\EmailRegister.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2D1FB44687D8316A8AC1BFF3B904497365095D772DBA67A51666866B96A912AC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using Vaccine_Register;


namespace Vaccine_Register {
    
    
    /// <summary>
    /// EmailRegister
    /// </summary>
    public partial class EmailRegister : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\EmailRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeBttn;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\EmailRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseBttn;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\EmailRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Emailtxtbox;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\EmailRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubmitBttn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
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
            System.Uri resourceLocater = new System.Uri("/Vaccine_Register;component/emailregister.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EmailRegister.xaml"
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
            this.MinimizeBttn = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\EmailRegister.xaml"
            this.MinimizeBttn.Click += new System.Windows.RoutedEventHandler(this.MinimizeBttn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseBttn = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\EmailRegister.xaml"
            this.CloseBttn.Click += new System.Windows.RoutedEventHandler(this.CloseBttn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Emailtxtbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 149 "..\..\EmailRegister.xaml"
            this.Emailtxtbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.EmailTxtBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SubmitBttn = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\EmailRegister.xaml"
            this.SubmitBttn.Click += new System.Windows.RoutedEventHandler(this.SubmitBttn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
