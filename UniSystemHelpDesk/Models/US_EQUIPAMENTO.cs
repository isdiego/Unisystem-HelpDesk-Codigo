//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniSystemHelpDesk.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class US_EQUIPAMENTO
    {
        public US_EQUIPAMENTO()
        {
            this.US_CHAMADOS = new HashSet<US_CHAMADOS>();
        }
    
        public int ID_EQUIPAMENTO { get; set; }
        public string EQUIPAMENTO { get; set; }
        public int PRIORIDADE { get; set; }
        public Nullable<int> ID_TIPO_EQUIPAMENTO { get; set; }
    
        public virtual ICollection<US_CHAMADOS> US_CHAMADOS { get; set; }
        public virtual US_TIPO_EQUIPAMENTO US_TIPO_EQUIPAMENTO { get; set; }
    }
}