using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace SampleCodeAnalyzerProject2
{

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
    class FolderStructureViewModel
    {
        public string defaultAssociationContractTypeName { get; set; }
        public FolderStructure folderStructure { get; set; }
    }
    class FolderStructure
    {
        [JsonIgnore]
        public string parentName { get; set; }

        public string displayName { get; set; }
        public string name { get; set; }
        public Guid id { get; set; }
        public List<FolderStructure> items { get; set; }
    }
    public class Program
    {
        static List<Person> people = new List<Person>();
        private static int mappingRowCount;
        public int Max(int a, int b)
        {
            return a > a ? a : b;
        }
        static void Main()
        {
            string password ="pwd-";
            string firstname = null;
            int? number1 =null;
            string lastname = Console.ReadLine();
            var fullname = string.Format("{0} {1}", firstname,number1);
            Console.WriteLine("My name is ", fullname);
            
            object myObject1 = null;
            string myString1 = (string)myObject1; // my string1 will be null
            object myObject2 = null;
            string myString2 = myObject1 as string;
            List<string> distributionGroups = new List<string>();
            Guid.TryParse(null, out Guid refID);
            
            
            string convertStr = Convert.ToString(myString1);
            string directStr = myString1.ToString(); 

            var amendments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<dynamic>>("");
            distributionGroups.Add("ab");
            distributionGroups.Add("abc");
            distributionGroups.Add("abcz");
            if (distributionGroups.Where(x => x == "n").Any())
            {

                Console.WriteLine("Inside If ");
            }
            distributionGroups?.Remove("abc");
            foreach (var amendment in amendments)
            {
                Console.WriteLine("HELOE" + amendment);

            }
            foreach (var distributionGroup in distributionGroups)
            {
                Console.WriteLine("HELOE" + distributionGroup);
            }
            Console.WriteLine("My name is {0},{1}", firstname);
            Console.WriteLine($"User fulle name{firstname} {lastname}");
            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Add a person");
                Console.WriteLine("2. Search for a person by email");
                Console.WriteLine("3. Update person details");
                Console.WriteLine("4. Remove a person");
                Console.WriteLine("5. Show all people");
                Console.WriteLine("6. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddPerson();
                        break;
                    case 2:
                        SearchPersonByEmail();
                        break;
                    case 3:
                        UpdatePerson();
                        break;
                    case 4:
                        RemovePerson();
                        break;
                    case 5:
                        ShowAllPeople();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddPerson()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            var person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            people.Add(person);
            Console.WriteLine("Person added successfully!");
        }
        public JObject ConvertToObject(string jsonString)
        {
            // Deserialize the JSON string to a JObject
            JObject jsonObject = JObject.Parse(jsonString);
            int[] args = { 1, 2, 3 };
            int firstnumber = 1;
            int secondNumber = args[firstnumber];
            var result = jsonObject["must"];
            var res1 = jsonObject[firstnumber];
            return jsonObject;
        }
        public void Method1(List<int> numbers, int? choice)
        {
            if (choice != null && numbers.Any())
            {
                Console.WriteLine("Trigger CS warning Rule");
            }
            if (numbers != null && numbers.Any())
            {
                Console.WriteLine("Number present");
            }
            if (numbers.Any())
            {
                Console.WriteLine("Trigger CS warning Rule");
            }
        }
        static void SearchPersonByEmail()
        {
            Console.WriteLine("Enter the email to search:");
            string searchEmail = Console.ReadLine();

            var foundPerson = people.FirstOrDefault(person => person.Email.Equals(searchEmail, StringComparison.OrdinalIgnoreCase));

            if (foundPerson != null)
            {
                Console.WriteLine($"Person found:");
                Console.WriteLine($"First Name: {foundPerson.FirstName}");
                Console.WriteLine($"Last Name: {foundPerson.LastName}");
                Console.WriteLine($"Email: {foundPerson.Email}");
            }
            else
            {
                Console.WriteLine("Person not found.");
            }
        }

        static void UpdatePerson()
        {
            Console.WriteLine("Enter the email of the person to update:");
            string emailToUpdate = Console.ReadLine();

            var personToUpdate = people.FirstOrDefault(person => person.Email.Equals(emailToUpdate, StringComparison.OrdinalIgnoreCase));

            
                Console.WriteLine("Enter new First Name:");
            string newFirstName = Console.ReadLine();
            Console.WriteLine("Enter new Last Name:");
            string newLastName = Console.ReadLine();

            personToUpdate.FirstName = newFirstName;
            personToUpdate.LastName = newLastName;
            Console.WriteLine("Person details updated successfully!");
           
        }

        static void RemovePerson()
        {
            Console.WriteLine("Enter the email of the person to remove:");
            string emailToRemove = Console.ReadLine();

            var personToRemove = people.FirstOrDefault(person => person.Email.Equals(emailToRemove, StringComparison.OrdinalIgnoreCase));

            if (personToRemove != null)
            {
                people.Remove(personToRemove);
                Console.WriteLine("Person removed successfully!");
            }
            else
            {
                Console.WriteLine("Person not found.");
            }
        }

        static void ShowAllPeople()
        {
            Console.WriteLine("All People:");
            foreach (var person in people)
            {
                Console.WriteLine($"First Name: {person.FirstName}");
                Console.WriteLine($"Last Name: {person.LastName}");
                Console.WriteLine($"Email: {person.Email}");
                Console.WriteLine("--------------");
            }
        }
    }

}
