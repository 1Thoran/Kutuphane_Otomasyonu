//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphane
{
    using System;
    using System.Collections.Generic;
    
    public partial class islem
    {
        public int islemID { get; set; }
        public int uyeID { get; set; }
        public Nullable<System.DateTime> sonTarihi { get; set; }
        public Nullable<int> adminID { get; set; }
        public Nullable<int> ISSN { get; set; }
        public Nullable<int> ISBN { get; set; }
        public string emanetDurumu { get; set; }
        public Nullable<System.DateTime> alisTarih { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual dergi dergi { get; set; }
        public virtual kitap kitap { get; set; }
        public virtual uye uye { get; set; }
    }
}