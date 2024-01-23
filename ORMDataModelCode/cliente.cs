using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace expressApp.bdventa
{

    public partial class cliente
    {
        public cliente(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public string nombre_completo {
            get {
                return nombre + "" + apellido;
            }
        }
        
    }

}