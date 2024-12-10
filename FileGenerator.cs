using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace GaussCalculator
{
    public static class FileGenerator
    {
        public static void GenerateSampleFiles()
        {
            string folderPath = @"C:\Users\martu\OneDrive\Pulpit\Karolina\JA\GaussCalculator\DataFiles";

            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException($"Folder {folderPath} nie istne cieżka jest poprawna.");
            }

            GenerateFile(Path.Combine(folderPath, "Small.txt"), 5, 10);
            GenerateFile(Path.Combine(folderPath, "Medium.txt"), 50, 25);
            GenerateFile(Path.Combine(folderPath, "Large.txt"), 100, 50);
        }


        private static void GenerateFile(string filePath, int numSystems, int matrixSize)
        {
            Random random = new Random();
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                for (int i = 0; i < numSystems; i++)
                {
                    for (int j = 0; j < matrixSize; j++)
                    {
                        string row = GenerateEquation(j, matrixSize, random);
                        writer.WriteLine(row);
                    }

                    //empty line between system but not at the end of the file
                    if (i < numSystems - 1)
                    {
                        writer.WriteLine();
                    }
                }
            }
        }

        private static string GenerateEquation(int rowIndex, int matrixSize, Random random)
        {
            List<string> equationParts = new List<string>();
            for (int k = 0; k < matrixSize; k++)
            {
                int coefficient;
                do
                {
                    coefficient = random.Next(-10, 11);
                }
                while (coefficient == 0);

                string part;
                if (coefficient < 0)
                    part = $"{coefficient}*x{k + 1}";
                else
                    part = $"+{coefficient}*x{k + 1}";

                equationParts.Add(part);
            }

            int result = random.Next(-10, 11);

            return string.Join("", equationParts) + $" = {result}";
        }
    }
}
