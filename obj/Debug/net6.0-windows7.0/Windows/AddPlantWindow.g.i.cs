﻿#pragma checksum "..\..\..\..\Windows\AddPlantWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8713D3A00C6E32F9DB53FD25FB5095BA582060A7"
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
    /// AddPlantWindow
    /// </summary>
    public partial class AddPlantWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\..\..\Windows\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LogInGrid;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Windows\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPlantName;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Windows\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDetailsofPlant;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Windows\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInstructionforPlant;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Windows\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInstructionsAdded;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\Windows\AddPlantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddinstruction;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Windows\AddPlantWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/GreenThumbProject;component/windows/addplantwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AddPlantWindow.xaml"
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
            this.txtPlantName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtDetailsofPlant = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtInstructionforPlant = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lblInstructionsAdded = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnAddinstruction = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\Windows\AddPlantWindow.xaml"
            this.btnAddinstruction.Click += new System.Windows.RoutedEventHandler(this.btnAddinstruction_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 86 "..\..\..\..\Windows\AddPlantWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FinishButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnReturn = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\..\Windows\AddPlantWindow.xaml"
            this.btnReturn.Click += new System.Windows.RoutedEventHandler(this.btnReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

