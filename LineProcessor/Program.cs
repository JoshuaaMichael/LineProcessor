using LineProcessorLibrary;

namespace LineProcessor
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputFilename = @"input.txt";
			string outputFilename = @"output.txt";
			FileProcessor fpro = new ProjectEuler11(inputFilename, outputFilename);
			fpro.ProcessLines();
			System.Diagnostics.Process.Start(outputFilename);
		}
	}
}
