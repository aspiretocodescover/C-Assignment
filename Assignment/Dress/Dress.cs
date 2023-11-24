using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Dress
{ 
    public class Dress
    {
        // Properties
        public string Color { get; set; }
        public string Style { get; set; }
        public int Size { get; set; }
        public bool IsFormal { get; set; }

        // Constructor
        public Dress(string color, string style, int size, bool isFormal)
        {
            Color = color;
            Style = style;
            Size = size;
            IsFormal = isFormal;
        }

        // Methods
        public void DisplayInformation()
        {
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Style: {Style}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Formal: {(IsFormal ? "Yes" : "No")}");
        }

        public void Wash()
        {
            Console.WriteLine("Dress is being washed.");
            // Additional code for washing the dress can be added here.
        }

        public void Wear()
        {
            Console.WriteLine("Dress is being worn.");
            // Additional code for wearing the dress can be added here.
        }
    }

}
