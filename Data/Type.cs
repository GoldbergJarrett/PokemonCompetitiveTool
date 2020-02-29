using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitiveTool.Data
{
    public class Type
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string ImagePath { get; set; }
        public List<string> SuperEffective { get; set; }
        public List<string> NotVeryEffective { get; set; }
        public List<string> NoEffect { get; set; }
    }
}
