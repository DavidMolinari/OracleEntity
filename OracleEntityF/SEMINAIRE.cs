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
    
    public partial class SEMINAIRE
    {
        public SEMINAIRE()
        {
            this.INSCRITs = new HashSet<INSCRIT>();
        }
    
        public string CODESEMI { get; set; }
        public string CODECOURS { get; set; }
        public System.DateTime DATEDEBUTSEM { get; set; }
    
        public virtual COUR COUR { get; set; }
        public virtual ICollection<INSCRIT> INSCRITs { get; set; }
    }
}
