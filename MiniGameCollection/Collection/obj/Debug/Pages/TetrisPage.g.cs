﻿#pragma checksum "..\..\..\Pages\TetrisPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "216F28B174699B4E0C6EC4D2AA6C36CE"
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


namespace Collection.Pages {
    
    
    /// <summary>
    /// TetrisPage
    /// </summary>
    public partial class TetrisPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\Pages\TetrisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas GridCanvas;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\TetrisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas LandedCanvas;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\TetrisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas MainCanvas;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\TetrisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas NextTetrisCanvas;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Pages\TetrisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpButton;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Pages\TetrisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownButton;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Pages\TetrisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeftButton;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Pages\TetrisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RightButton;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\Pages\TetrisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PauseButton;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Pages\TetrisPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Collection;component/pages/tetrispage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\TetrisPage.xaml"
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
            this.GridCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.LandedCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.MainCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.NextTetrisCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            this.UpButton = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\Pages\TetrisPage.xaml"
            this.UpButton.Click += new System.Windows.RoutedEventHandler(this.UpButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DownButton = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\Pages\TetrisPage.xaml"
            this.DownButton.Click += new System.Windows.RoutedEventHandler(this.DownButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LeftButton = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\Pages\TetrisPage.xaml"
            this.LeftButton.Click += new System.Windows.RoutedEventHandler(this.LeftButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RightButton = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\Pages\TetrisPage.xaml"
            this.RightButton.Click += new System.Windows.RoutedEventHandler(this.RightButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PauseButton = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\Pages\TetrisPage.xaml"
            this.PauseButton.Click += new System.Windows.RoutedEventHandler(this.PauseButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ResetButton = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\Pages\TetrisPage.xaml"
            this.ResetButton.Click += new System.Windows.RoutedEventHandler(this.RestButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
