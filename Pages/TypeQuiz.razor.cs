using CompetitiveTool.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Type = CompetitiveTool.Data.Type;

namespace CompetitiveTool.Pages
{
    public partial class TypeQuiz :  ComponentBase
    {
        [Inject]
        public ITypeService TypeService  { get; set; }

        private Random rnd = new Random();

        public List<Type> Types { get; set; }
        public List<Type> TypesSuperEffectiveAgainst { get; set; }
        public List<Type> CurrentlySelected { get; set; } = new List<Type>();

        public List<string> CorrectResponses { get; set; } = new List<string>();
        public List<string> IncorrectResponses { get; set; } = new List<string>();
        public bool HasResponded { get; set; }

        public bool IsCorrect { get; set; }
        public bool HasAnswered { get; set; }

        public string CurrentType { get; set; }
        public Type CurrentObjType { get; set; }

        //int choice1 = Rnd.Next(1, 19);
        //int choice2 = Rnd.Next(1, 19);
        //int choice3 = Rnd.Next(1, 19);
        //int choice4 = Rnd.Next(1, 19);
        //int choice5 = Rnd.Next(1, 19);
        //int choice6 = Rnd.Next(1, 19);

        //public static Random Rnd { get => rnd; set => rnd = value; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            GenerateRandomTypes();
        }

        public void GenerateRandomTypes(string type = null)
        {
            if(type == null)
            {
                while (type == "Normal" || type == null)
                {
                    int choice = rnd.Next(0, 18);

                    switch (choice)
                    {
                        case 0:
                            type = "Bug";
                            break;
                        case 1:
                            type = "Dark";
                            break;
                        case 2:
                            type = "Dragon";
                            break;
                        case 3:
                            type = "Electric";
                            break;
                        case 4:
                            type = "Fairy";
                            break;
                        case 5:
                            type = "Fighting";
                            break;
                        case 6:
                            type = "Fire";
                            break;
                        case 7:
                            type = "Flying";
                            break;
                        case 8:
                            type = "Ghost";
                            break;
                        case 9:
                            type = "Grass";
                            break;
                        case 10:
                            type = "Ground";
                            break;
                        case 11:
                            type = "Ice";
                            break;
                        case 12:
                            type = "Normal";
                            break;
                        case 13:
                            type = "Poison";
                            break;
                        case 14:
                            type = "Psychic";
                            break;
                        case 15:
                            type = "Rock";
                            break;
                        case 16:
                            type = "Steel";
                            break;
                        case 17:
                            type = "Water";
                            break;
                    }
                }
            }

            CurrentType = type;

            List<Type> tempTypes = TypeService.GetTypes();

            List<int> selectedSet = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                int choice = rnd.Next(0, 18);
                while(selectedSet.Contains(choice)) choice = rnd.Next(0, 18);
                selectedSet.Add(choice);
            }



            List<Type> types = new List<Type>();

            foreach(int num in selectedSet)
            {
                types.Add(tempTypes[num]);
            }

            CurrentObjType = TypeService.GetTypeByName(type);

            Type temp2 = null;

            if(CurrentObjType.SuperEffective.Count > 0)
            {
                temp2 = TypeService.GetTypeByName(CurrentObjType.SuperEffective[0]);
            }
            else
            {
                temp2 = new Type {  };
            }

            types.Add(temp2);

            Types = types;

            TypesSuperEffectiveAgainst = TypeService.GetSuperEffectiveAgainst(type);
        }

        public void Guess(Type type)
        {
            Console.WriteLine($"The type is {type.TypeName}");

            List<Type> isContained = CurrentlySelected.Where(x => x.TypeName.CompareTo(type.TypeName) == 0).ToList();

            if (isContained.Count() > 0)
            {
                CurrentlySelected.Remove(isContained[0]);
            }
            else
            {
                CurrentlySelected.Add(type);
            }

            Console.WriteLine("Currently Selected types:");
            foreach (var selection in CurrentlySelected)
            {
                Console.WriteLine($"    {selection.TypeName}");
            }
        }

        public void Submit()
        {
            HasResponded = true;

            foreach (var type in CurrentlySelected)
            {
                if (CurrentObjType.SuperEffective.Contains(type.TypeName))
                {
                    Console.WriteLine($"SUPER EFFECTIVE");
                    CorrectResponses.Add($"<span style='color: orange;'>{CurrentObjType.TypeName}</span> was super effective against <span style='color: orange;'>{type.TypeName}</span>!");
                }
                else
                {
                    Console.WriteLine($"NOT SUPER EFFECTIVE");
                    IncorrectResponses.Add($"<span style='color: orange;'>{CurrentObjType.TypeName}</span> was NOT super effective against <span style='color: orange;'>{type.TypeName}</span>!");
                }
            }
        }
    }
}
