﻿#pragma checksum "..\..\..\..\Windows\PlantWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31514565CEB7EB7FE016F8A57D8ED33A8C379833"
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
    /// PlantWindow
    /// </summary>
    public partial class PlantWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\Windows\PlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LogInGrid;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Windows\PlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DatagridPlants;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Windows\PlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchTerm;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Windows\PlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchPlant;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Windows\PlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeletePlant;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Windows\PlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDetailsPlant;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Windows\PlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddPlantsWindow;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Windows\PlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClearFilter;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\Windows\PlantWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/GreenThumbProject;component/windows/plantwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\PlantWindow.xaml"
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
            
            #line 8 "..\..\..\..\Windows\PlantWindow.xaml"
            ((GreenThumbProject.Windows.PlantWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LogInGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.DatagridPlants = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.txtSearchTerm = ((System.Windows.Controls.TextBox)(target));
            
            #line 82 "..\..\..\..\Windows\PlantWindow.xaml"
            this.txtSearchTerm.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchTerm_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSearchPlant = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\Windows\PlantWindow.xaml"
            this.btnSearchPlant.Click += new System.Windows.RoutedEventHandler(this.btnSearchPlant_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnDeletePlant = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\..\Windows\PlantWindow.xaml"
            this.btnDeletePlant.Click += new System.Windows.RoutedEventHandler(this.btnDeletePlant_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDetailsPlant = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\Windows\PlantWindow.xaml"
            this.btnDetailsPlant.Click += new System.Windows.RoutedEventHandler(this.btnDetailsPlant_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnAddPlantsWindow = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\Windows\PlantWindow.xaml"
            this.btnAddPlantsWindow.Click += new System.Windows.RoutedEventHandler(this.btnAddPlantsWindow_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnClearFilter = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\..\Windows\PlantWindow.xaml"
            this.btnClearFilter.Click += new System.Windows.RoutedEventHandler(this.btnClearFilter_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnReturn = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\..\Windows\PlantWindow.xaml"
            this.btnReturn.Click += new System.Windows.RoutedEventHandler(this.btnReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

