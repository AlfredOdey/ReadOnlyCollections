using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyCollections
{
    internal class Program
    {
        /*Question 1: Read-Only Collections
        Create a list of strings with the values
        {"red", "green", "blue"}.
        Convert the list to a read-only collection.
        Attempt to add another element to the
        read-only collection (expect an error),
        but add a comment on this one after testing
        */
        static void Main(string[] args)
        {
            List<string> listOfColors = new List<string>
            {"red", "green", "blue"};

            //Code to convert the list, listOfColors, to a read-only list.
            IEnumerable<string> readOnlyListOfColors = listOfColors.AsReadOnly();

            readOnlyListOfColors.Add("orange"); //Error showing that read-only list cannot be modified

            Console.WriteLine(readOnlyListOfColors);
        }
    }
}
