using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public abstract class FarmAnimal : ISingable
    {       
        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; }
        public bool IsSleeping { get; set; }
        public string Sound { get; set; }
        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        public FarmAnimal(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// The noise made when the farm animal makes a sound.
        /// </summary>
        /// <returns></returns>
        public string MakeSoundOnce()
        {
            if(IsSleeping)
            {
                return "Zzzzz....";
            }
            return Sound;
        }

        /// <summary>
        /// The noise made when the farm animal makes its sound twice.
        /// </summary>
        /// <returns></returns>
        public string MakeSoundTwice()
        {
            if (IsSleeping)
            {
                return "Zzzzz....";
            }
            return Sound + " " + Sound;
        }

        public void ToggleSleeping()
        {
            IsSleeping = !IsSleeping;
        }

        public abstract string Eat();
    }
}
