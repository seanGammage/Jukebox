﻿#pragma checksum "..\..\JukeboxPlayer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2C873E5D007433510EE89B12A46EF4821319763E"
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
    /// JukeboxPlayer
    /// </summary>
    public partial class JukeboxPlayer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox songListBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElement1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox songListBox2;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label yourPlaylistLbl;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label addPlaylistLbl;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pauseBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\JukeboxPlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stopBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Jukebox;component/jukeboxplayer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\JukeboxPlayer.xaml"
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
            this.songListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 12 "..\..\JukeboxPlayer.xaml"
            this.songListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.songListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mediaElement1 = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 3:
            this.deleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\JukeboxPlayer.xaml"
            this.deleteBtn.Click += new System.Windows.RoutedEventHandler(this.deleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.playBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\JukeboxPlayer.xaml"
            this.playBtn.Click += new System.Windows.RoutedEventHandler(this.playBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.songListBox2 = ((System.Windows.Controls.ListBox)(target));
            
            #line 16 "..\..\JukeboxPlayer.xaml"
            this.songListBox2.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.songListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addBtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\JukeboxPlayer.xaml"
            this.addBtn.Click += new System.Windows.RoutedEventHandler(this.addBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.imgBox = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.yourPlaylistLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.addPlaylistLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.pauseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\JukeboxPlayer.xaml"
            this.pauseBtn.Click += new System.Windows.RoutedEventHandler(this.playBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.stopBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\JukeboxPlayer.xaml"
            this.stopBtn.Click += new System.Windows.RoutedEventHandler(this.playBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

