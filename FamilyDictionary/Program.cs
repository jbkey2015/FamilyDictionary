using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Susan" }, { "age", "46" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "James" }, { "age", "47" } });
            myFamily.Add("brother2", new Dictionary<string, string>() { { "name", "Robert" }, { "age", "51" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "John" }, { "age", "74" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Patricia" }, { "age", "71" } });

            foreach (var member in myFamily)
            {
                var printString = $"{member.Value["name"]} is my { member.Key } and is {member.Value["age"]} years old.";
                Console.WriteLine(printString);
            }
        }
    }
}
