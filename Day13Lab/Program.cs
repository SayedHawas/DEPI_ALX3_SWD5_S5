using System.Text.Json;

namespace Day13Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            *************************************
            Serializing and Deserializing Data
            *************************************
            The.NET Framework provides several classes that you can use 
            to serialize and de-serialize data. 
            Explain that this lesson focus on classes that enable you to serialize 
            to binary, XML, and JSON. 
            If you want to serialize data to a custom format,
            you can create your own formatter by implementing the IFormatter interface. 

            Serialization is the process of converting an object into a format that can be easily stored or transmitted, such as into a byte stream, XML, or JSON.Deserialization is the reverse process: converting the serialized data back into an object. In C#, serialization is commonly used for storing data, transmitting data between different applications, or for remoting purposes.

            Common Serialization Techniques in C#
            Binary Serialization           XXX
            XML Serialization
            JSON Serialization



            1. Binary Serialization
            Binary serialization converts an object into a binary format.
            It is efficient in terms of speed and size but is not human-readable.
            Here's an example of binary serialization:

            */
            Console.WriteLine(" ------------- Day 13 Demos -----------");
            #region Session Part1 
            Person Ahmed = new Person() { Id = 1, Name = "Ahmed ali ", Age = 25 };

            //// Serialize the object to a file
            //using (FileStream fs = new FileStream("person.txt", FileMode.Create,FileAccess.ReadWrite))
            //{
            //    //Stream Write ( Id= 1 , Name = "Ahmed ali " , Age = 25 )   DTD  Mapping   Id -->
            //    // Name --   Age --
            //    //BinaryFormatter formatter = new BinaryFormatter();
            //    //formatter.Serialize(fs, Ahmed);
            //}

            //// Deserialize the object from the file
            //using (FileStream fs = new FileStream("person.txt", FileMode.Open))
            //{
            //    BinaryFormatter formatter = new BinaryFormatter();
            //    Person deserializedPerson = (Person)formatter.Deserialize(fs);
            //    Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            //}

            //// Serialize the object to a file
            //using (FileStream fs = new FileStream("ahmed.xml", FileMode.Create))
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(Person));
            //    serializer.Serialize(fs, Ahmed);
            //}
            //Console.WriteLine("XML Serialize Done Check File ...");

            //// Deserialize the object from the file
            //using (FileStream fs = new FileStream("ahmed.xml", FileMode.Open))
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(Person));

            //    Person deserializedPerson = (Person)serializer.Deserialize(fs); // as Person;

            //    Console.WriteLine($"Id = {deserializedPerson.Id} Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            //}
            //Console.WriteLine("XML De-Serialize Done ...");


            // Serialize the object to a JSON string
            //string jsonString = JsonSerializer.Serialize(Ahmed);
            //File.WriteAllText("ahmed.json", jsonString);
            //Console.WriteLine("JSON Serialize Done Check File ...");
            //// Deserialize the object from the JSON string
            ///
            string jsonStringFromFile = File.ReadAllText("Ahmed.json");
            Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonStringFromFile);
            Console.WriteLine($" Id : {deserializedPerson.Id}Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            Console.WriteLine("JSON De-Serialize Done ...");
            Console.ReadLine();
            #endregion
        }
    }

    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
    }

}
