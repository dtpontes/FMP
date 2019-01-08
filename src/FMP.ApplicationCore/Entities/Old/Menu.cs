using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.ApplicationCore.Entities
{
    public class Menu
    {
        public int MenuId { get; set; }

        public string Titulo { get; set; }

        public int? MenuIdPai { get; set; }

        public ICollection<Menu> SubMenu { get; set; }
    }
}
