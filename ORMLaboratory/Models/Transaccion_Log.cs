//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORMLaboratory.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaccion_Log
    {
        public int IDLog { get; set; }
        public int IDTransaccion { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IDUsuario { get; set; }
        public string Campo { get; set; }
        public byte IDAccion { get; set; }
        public string ValorInicial { get; set; }
        public string ValorFinal { get; set; }
    
        public virtual Accion Accion { get; set; }
        public virtual Transaccion Transaccion { get; set; }
        public virtual User User { get; set; }
    }
}
