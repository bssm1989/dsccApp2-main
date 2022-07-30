using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBlazorApp
{
    public class IndexDbIndexAttribute : Attribute
    {
        public bool Unique { get; set; } = false;
        public string Name { get; set; }
    }
}
