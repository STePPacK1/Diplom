﻿#pragma checksum "..\..\..\Pages\PLPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BFAB4A45C9D613BA6926DB6998A9EF1D06B4B4222A537053F617DDB42E8D21B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfAppP.T_0._1_.Pages;


namespace WpfAppP.T_0._1_.Pages {
    
    
    /// <summary>
    /// PLPage
    /// </summary>
    public partial class PLPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 39 "..\..\..\Pages\PLPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_PL;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\PLPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_go;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Pages\PLPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_descendingID;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\PLPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_ascendingID;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Pages\PLPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_descending;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Pages\PLPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button b_ascending;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Pages\PLPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_search;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Pages\PLPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_PL;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppP.T(0.1);component/pages/plpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PLPage.xaml"
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
            this.tb_PL = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.b_go = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Pages\PLPage.xaml"
            this.b_go.Click += new System.Windows.RoutedEventHandler(this.b_go_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.b_descendingID = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\Pages\PLPage.xaml"
            this.b_descendingID.Click += new System.Windows.RoutedEventHandler(this.b_descendingID_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.b_ascendingID = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Pages\PLPage.xaml"
            this.b_ascendingID.Click += new System.Windows.RoutedEventHandler(this.b_ascendingID_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.b_descending = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\Pages\PLPage.xaml"
            this.b_descending.Click += new System.Windows.RoutedEventHandler(this.b_descending_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.b_ascending = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\Pages\PLPage.xaml"
            this.b_ascending.Click += new System.Windows.RoutedEventHandler(this.b_ascending_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tb_search = ((System.Windows.Controls.TextBox)(target));
            
            #line 86 "..\..\..\Pages\PLPage.xaml"
            this.tb_search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lb_PL = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 106 "..\..\..\Pages\PLPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.b_edit_Click);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 107 "..\..\..\Pages\PLPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.b_delete_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

