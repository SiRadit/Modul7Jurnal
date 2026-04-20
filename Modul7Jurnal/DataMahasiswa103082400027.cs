using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Modul7Jurnal
{
    internal class DataMahasiswa103082400027
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_1_103082400027.json");

            var data = JsonSerializer.Deserialize<DataMahasiswa103082400027>(json);

            Console.WriteLine("=== DATA MAHASISWA ===");
            Console.WriteLine($"Nama: {data.firstName} {data.lastName}");
            Console.WriteLine($"Gender: {data.gender}");
            Console.WriteLine($"Umur: {data.age}");

            Console.WriteLine("\nAlamat:");
            Console.WriteLine($"Jalan: {data.address.streetAddress}");
            Console.WriteLine($"Kota: {data.address.city}");
            Console.WriteLine($"Provinsi: {data.address.state}");

            Console.WriteLine("\nMata Kuliah:");
            foreach (var course in data.courses)
            {
                Console.WriteLine($"- {course.code}: {course.name}");
            }
        }
    }
}
