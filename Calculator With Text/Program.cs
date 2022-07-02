using System.Data;
Console.WriteLine("Type in the location");
var path = Console.ReadLine();
string[] readText = File.ReadAllLines(path);
foreach (string s in readText)
{

    Console.WriteLine(s);

    string expression = Convert.ToString(s);
    var result = new DataTable().Compute(expression, "") + "";
    Console.WriteLine(result);
}