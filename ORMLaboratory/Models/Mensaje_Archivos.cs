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
    
    public partial class Mensaje_Archivos
    {
        public int IDArchivo { get; set; }
        public int IDMensaje { get; set; }
        public string Nombre { get; set; }
        public string NombreFisico { get; set; }
    
        public virtual Mensajeria Mensajeria { get; set; }
    }
}
