//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArcanaTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Arcana_Id { get; set; }
    
        public virtual Arcana Arcana { get; set; }
    }
}
