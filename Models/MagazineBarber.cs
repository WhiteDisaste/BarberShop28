//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarberShop28.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MagazineBarber
    {
        public int Id { get; set; }
        public int IdServices { get; set; }
        public int IdJobTitle { get; set; }
        public int IdStaff { get; set; }
        public int IdClients { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        public virtual Services Services { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
