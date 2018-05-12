using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1:
            string[] stringArray = { "this", "is", "an", "array", "made", "up", "of", "strings" };
            Console.WriteLine("Enter some text to add to each item in the string array:");
            string addedText = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + addedText;
                Console.WriteLine(stringArray[i]);
            }
            Console.ReadLine();

            //alternatively, using StringBuilder instead, since we're changing the length of each string:
            //in practice I would only use this if the original stringArray hadn't yet been modified by addedText:

            StringBuilder[] sbArray = new StringBuilder[8];
            Console.WriteLine("Enter some text to add to each item in the StringBuilder array:");
            string addedText2 = Console.ReadLine();

            for (int i = 0; i < sbArray.Length; i++)
            {
                sbArray[i] = new StringBuilder(stringArray[i]); //instantiate each StringBuilder within the array
                sbArray[i].Append(addedText2);
                Console.WriteLine(sbArray[i]);
            }
            Console.ReadLine();


            //2:
            for (int i = 10; i > sbArray.Length; i++)  //infinite loop
            {
                Console.WriteLine(Convert.ToString(i));
            }
            Console.ReadLine();


            //3 & 4:
            for (int i = 0; i < sbArray.Length; i++)  //non-infinite loop
            {
                Console.WriteLine(Convert.ToString(i));
            }
            Console.ReadLine();


            //5:
            for (int i = 0; i <= sbArray.Length; i++)
            {
                Console.WriteLine(Convert.ToString(i));
            }
            Console.ReadLine();


            //6, 7 & 8:
            List<string> dogBreeds = new List<string>() { "Saint Bernard", "Newfoundland", "Bernese Mountain Dog", "Golden Retriever", "Labrador", "Great Dane", "Great Pyrenees", "Leonberger" };
            Console.WriteLine("Enter text to search for in the list of dog breeds:");
            string search = Console.ReadLine();

            int noMatchCounter = 0;
            for (int j = 0; j < dogBreeds.Count; j++)
            {
                if (dogBreeds[j].Contains(search))
                {
                    Console.WriteLine(j);
                    break;
                }
                else
                {
                    noMatchCounter++;
                }
            }
            if (noMatchCounter == dogBreeds.Count)
            {
                Console.WriteLine("Your text does not appear anywhere in the list of dog breeds.");
            }
            Console.ReadLine();


            //9 & 10:
            List<string> pets = new List<string>() { "dog", "dog", "cat", "fish", "dog" };
            Console.WriteLine("Enter text to search for in the list of pets:");
            string searchPets = Console.ReadLine();

            int petsNoMatchCounter = 0;
            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i].Contains(searchPets))
                {
                    Console.WriteLine(Convert.ToString(i));
                }
                else
                {
                    petsNoMatchCounter++;
                }
            }
            if (petsNoMatchCounter == pets.Count)
            {
                Console.WriteLine("Your text does not appear anywhere in the list of pets.");
            }

            Console.ReadLine();


            //11:
            List<string> names = new List<string>() {"Chloe" , "Erik", "Amy", "Brad", "Erik", "Annabel", "Markus" };
            List<string> nameHolder = new List<string>(); //empty

            foreach (string name in names) {

                if (!nameHolder.Contains(name))
                {
                    Console.WriteLine(name + ": has not yet appeared in the list");
                }
                else
                {
                    Console.WriteLine(name + ": has already appeared in the list");
                }

                nameHolder.Add(name);
            }
            Console.ReadLine();
        }
    }
}
