﻿#pragma checksum "..\..\nuevoMaestro.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "536DA794DC7C80E0C536C603FDC544B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace ESNAJ {
    
    
    /// <summary>
    /// nuevoMaestro
    /// </summary>
    public partial class nuevoMaestro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\nuevoMaestro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNombre;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\nuevoMaestro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCorreo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\nuevoMaestro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbContraseña;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\nuevoMaestro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbConfirmaContra;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\nuevoMaestro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAgregar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\nuevoMaestro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btRegresar;
        
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
            System.Uri resourceLocater = new System.Uri("/ESNAJ;component/nuevomaestro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\nuevoMaestro.xaml"
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
            this.tbNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbCorreo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbContraseña = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.tbConfirmaContra = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.btAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\nuevoMaestro.xaml"
            this.btAgregar.Click += new System.Windows.RoutedEventHandler(this.btAgregar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\nuevoMaestro.xaml"
            this.btRegresar.Click += new System.Windows.RoutedEventHandler(this.btRegresar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

