using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GaussCalculator
{
    internal class EquationProcessor
    {

        public static List<(double[,], double[])> ParseEquations(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            Console.WriteLine("Zawartość pliku:");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            List<(double[,], double[])> systems = new List<(double[,], double[])>();
            List<string> currentSystem = new List<string>();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (currentSystem.Count > 0)
                    {
                        systems.Add(ParseSingleSystem(currentSystem));
                        currentSystem.Clear();
                    }
                }
                else
                {
                    currentSystem.Add(line);
                }
            }
            if (currentSystem.Count > 0)
            {
                systems.Add(ParseSingleSystem(currentSystem));
            }

            Console.WriteLine($"Załadowano {systems.Count} układów równań.");
            return systems;
        }


        private static (double[,], double[]) ParseSingleSystem(List<string> systemLines)
        {
            int matrixSize = systemLines.Count;
            double[,] coefficients = new double[matrixSize, matrixSize];
            double[] results = new double[matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                var line = systemLines[i];
                Console.WriteLine($"Przetwarzanie linii {i + 1}: {line}\n");

                var parts = line.Split('=');
                if (parts.Length != 2)
                {
                    Console.WriteLine($"Błąd formatu: linia {i + 1} ma nieprawidłowy format.\n");
                    throw new FormatException($"Nieprawidłowy format równania w linii {i + 1}");
                }


                string leftSide = parts[0].Trim();
                string rightSide = parts[1].Trim();
                Console.WriteLine($"Lewa strona: {leftSide}\n Prawa strona: {rightSide}\n");

                var terms = Regex.Matches(leftSide, @"([+-]?\s*\d+\*x\d+)")
                    .Cast<Match>()
                    .Select(m => m.Value.Replace(" ", ""))
                    .ToArray();


                for (int k = 0; k < terms.Length; k++)
                {
                    string term = terms[k];
                    Console.WriteLine($"Składnik {k + 1}: {term}");
                    string[] partsTerm = term.Split('*');
                    if (partsTerm.Length != 2)
                        throw new FormatException($"Nieprawidłowy składnik '{term}' w linii {k + 1}");

                    double coefficient = double.Parse(partsTerm[0]);
                    int variableIndex = int.Parse(partsTerm[1].Substring(1)) - 1;

                    coefficients[i, variableIndex] = coefficient;
                }

                results[i] = double.Parse(rightSide);
            }

            return (coefficients, results);
        }

    }
}
