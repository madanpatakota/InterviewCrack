using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExperienceCandidates
{

    //Serialization:
    //The process of converting an object into a format(e.g., JSON, XML, or binary) for storage or transmission.
    //Example: Saving an object to a file or sending it over a network.

    //Deserialization:
    //The process of converting the serialized data back into an object.
    //Example: Loading an object from a file or receiving it from a network.


    using System;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class SerialzableAndSerialableProgram
    {
        static void Main()
        {
            Person person = new Person { Name = "Madan", Age = 30 };

            // Serialization
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            IFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
            using (Stream stream = new FileStream("person.bin", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, person);
                Console.WriteLine("Object serialized successfully.");
            }

            // Deserialization
            using (Stream stream = new FileStream("person.bin", FileMode.Open, FileAccess.Read))
            {
                Person deserializedPerson = (Person)formatter.Deserialize(stream);
                Console.WriteLine("Object deserialized successfully.");
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            }
        }
    }


}
