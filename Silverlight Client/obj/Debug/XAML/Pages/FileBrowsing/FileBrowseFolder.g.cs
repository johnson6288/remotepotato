﻿#pragma checksum "C:\Users\carl\Visual Studio\Projects\RemotePotatoServer\SilverPotato\XAML\Pages\FileBrowsing\FileBrowseFolder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F003EA67E69992EE4EAD8F7B1573047D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SilverPotato {
    
    
    public partial class FileBrowseFolder : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.TranslateTransform ttMover;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid gdContent;
        
        internal System.Windows.Controls.Border btnFolderUp;
        
        internal System.Windows.Controls.Image imgNavBack;
        
        internal System.Windows.Controls.TextBlock lblPageTitle;
        
        internal System.Windows.Controls.TextBlock lblNotification;
        
        internal System.Windows.Controls.TextBlock btnShowEmptyFolders;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverPotato;component/XAML/Pages/FileBrowsing/FileBrowseFolder.xaml", System.UriKind.Relative));
            this.ttMover = ((System.Windows.Media.TranslateTransform)(this.FindName("ttMover")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.gdContent = ((System.Windows.Controls.Grid)(this.FindName("gdContent")));
            this.btnFolderUp = ((System.Windows.Controls.Border)(this.FindName("btnFolderUp")));
            this.imgNavBack = ((System.Windows.Controls.Image)(this.FindName("imgNavBack")));
            this.lblPageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("lblPageTitle")));
            this.lblNotification = ((System.Windows.Controls.TextBlock)(this.FindName("lblNotification")));
            this.btnShowEmptyFolders = ((System.Windows.Controls.TextBlock)(this.FindName("btnShowEmptyFolders")));
        }
    }
}
