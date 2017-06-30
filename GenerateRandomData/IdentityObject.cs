using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRandomData
{
    public class IdentityObject
    {
        public string NomeTabella { get; set; }
        public string NomeColonna { get; set; }
        public bool IsRowGuid { get; set; }
        public bool IsIdentity { get; set; }
        public string TipoDato { get; set; }
        public int MaxLenght { get; set; }
    }
}
