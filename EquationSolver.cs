using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussCalculator
{
    internal class EquationSolver
    {
        public static double[] Solve(double[,] coefficients, double[] results, int threadCount)
        {
            int n = coefficients.GetLength(0);

            for(int i = 0; i <n; i++)
            {
                //Wybór wiersza głownego
                double maxEl = Math.Abs(coefficients[i, i]);
                int maxRow = i;

                for(int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(coefficients[k, i]) > maxEl)
                    {
                        maxEl = Math.Abs(coefficients[k, i]);
                        maxRow = k;
                    }
                }

                //Zamiana wierszy
                for(int k = i; k < n; k++)
                {
                    double tmp = coefficients[maxRow, k];
                    coefficients[maxRow, k] = coefficients[i, k];
                    coefficients[i, k] = tmp;
                }

                double temp = results[maxRow];
                results[maxRow] = results[i];
                results[i] = temp;

                //eliminacja Gaussa
                for(int j = i + 1; j < n; j++)
                {
                    double factor = coefficients[j, i] / coefficients[i, i];
                    results[j] -= factor * results[i];

                    for(int m = i; m < n; m++)
                    {
                        coefficients[j, m] -= factor * coefficients[i, m];
                    }
   
                }
            }

            //Rozwiązanie układu
            double[] solution = new double[n];
            for(int i = n -1; i >= 0; i--)
            {
                solution[i] = results[i] / coefficients[i, i];
                for (int j = i - 1; j >= 0; j--)
                    results[j] -= coefficients[j, i] * solution[i];
            }
            return solution;
        }
    }
}
