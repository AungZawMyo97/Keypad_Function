using KeyPadConsole_CodeTest;
using NUnitLite;

public class Program
{
	public static int Main(string[] args)
	{
		ConvertKeyFunction convertKeys = new ConvertKeyFunction();

		Console.WriteLine("Please enter your input (end with '#'):");
		string input = Console.ReadLine();

		string output = convertKeys.ConvertKeyInputToLetters(input);

		Console.WriteLine($"Converted Output: {output}");

		return new AutoRun().Execute(args);
	}

}
