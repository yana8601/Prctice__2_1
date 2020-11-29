using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prctice__2_1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Sweets
    {
        public string name;
        public float mass;
        public float sugarPercent;
    
    }

    class Chokolates : Sweets
    {
        public float cacaoPercent;
        public bool isPakcedByBox;
        public int maxNomberInBox;
        public float boxMass;

        public void Package()
        {
      
            if (isPakcedByBox)
            {
                boxMass = mass * maxNomberInBox;
                Console.WriteLine($"Box of this chokolates has mass near {boxMass}");
            }
        }
    }


    enum Filling { Berries, Jelly,Jam,WhiteChoko }
    class ChokolatesWithFilling : Chokolates
    {
        public float fillingMass;
        public Filling filling;
        public void CheckMass()
        {
            if (fillingMass >= mass)
            {
                fillingMass = mass*0.8f;
            }
        }
    }
}
