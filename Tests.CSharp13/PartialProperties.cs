using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.CSharp13
{
    internal partial class PartialProperties
    {
        // Declaring declaration
        public partial string Name { get; set; }
    }

    internal partial class PartialProperties
    {
        // implementation declaration:
        private string _name;
        public partial string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
