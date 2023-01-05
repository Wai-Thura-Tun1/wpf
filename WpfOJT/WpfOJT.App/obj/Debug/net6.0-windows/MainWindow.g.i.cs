﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AE2541E9A02F0FE0050596CB595A701326ECAC88"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfOJT.App.ViewModels;


namespace WpfOJT.App {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button profileBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resetPassBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logoutBtn;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuUser;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuUserList;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuCreateUser;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuPost;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuPostList;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuCreatePost;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem logoutMenu;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfOJT.App;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.profileBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.profileBtn.Click += new System.Windows.RoutedEventHandler(this.ProfileBtn_Clicked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.resetPassBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\MainWindow.xaml"
            this.resetPassBtn.Click += new System.Windows.RoutedEventHandler(this.ResetPassBtn_Clicked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.logoutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\MainWindow.xaml"
            this.logoutBtn.Click += new System.Windows.RoutedEventHandler(this.logoutBtn_Clicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.menuUser = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.menuUserList = ((System.Windows.Controls.MenuItem)(target));
            
            #line 63 "..\..\..\MainWindow.xaml"
            this.menuUserList.Click += new System.Windows.RoutedEventHandler(this.menuUserList_Clicked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.menuCreateUser = ((System.Windows.Controls.MenuItem)(target));
            
            #line 69 "..\..\..\MainWindow.xaml"
            this.menuCreateUser.Click += new System.Windows.RoutedEventHandler(this.menuCreateUser_Clicked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.menuPost = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 8:
            this.menuPostList = ((System.Windows.Controls.MenuItem)(target));
            
            #line 81 "..\..\..\MainWindow.xaml"
            this.menuPostList.Click += new System.Windows.RoutedEventHandler(this.menuPostList_Clicked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.menuCreatePost = ((System.Windows.Controls.MenuItem)(target));
            
            #line 87 "..\..\..\MainWindow.xaml"
            this.menuCreatePost.Click += new System.Windows.RoutedEventHandler(this.menuCreatePost_Clicked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.logoutMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 94 "..\..\..\MainWindow.xaml"
            this.logoutMenu.Click += new System.Windows.RoutedEventHandler(this.logoutMenu_Clicked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
