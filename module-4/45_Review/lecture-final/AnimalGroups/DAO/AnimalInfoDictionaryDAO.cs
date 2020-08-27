using AnimalGroups.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalGroups.DAO
{
    public class AnimalInfoDictionaryDAO : IAnimalInfoDAO
    {
        private Dictionary<string, string> animals = new Dictionary<string, string>()
            {
                {"rhino", "Crash" },
                {"giraffe", "Tower" },
                {"elephant", "Herd" },
                {"lion", "Pride" },
                {"crow", "Murder" },
                {"pigeon", "Kit" },
                {"flamingo", "Pat" },
                {"deer", "Herd" },
                {"dog", "Pack" },
                {"crocodile", "Float" },
            };
        public Animal GetAnimalInformation(string AnimalName = "unknown")
        {
            Animal output = new Animal();
            output.Name = AnimalName;
            output.GroupName = animals.ContainsKey(AnimalName.ToLower()) ? animals[AnimalName.ToLower()] : "unknown";
            return output;
        }
    }
}
