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
    
    public partial class Mensajeria
    {
        public Mensajeria()
        {
            this.Mensaje_Archivos = new HashSet<Mensaje_Archivos>();
        }
    
        public int IDMensaje { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IDFrom { get; set; }
        public int IDTo { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public bool Nuevo { get; set; }
        public Nullable<int> IDMensajePadre { get; set; }
        public bool EliminarFrom { get; set; }
        public bool EliminarTo { get; set; }
        public bool ArchivoFrom { get; set; }
        public bool ArchivoTo { get; set; }
        public Nullable<bool> NotificationView { get; set; }
    
        public virtual ICollection<Mensaje_Archivos> Mensaje_Archivos { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}