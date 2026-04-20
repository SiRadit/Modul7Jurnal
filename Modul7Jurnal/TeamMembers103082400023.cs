using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul7Jurnal
{
    public class TeamMembers103082400023
    {
        public List<Member> members { get; set; }
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103082400023.json");
            var data = JsonSerializer.Deserialize<TeamMembers103082400023>(jsonString);
            Console.WriteLine("Daftar Team Member: ");

            foreach(var m in data.members)
            {
                Console.WriteLine($"{m.nim} {m.firstName} {m.lastName} ({m.age} {m.gender})");
            }

        }
    }

    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
}
