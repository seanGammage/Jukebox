﻿#pragma checksum "..\..\jukeboxEditor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61D9C384B4F00AE705243B4771C78378EF09C8DA"
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


namespace Jukebox {
    
    
    /// <summary>
    /// jukeboxEditor
    /// </summary>
    public partial class jukeboxEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox songTitleTb;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox artistNameTb;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox filePathTb;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button browseBtn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imgPathTb;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button browseImageBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label songTitleLbl;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label imageFileLbl;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label songMp3Lbl;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label artistNameLbl;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\jukeboxEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginPageBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Jukebox;component/jukeboxeditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\jukeboxEditor.xaml"
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
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\jukeboxEditor.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.songTitleTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.artistNameTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.filePathTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.browseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\jukeboxEditor.xaml"
            this.browseBtn.Click += new System.Windows.RoutedEventHandler(this.browseBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.imgPathTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.browseImageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\jukeboxEditor.xaml"
            this.browseImageBtn.Click += new System.Windows.RoutedEventHandler(this.browseImageBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.songTitleLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.imageFileLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.songMp3Lbl = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.artistNameLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.loginPageBtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\jukeboxEditor.xaml"
            this.loginPageBtn.Click += new System.Windows.RoutedEventHandler(this.loginPageBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

