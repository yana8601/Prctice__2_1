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
            Sweets a = new Sweets("pchelka", 10f, 3f);

            Sweets b = new Sweets("barbaris", 8f, 2.5f);

            Chokolates c = new Chokolates("mishka", 15f, 5f, 0.52f, true, 10);

            ChokolatesWithFilling d = new ChokolatesWithFilling("So vcusom koniaca", 15f, 3f, 0.75f, true, 10, 8);

            ChokolatesWithFilling e = new ChokolatesWithFilling("Vechirniy kiyv", 20f, 4f, 0.52f, true, 8, 10);

           



            Console.ReadKey();
        }
    }

   public class Sweets
    {
        public string name;
        public float mass;
        public float sugarPercent;

        public Sweets(string name, float mass, float sugar)
        {
            Console.WriteLine($"sweet {name}");
            Console.WriteLine();
        }

    }

    public class Chokolates : Sweets
    {
        public float cacaoPercent;
        public bool isPakcedByBox;
        public int maxNomberInBox;
        public float boxMass = 0;


        public Chokolates(string name, float mass, float sugar, float cacaoPercent, bool isPakcedByBox, int maxNomberInBox)
            : base(name, mass, sugar) 
        {
            if (isPakcedByBox)
            {
                boxMass = mass * maxNomberInBox;

                Console.WriteLine($"Box of {name} chokolates has mass near {boxMass}g");
            }
            else
            {
                Console.Write($"sweet {name} without boxes");
            }

            Console.WriteLine();
        }
       
       
    }

    public class ChokolatesWithFilling : Chokolates
    {
        public float fillingMass;
   
        public ChokolatesWithFilling(string name, float mass, float sugar, float cacaoPercent, bool isPakcedByBox, int maxNomberInBox, float fillingMass)
            : base(name, mass, sugar, cacaoPercent, isPakcedByBox, maxNomberInBox)
        {
            if (fillingMass >= mass)
            {
                fillingMass = mass * 0.8f;
            }

        }

    }
}
