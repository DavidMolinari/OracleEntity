//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OracleEntityF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROJET
    {
        public PROJET()
        {
            this.EMPLOYEs = new HashSet<EMPLOYE>();
        }
    
        public string CODEPROJET { get; set; }
        public string NOMPROJET { get; set; }
        public System.DateTime DEBUTPROJ { get; set; }
        public System.DateTime FINPREVUE { get; set; }
        public string NOMCONTACT { get; set; }
    
        public virtual ICollection<EMPLOYE> EMPLOYEs { get; set; }
    }
}