﻿#pragma checksum "..\..\..\..\Windows\AdminView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EA39E22094AFE8CECB4B255EF212FA625BAA7730"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GreenThumbProject.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace GreenThumbProject.Windows {
    
    
    /// <summary>
    /// AdminView
    /// </summary>
    public partial class AdminView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\Windows\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LogInGrid;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Windows\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlantDatabase;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Windows\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUserDatabase;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Windows\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btninstructiondatabase;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Windows\AdminView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GreenThumbProject;component/windows/adminview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AdminView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LogInGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.btnPlantDatabase = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\Windows\AdminView.xaml"
            this.btnPlantDatabase.Click += new System.Windows.RoutedEventHandler(this.btnPlantDatabase_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnUserDatabase = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Windows\AdminView.xaml"
            this.btnUserDatabase.Click += new System.Windows.RoutedEventHandler(this.btnUserDatabase_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btninstructiondatabase = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\Windows\AdminView.xaml"
            this.btninstructiondatabase.Click += new System.Windows.RoutedEventHandler(this.btninstructiondatabase_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnReturn = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\Windows\AdminView.xaml"
            this.btnReturn.Click += new System.Windows.RoutedEventHandler(this.btnReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

