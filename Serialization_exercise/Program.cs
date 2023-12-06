using Newtonsoft.Json;
using System.Text;

namespace Serialization_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "John",
                LastName = "Smith",
                Age = 20,
                Weight = 78
            };

            ToSerialize(person);
        }

        static void ToSerialize(Person person)
        {
            var serialized = JsonConvert.SerializeObject(person);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(serialized);

            byte[] binaryData = Encoding.UTF8.GetBytes(serialized);
            Console.WriteLine("\nSerialized Binary from JSON:");
            Console.WriteLine(BitConverter.ToString(binaryData).Replace("-", ""));

            serialized = Encoding.UTF8.GetString(binaryData);
            Console.WriteLine("\nDeserialized JSON from Binary:");
            Console.WriteLine(serialized);

            var deserializedPerson = JsonConvert.DeserializeObject<Person>(serialized);
            if (deserializedPerson != null)
            {
                Console.WriteLine("\nDeserialized Person object:");
                Console.WriteLine($"First Name: {deserializedPerson.FirstName}");
                Console.WriteLine($"Last Name: {deserializedPerson.LastName}");
                Console.WriteLine($"Age: {deserializedPerson.Age}");
            }
            else Console.WriteLine("Deserialization failed. deserializedPerson is null.");
        }
    }
}