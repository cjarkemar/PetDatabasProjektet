using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDatabasProjekt
{
    internal class Pet
    {
       
        
        public string Type { get; set; }
        public string Size { get; set; } 
        public string Color { get; set; } 
        public string Breed { get; set; }   
        public string Phonenumber { get; set; }
        




        public Pet (string type, string size, string color, string breed, string phonenumber)
        {
            

           
            Type = type;
            Size = size;
            Color = color;
            Breed = breed;
            Phonenumber = phonenumber;
            


        }





    }
}
