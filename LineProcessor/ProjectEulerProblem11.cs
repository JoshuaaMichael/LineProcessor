using System;
using LineProcessorLibrary;

namespace LineProcessor
{
	class ProjectEuler11 : FileProcessor
	{
		public ProjectEuler11(string inputFilename, string outputFilename)
			: base(inputFilename, outputFilename) { }

		protected override string ProcessLine(string line)
		{
			for (int i = 0; i < line.Length; i++)
			{
				if (!Char.IsDigit(line[i]))
				{
					line = line.Insert(i++, ",");
				}
			}
			return "{" + line + "},";
		}
	}
}
