﻿#pragma checksum "..\..\..\windows\win_EXP.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "33D662EE8C8862B2E901D001E7CB52753A163774B7DF10A10DF3E3EA633076EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MethApp;
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


namespace MethApp {
    
    
    /// <summary>
    /// win_EXP
    /// </summary>
    public partial class win_EXP : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\windows\win_EXP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newobj_bt;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\windows\win_EXP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delobj_bt;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\windows\win_EXP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button savels_bt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\windows\win_EXP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button return_bt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\windows\win_EXP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datag;
        
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
            System.Uri resourceLocater = new System.Uri("/MethApp;component/windows/win_exp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\win_EXP.xaml"
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
            
            #line 8 "..\..\..\windows\win_EXP.xaml"
            ((MethApp.win_EXP)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.newobj_bt = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\windows\win_EXP.xaml"
            this.newobj_bt.Click += new System.Windows.RoutedEventHandler(this.Newobj_bt_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.delobj_bt = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\windows\win_EXP.xaml"
            this.delobj_bt.Click += new System.Windows.RoutedEventHandler(this.Delobj_bt_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.savels_bt = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\windows\win_EXP.xaml"
            this.savels_bt.Click += new System.Windows.RoutedEventHandler(this.Savels_bt_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.return_bt = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\windows\win_EXP.xaml"
            this.return_bt.Click += new System.Windows.RoutedEventHandler(this.Return_bt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.datag = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
