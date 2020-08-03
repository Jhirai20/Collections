using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays:
                // Create an array to hold integer values 0 through 9
                    int[] numArr = new int[] {0,1,2,3,4,5,6,7,8,9};
                // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
                    string[] strArr = new string[]{"Tim","Martin","Nikki","Sara"};
                // Create an array of length 10 that alternates between true and false values, starting with true
                    bool[] boolArr = new bool[10];
                    for (int i = 0; i < boolArr.Length; i++)
                    {
                        if(i%2==0)
                        {
                            boolArr[i] = true;
                        }
                        else
                        {
                            boolArr[i] = false;
                        }
                    }
            // List of Flavors
                // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
                    List<string> flavors = new List<string>();
                    flavors.Add("Vanilla");
                    flavors.Add("Chocolate");
                    flavors.Add("Strawberry");
                    flavors.Add("Cookie Dough");
                    flavors.Add("Mint Chocolate");
                // Output the length of this list after building it
                    Console.WriteLine($"There are {flavors.Count} flavors!");
                // Output the third flavor in the list, then remove this value
                    Console.WriteLine(flavors[2]);
                    flavors.Remove(flavors[2]);
                // Output the new length of the list (It should just be one fewer!)
                    Console.WriteLine($"There are now {flavors.Count} flavors!");
            // User Info Dictionary
                // Create a dictionary that will store both string keys as well as string values
                    Dictionary<string,string> profile = new Dictionary<string, string>();
                // Add key/value pairs to this dictionary where:
                    // each key is a name from your names array
                    // each value is a randomly select a flavor from your flavors list.
                    Random random=new Random();
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        profile.Add($"{strArr[i]}",$"{flavors[random.Next(0,4)]}");
                    }
                // Loop through the dictionary and print out each user's name and their associated ice cream flavor
                    foreach (var item in profile)
                    {
                        Console.WriteLine(item);
                    }
        }
    }
}
