using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Shop
    {
        public string Name { get; set; }
        public string Addresse { get; set; }

        public Shop(string name, string addresse)
        {
            Name = name;
            Addresse = addresse;
        }

        public void DisplayTitle()
        {

            Console.WriteLine($"\n Wellcome to shop {Name}");
            Console.WriteLine($"\n Adresse: {Addresse}");
            for (int i=0; i<30; i++)
            {
                Console.Write("=");
            }
        }

    }
}
