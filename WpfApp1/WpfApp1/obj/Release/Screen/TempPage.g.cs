﻿#pragma checksum "..\..\..\Screen\TempPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CBE0A7A444B61B483711B93B0074841ADA10726D"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
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
using System.Windows.Forms.Integration;
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
using WpfApp1.Screen;


namespace WpfApp1.Screen {
    
    
    /// <summary>
    /// TempPage
    /// </summary>
    public partial class TempPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Screen\TempPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TitleLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Screen\TempPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LoginNameLabel;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Screen\TempPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TraningSideButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Screen\TempPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ScheduleSideButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Screen\TempPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MealSideButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Screen\TempPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfigSideButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Screen\TempPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame ContentFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/screen/temppage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Screen\TempPage.xaml"
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
            this.TitleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.LoginNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.TraningSideButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Screen\TempPage.xaml"
            this.TraningSideButton.Click += new System.Windows.RoutedEventHandler(this.TraningSideButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ScheduleSideButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Screen\TempPage.xaml"
            this.ScheduleSideButton.Click += new System.Windows.RoutedEventHandler(this.ScheduleSideButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MealSideButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Screen\TempPage.xaml"
            this.MealSideButton.Click += new System.Windows.RoutedEventHandler(this.MealSideButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ConfigSideButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Screen\TempPage.xaml"
            this.ConfigSideButton.Click += new System.Windows.RoutedEventHandler(this.ConfigSideButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ContentFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 24 "..\..\..\Screen\TempPage.xaml"
            this.ContentFrame.Loaded += new System.Windows.RoutedEventHandler(this.ContentFrame_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

