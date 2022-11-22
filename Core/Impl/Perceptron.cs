using Core.Interfaces;
using System;
using System.Linq;

namespace Core.Impl
{
    public class Perceptron : IPerceptron
    {
        private const int MAX_EPOCH = 1000;
        private int m = 1;
        private int n = 1;

        private double eps = 0.001d;
        private double v = 0.5;

        private double[,] weights = new double[1, 1];
        private Func<double, double> activationFunc = ActivationFuncs.ThresholdFunc;

        public double[] Check(double[] input)
        {
            return Calculate(NormalizeInput(input));
        }

        public double[,] GetWeigths()
        {
            return weights;
        }

        public void SetWeigths(double[,] matrix)
        {
            weights = matrix;
            n = matrix.Length;
        }

        public int Train(TrtrainingData[] trainingData)
        {
            var random = new Random(DateTime.Now.Millisecond);

            n = trainingData.Select(_ => _.Input.Length).Max() + 1;
            weights = GenerateRandomMatrix(n, m);

            var epoch = 0;
            var hasWrong = true;

            while (epoch < MAX_EPOCH && hasWrong)
            {
                hasWrong = false;
                foreach (var data in trainingData)
                {
                    var input = NormalizeInput(data.Input);
                    var expected = data.Expected;

                    var value = Calculate(input);
                    var delta = CalculateDelta(expected, value);

                    if (!IsZeroVector(delta))
                    {
                        hasWrong = true;
                        weights = RecalculateWeights(input, delta);
                    }
                }

                //Shuffle(random, trainingData);
                epoch++;
            }

            return epoch;
        }

        private double[] Calculate(double[] input)
        {
            var result = new double[m];
            for (var j = 0; j < m; j++)
            {
                var sum = GetSum(input, j);
                var value = activationFunc(sum);

                result[j] = value;
            }

            return result;
        }

        private double GetSum(double[] input, int j)
        {
            var sum = 0d;
            for (var i = 0; i < n; i++)
            {
                sum += input[i] * weights[i, j];
            }

            return sum;
        }

        private double[] CalculateDelta(double[] v1, double[] v2)
        {
            var delta = new double[m];

            for (var i = 0; i < m; i++)
            {
                delta[i] = v1[i] - v2[i];
            }

            return delta;
        }

        private double[,] RecalculateWeights(double[] input, double[] delta)
        {
            var w = new double[n, m];

            for (int j = 0; j < m; j++)
            {
                var d = delta[j];

                for (int i = 0; i < n; i++)
                {
                    var x = input[i];
                    w[i, j] = weights[i, j] + v * d * x;
                }
            }

            return w;
        }

        private bool IsZeroVector(double[] delta)
        {
            return delta.All(v => Math.Abs(v) <= eps);
        }

        private double[] NormalizeInput(double[] input)
        {
            var normalized = new double[n];
            normalized[0] = 1;

            for (int j = 0; j < n - 1; j++)
            {
                normalized[j + 1] = input[j];
            }

            return normalized;
        }

        private double[,] GenerateRandomMatrix(int n, int m)
        {
            var random = new Random(DateTime.Now.Millisecond);

            var matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    var sign = random.NextDouble() > 0.5 ? 1 : -1;
                    matrix[i, j] = sign * (random.NextDouble() / 3);
                }
            }

            return matrix;
        }

        public void Shuffle<T>(Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }

    public static class ActivationFuncs
    {
        public static Func<double, double> ThresholdFunc = x => x < 0 ? 0 : 1;
    }
}
