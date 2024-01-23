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

    public partial class venta : XPLiteObject
    {
        int fidventa;
        [Key(true)]
        public int idventa
        {
            get { return fidventa; }
            set { SetPropertyValue<int>(nameof(idventa), ref fidventa, value); }
        }
        DateTime ffecha;
        public DateTime fecha
        {
            get { return ffecha; }
            set { SetPropertyValue<DateTime>(nameof(fecha), ref ffecha, value); }
        }
        float fdescuento;
        public float descuento
        {
            get { return fdescuento; }
            set { SetPropertyValue<float>(nameof(descuento), ref fdescuento, value); }
        }
        int fcantidad;
        public int cantidad
        {
            get { return fcantidad; }
            set { SetPropertyValue<int>(nameof(cantidad), ref fcantidad, value); }
        }
        float fmonto_total;
        public float monto_total
        {
            get { return fmonto_total; }
            set { SetPropertyValue<float>(nameof(monto_total), ref fmonto_total, value); }
        }
        cliente fcliente_idcliente;
        [Association(@"ventaReferencescliente")]
        public cliente cliente_idcliente
        {
            get { return fcliente_idcliente; }
            set { SetPropertyValue<cliente>(nameof(cliente_idcliente), ref fcliente_idcliente, value); }
        }
        [Association(@"detalleReferencesventa")]
        public XPCollection<detalle> detalles { get { return GetCollection<detalle>(nameof(detalles)); } }
    }

}