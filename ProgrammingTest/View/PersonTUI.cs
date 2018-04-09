using ProgrammingTestIDNetwork.Model.Implementation;
using System;
using System.Collections.Generic;

namespace ProgrammingTestIDNetwork.View
{
    /// <summary>
    /// The TUI
    /// </summary>
    public class PersonTUI
    {
        DataTransformer transformer = new DataTransformer();
        const string originalString = "(Name)John Doe\n(Age)20\n(City)Ashtabula, OH\n(Flags)NYN\n\n(Name)Jane Doe\n(Flags)YNY\n(City)N Kingsville, OH\n\n(Name)Sally Jones\n(Age)25\n(City)Paris\n(Flags)YYY";
        public void Run()
        {
            Console.WriteLine("Hello, Welcome to the Data Transformation exercise. Please enter 1 to run or anything else to exit.");
            string input = Console.ReadLine();
            if(input == "1")
            {
                transformer.Transform(originalString);
                WritePeopleToConsole((List<Person>)transformer.Transform(originalString));
                Console.WriteLine("");
                Console.WriteLine("Thank you for running me. Hit any key to exit");
                Console.ReadLine();
            }
        }
        private void WritePeopleToConsole(List<Person> people)
        {
            foreach(Person aPerson in people)
            {
                Console.WriteLine(aPerson.ToString());
            }
        }
    }
}
