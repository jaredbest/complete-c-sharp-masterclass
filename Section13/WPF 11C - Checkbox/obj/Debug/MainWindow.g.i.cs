﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2B3E3F52F69EE43047911C5F65ACE3AAE473ABBDBEE9D58DB44B90D5D5B96EA3"
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
using WPF_11C___Checkbox;


namespace WPF_11C___Checkbox {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbAllTopings;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbSalami;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbMushrooms;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbMozzarella;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF 11C - Checkbox;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.cbAllTopings = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\MainWindow.xaml"
            this.cbAllTopings.Checked += new System.Windows.RoutedEventHandler(this.cbAllCheckedChanged);
            
            #line default
            #line hidden
            
            #line 11 "..\..\MainWindow.xaml"
            this.cbAllTopings.Unchecked += new System.Windows.RoutedEventHandler(this.cbAllCheckedChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbSalami = ((System.Windows.Controls.CheckBox)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.cbSalami.Checked += new System.Windows.RoutedEventHandler(this.cbSingleCheckedChanged);
            
            #line default
            #line hidden
            
            #line 13 "..\..\MainWindow.xaml"
            this.cbSalami.Unchecked += new System.Windows.RoutedEventHandler(this.cbSingleCheckedChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbMushrooms = ((System.Windows.Controls.CheckBox)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.cbMushrooms.Checked += new System.Windows.RoutedEventHandler(this.cbSingleCheckedChanged);
            
            #line default
            #line hidden
            
            #line 19 "..\..\MainWindow.xaml"
            this.cbMushrooms.Unchecked += new System.Windows.RoutedEventHandler(this.cbSingleCheckedChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbMozzarella = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.cbMozzarella.Checked += new System.Windows.RoutedEventHandler(this.cbSingleCheckedChanged);
            
            #line default
            #line hidden
            
            #line 20 "..\..\MainWindow.xaml"
            this.cbMozzarella.Unchecked += new System.Windows.RoutedEventHandler(this.cbSingleCheckedChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

