using ProgrammingTestIDNetwork.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingTestIDNetwork.Model.Implementation
{
    public class DataTransformer : ITransformer
    {
        const string NameConst = "Name";
        const string AgeConst = "Age";
        const string CityConst = "City";
        const string FlagsConst = "Flags";
        public IEnumerable<object> Transform(string dataToTransform)
        {
            return ParseStringForPeople(dataToTransform);
        }

        private List<Person> ParseStringForPeople(string stringToParse)
        {
            List<Person> peopleResult = new List<Person>();

            List<string> peopleStrings = stringToParse.Split(new string[] { "\n\n" }, StringSplitOptions.None).ToList();
            foreach (string personString in peopleStrings)
            {
                peopleResult.Add(CreatePerson(personString));
            }

            return peopleResult;
        }

        private Person CreatePerson(string personString)
        {
            Person aPerson = new Person();

            List<string> keyValueStrings = personString.Split(new string[] { "\n" }, StringSplitOptions.None).ToList();
            foreach (string personInfo in keyValueStrings)
            {
                UpdatePersonInfo(ref aPerson, personInfo);
            }

            return aPerson;
        }

        private void UpdatePersonInfo(ref Person person, string personInfo)
        {
            string[] keyAndValue = personInfo.Split(')');
            string key = keyAndValue[0].Substring(1);
            string value = keyAndValue[1];
            switch (key)
            {
                case NameConst:
                    person.Name = value;
                    break;
                case AgeConst:
                    person.Age = int.Parse(value);
                    break;
                case CityConst:
                    string[] cityAndState = value.Split(',');
                    if (cityAndState.Length > 1)
                    {
                        person.City = cityAndState[0];
                        person.State = cityAndState[1];
                    }
                    else
                    {
                        person.City = value;
                    }
                    break;
                case FlagsConst:
                    person.IsFemale = (value[0] == 'Y' ? true : false);
                    person.IsStudent = (value[1] == 'Y' ? true : false);
                    person.IsEmployee = (value[2] == 'Y' ? true : false);
                    break;
            }
        }
    }
}
