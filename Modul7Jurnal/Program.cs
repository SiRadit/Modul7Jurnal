using Modul7Jurnal;

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103082400027.ReadJSON();
        TeamMembers103082400023 team = new TeamMembers103082400023();
        team.ReadJSON();
        Console.WriteLine("\n-----------------------------------\n");
        GlossaryItem103082400025.ReadJSON();

    }

}