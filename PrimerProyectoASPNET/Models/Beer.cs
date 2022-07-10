using System;
using System.Collections.Generic;

namespace PrimerProyectoASPNET.Models
{
    public partial class Beer
    {
        public int BeerId { get; set; }
        public int? BrandId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Brand? Brand { get; set; }
    }
}
