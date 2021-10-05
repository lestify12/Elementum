// Updated by XamlIntelliSenseFileGenerator 9/13/2021 8:43:04 PM
#pragma checksum "..\..\Opening.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "073FCDDEA076B09E180CC1EEC092687DC9CF4C01D150DB82B2EF44E9E61D7C29"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Themes;
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


namespace Vaccine_Register.Themes
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class Opening : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Vaccine_Register;component/opening.xaml", System.UriKind.Relative);

#line 1 "..\..\Opening.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 24 "..\..\Opening.xaml"
                    ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Titlebar_MouseDown);

#line default
#line hidden
                    return;
                case 2:
                    this.MinimizeBttn = ((System.Windows.Controls.Button)(target));

#line 58 "..\..\Opening.xaml"
                    this.MinimizeBttn.Click += new System.Windows.RoutedEventHandler(this.MinimizeBttn_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.CloseBttn = ((System.Windows.Controls.Button)(target));

#line 91 "..\..\Opening.xaml"
                    this.CloseBttn.Click += new System.Windows.RoutedEventHandler(this.CloseBttn_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.NameTxtbox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.AddressTxtbox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.ContactTxtbox = ((System.Windows.Controls.TextBox)(target));

#line 203 "..\..\Opening.xaml"
                    this.ContactTxtbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumValidation);

#line default
#line hidden
                    return;
                case 7:
                    this.CategoryTxtbox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.PhilhealthTxtbox = ((System.Windows.Controls.TextBox)(target));

#line 224 "..\..\Opening.xaml"
                    this.PhilhealthTxtbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumValidation);

#line default
#line hidden
                    return;
                case 9:
                    this.BirthdayDatePicker = ((System.Windows.Controls.DatePicker)(target));

#line 240 "..\..\Opening.xaml"
                    this.BirthdayDatePicker.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DateValidation);

#line default
#line hidden
                    return;
                case 10:
                    this.SexCombo = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 11:
                    this.FirstDoseDatePicker = ((System.Windows.Controls.DatePicker)(target));

#line 339 "..\..\Opening.xaml"
                    this.FirstDoseDatePicker.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DateValidation);

#line default
#line hidden
                    return;
                case 12:
                    this.FirstDoseVaccineManufacturerCombo = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 13:
                    this.FirstDoseBatchNoTxtBox = ((System.Windows.Controls.TextBox)(target));

#line 380 "..\..\Opening.xaml"
                    this.FirstDoseBatchNoTxtBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumValidation);

#line default
#line hidden
                    return;
                case 14:
                    this.FirstDoseLotNoTxtBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 15:
                    this.FirstDoseVaccinatorTxtBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 16:
                    this.SecondDoseDatePicker = ((System.Windows.Controls.DatePicker)(target));

#line 473 "..\..\Opening.xaml"
                    this.SecondDoseDatePicker.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DateValidation);

#line default
#line hidden
                    return;
                case 17:
                    this.SecondDoseVaccineManufacturerCombo = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 18:
                    this.SecondDoseBatchNoTxtBox = ((System.Windows.Controls.TextBox)(target));

#line 516 "..\..\Opening.xaml"
                    this.SecondDoseBatchNoTxtBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumValidation);

#line default
#line hidden
                    return;
                case 19:
                    this.SecondDoseLotNoTxtBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 20:
                    this.SecondDoseVaccinatorTxtBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 21:
                    this.FacilityTxtbox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 22:
                    this.ContactNoBottomTxtbox = ((System.Windows.Controls.TextBox)(target));

#line 601 "..\..\Opening.xaml"
                    this.ContactNoBottomTxtbox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumValidation);

#line default
#line hidden
                    return;
                case 23:
                    this.CancelBttn = ((System.Windows.Controls.Button)(target));
                    return;
                case 24:
                    this.SubmitBttn = ((System.Windows.Controls.Button)(target));

#line 656 "..\..\Opening.xaml"
                    this.SubmitBttn.Click += new System.Windows.RoutedEventHandler(this.SubmitBttn_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

