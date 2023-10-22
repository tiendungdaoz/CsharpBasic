using System.Text.RegularExpressions;
namespace BieuThucChinhQuy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Match va MatchCollection
            Regex reg = new Regex(@"\d");
            Match result = reg.Match("-howkteam.com 10092016-");

            Console.WriteLine(result.ToString());
            Console.WriteLine();

            do
            {
                Console.WriteLine(result.ToString());
                result = result.NextMatch();
            } while (result != Match.Empty);
            Console.WriteLine();

            foreach (Match item in reg.Matches("-howkteam.com 10092016-"))
            {
                Console.WriteLine(item.ToString());
            }

            //Group va GroupCollection
            Regex reg1 = new Regex(@"(?<hours>\d+):(?<minutes>\d+):(?<seconds>\d+)");

            foreach (Match item in reg1.Matches("15/10/2023 8:30:45 142.2415.12.12"))
            {
                Console.WriteLine("Match: {0}", item.ToString());
                Console.WriteLine("Hours: {0}", item.Groups["hours"]);
                Console.WriteLine("Minutes: {0}", item.Groups["minutes"]);
                Console.WriteLine("Seconds: {0}", item.Groups["seconds"]);
            }
        }
    }
}
