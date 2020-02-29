using CompetitiveTool.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Type = CompetitiveTool.Data.Type;


namespace CompetitiveTool.Implementations
{
    public class BasicTypes2: ITypeService
    {
        private List<Type> _typesList = new List<Type>()
        {
            new Type
            {
                Id = 1,
                TypeName = "Normal",
                ImagePath = "Resources/Normal.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            },
            new Type
            {
                Id = 2,
                TypeName = "Fire",
                ImagePath = "Resources/Fire.png",
                SuperEffective = new List<string>(){"Grass", "Ice", "Bug", "Steel"},
                NotVeryEffective = new List<string>(){"Fire", "Water", "Rock", "Dragon"},
                NoEffect = new List<string>(){""}
            },
            new Type
            {
                Id = 3,
                TypeName = "Water",
                ImagePath = "Resources/Water.png",
                SuperEffective = new List<string>(){"Fire", "Ground"},
                NotVeryEffective = new List<string>(){"Water", "Grass", "Dragon"},
                NoEffect = new List<string>(){""}
            },
            new Type
            {
                Id = 4,
                TypeName = "Electric",
                ImagePath = "Resources/Electric.png",
                SuperEffective = new List<string>(){"Water", "Fly"},
                NotVeryEffective = new List<string>(){"Electric", "Grass", "Dragon"},
                NoEffect = new List<string>(){"Ground"}
            },
            //NOTE: Update effectiveness on the remaining lists
            new Type
            {
                Id = 5,
                TypeName = "Grass",
                ImagePath = "Resources/Grass.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            },
            new Type
            {
                Id = 6,
                TypeName = "Ice",
                ImagePath = "Resources/Ice.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            },
            new Type
            {
                Id = 7,
                TypeName = "Fighting",
                ImagePath = "Resources/Fighting.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            },
            new Type
            {
                Id = 8,
                TypeName = "Poison",
                ImagePath = "Resources/Poison.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            },
            new Type
            {
                Id = 9,
                TypeName = "Ground",
                ImagePath = "Resources/Ground.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            },
            new Type
            {
                Id = 10,
                TypeName = "Flying",
                ImagePath = "Resources/Flying.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            },
            new Type
            {
                Id = 11,
                TypeName = "Psychic",
                ImagePath = "Resources/Psychic.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            },
            new Type
            {
                Id = 12,
                TypeName = "Bug",
                ImagePath = "Resources/Bug.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            },
            new Type
            {
                Id = 13,
                TypeName = "Rock",
                ImagePath = "Resources/Rock.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            },
            new Type
            {
                Id = 14,
                TypeName = "Ghost",
                ImagePath = "Resources/Ghost.png",
                SuperEffective = new List<string>(){""},
                NotVeryEffective = new List<string>(){"Rock", "Steel"},
                NoEffect = new List<string>(){"Ghost"}
            }
        };

        public List<Type> GetSuperEffectiveAgainst(string type)
        {
            throw new NotImplementedException();
        }

        public List<Type> GetTypes()
        {
            return _typesList;
        }
    }
}
