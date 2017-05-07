using System;
using System.Collections.Generic;
using System.IO;

namespace LineProcessorLibrary
{
	public abstract class FileProcessor
	{
		private List<string> buffer;
		private int bufferCount = 50;
		private string inputFilename;
		private string outputFilename;

		public FileProcessor(string inputFilename, string outputFilename)
		{
			this.inputFilename = inputFilename;
			this.outputFilename = outputFilename;
		}

		public void ProcessLines()
		{
			if (!File.Exists(inputFilename))
			{
				throw new ArgumentException("No input file found");
			}

			File.Delete(outputFilename);

			buffer = new List<string>(bufferCount);

			using (StreamReader reader = new StreamReader(inputFilename))
			{
				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();
					string processedLine = ProcessLine(line);

					if (processedLine.Length > 0)
					{
						buffer.Add(processedLine);
						if (buffer.Count == bufferCount)
						{
							FlushBuffer();
						}
					}
				}
			}

			FlushBuffer();
		}

		protected void FlushBuffer()
		{
			if (buffer.Count > 0)
			{
				using (StreamWriter outputFile = new StreamWriter(outputFilename, true))
				{
					foreach (string line in buffer)
					{
						outputFile.WriteLine(line);
					}
				}
				buffer.Clear();
			}
		}

		protected abstract string ProcessLine(string line);
	}
}
