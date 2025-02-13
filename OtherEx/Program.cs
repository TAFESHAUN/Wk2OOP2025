using System.Text;

var totalOutputString = new StringBuilder();
totalOutputString.AppendLine("Hello World!");
totalOutputString.Append("See what happens###");
totalOutputString.AppendLine(" when we appendline###");
totalOutputString.Append(" Something cool8787234736");

totalOutputString.Insert(0, "This is being added to the first line8787234736");
totalOutputString.Remove(10, 23);
totalOutputString.Replace("8787234736", "***********");
totalOutputString.Replace("###", "?");

Console.WriteLine(totalOutputString.ToString());

Console.ReadKey();
