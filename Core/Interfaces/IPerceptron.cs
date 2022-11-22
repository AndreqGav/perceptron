namespace Core.Interfaces
{
    public interface IPerceptron
    {
        int Train(TrtrainingData[] trtrainingData);

        double[] Check(double[] input);

        void SetWeigths(double[,] matrix);

        double[,] GetWeigths();
    }

    public struct TrtrainingData
    {
        public double[] Input { get; set; }

        public double[] Expected { get; set; }
    }
}
