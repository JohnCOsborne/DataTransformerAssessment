using System;

namespace ProgrammingTestIDNetwork
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public bool IsFemale { get; set; }

        public bool IsStudent { get; set; }

        public bool IsEmployee { get; set; }

        public override string ToString()
        {
            return String.Format("{0} [{1}{2}]\n\tCity : {3}\n\tState : {4}\n\tStudent : {5}\n\tEmployee : {6}",
                Name,(Age == 0 ? "" : Age.ToString() + ","), (IsFemale ? "Female" : "Male"), City,(string.IsNullOrEmpty(State) ? "N/A" : State),(IsStudent ? "Yes" : "No"), (IsEmployee ? "Yes" : "No"));
        }
    }
}
