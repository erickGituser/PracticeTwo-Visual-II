﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace expressApp.bdventa
{

    public partial class usuario : XPLiteObject
    {
        int fidusuario;
        [Key(true)]
        public int idusuario
        {
            get { return fidusuario; }
            set { SetPropertyValue<int>(nameof(idusuario), ref fidusuario, value); }
        }
        string flogin;
        [Indexed(Name = @"login_UNIQUE", Unique = true)]
        [Size(45)]
        public string login
        {
            get { return flogin; }
            set { SetPropertyValue<string>(nameof(login), ref flogin, value); }
        }
        string fclave;
        [Size(45)]
        public string clave
        {
            get { return fclave; }
            set { SetPropertyValue<string>(nameof(clave), ref fclave, value); }
        }
        string fnombre;
        [Size(45)]
        public string nombre
        {
            get { return fnombre; }
            set { SetPropertyValue<string>(nameof(nombre), ref fnombre, value); }
        }
        string frol;
        [Size(45)]
        public string rol
        {
            get { return frol; }
            set { SetPropertyValue<string>(nameof(rol), ref frol, value); }
        }
    }

}
