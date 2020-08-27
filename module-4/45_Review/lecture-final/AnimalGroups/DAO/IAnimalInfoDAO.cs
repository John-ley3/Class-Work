using AnimalGroups.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalGroups.DAO
{
    public interface IAnimalInfoDAO
    {
        Animal GetAnimalInformation(string AnimalName);
    }
}
