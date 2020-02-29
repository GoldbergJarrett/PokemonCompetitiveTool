using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Type = CompetitiveTool.Data.Type;

namespace CompetitiveTool.Interfaces
{
    public interface ITypeService
    {
        public List<Type> GetTypes();

        public List<Type> GetSuperEffectiveAgainst(string type);
    }
}
