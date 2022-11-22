using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace UI.Services
{
    internal class MapperService
    {
        public double[] ToInputData(Bitmap bitmap) =>
            ToColors(bitmap).Select(ColorToInt).ToArray();

        public double[,] ParseWeights(string text)
        {
            var lines = text.Trim().Split('\n');

            var list = new List<List<double>>();

            foreach (var line in lines)
            {
                var l = new List<double>();
                var strs = line.Trim().Split(' ');
                foreach (var str in strs)
                {
                    double d = 0;
                    if (!string.IsNullOrWhiteSpace(str))
                    {
                        d = double.Parse(str);
                    }

                    l.Add(d);
                }
                list.Add(l);
            }

            var x = list.Count;
            var y = list.Select(_ => _.Count).Max();

            var data = new double[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var e = list.ElementAtOrDefault(i).ElementAtOrDefault(j);
                    data[i, j] = e;
                }
            }

            return data;
        }

        public string SerializeWeights(double[,] data)
        {
            var x = data.GetLength(0);
            var y = data.GetLength(1);

            var stringBuilder = new StringBuilder();

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    var e = data[i, j];
                    stringBuilder.Append(e.ToString());
                    stringBuilder.Append(' ');
                }
                stringBuilder.Append('\n');
            }

            return stringBuilder.ToString();
        }

        private double ColorToInt(Color color) =>
            color.GetBrightness() < 0.5 ? 1 : 0;

        private IEnumerable<Color> ToColors(Bitmap bitmap)
        {
            for (var y = 0; y < bitmap.Height; y++)
            {
                for (var x = 0; x < bitmap.Width; x++)
                {
                    yield return bitmap.GetPixel(x, y);
                }
            }
        }
    }
}
