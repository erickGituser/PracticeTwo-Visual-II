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

    public partial class producto : XPLiteObject
    {
        int fidproducto;
        [Key(true)]
        public int idproducto
        {
            get { return fidproducto; }
            set { SetPropertyValue<int>(nameof(idproducto), ref fidproducto, value); }
        }
        string fnombreprod;
        [Size(45)]
        public string nombreprod
        {
            get { return fnombreprod; }
            set { SetPropertyValue<string>(nameof(nombreprod), ref fnombreprod, value); }
        }
        DateTime ffecha_vence;
        public DateTime fecha_vence
        {
            get { return ffecha_vence; }
            set { SetPropertyValue<DateTime>(nameof(fecha_vence), ref ffecha_vence, value); }
        }
        float fprecio;
        public float precio
        {
            get { return fprecio; }
            set { SetPropertyValue<float>(nameof(precio), ref fprecio, value); }
        }
        int festante;
        public int estante
        {
            get { return festante; }
            set { SetPropertyValue<int>(nameof(estante), ref festante, value); }
        }
        categoria fcategoria_idcategoria;
        [Association(@"productoReferencescategoria")]
        public categoria categoria_idcategoria
        {
            get { return fcategoria_idcategoria; }
            set { SetPropertyValue<categoria>(nameof(categoria_idcategoria), ref fcategoria_idcategoria, value); }
        }
        [Association(@"detalleReferencesproducto")]
        public XPCollection<detalle> detalles { get { return GetCollection<detalle>(nameof(detalles)); } }
    }

}
