using System;
using System.Text;

namespace Z11
{
    public class Math
    {
        readonly int mLen;

        public readonly int[,] matrix1;
        public readonly int[,] matrix2;
        public int[,] matrixResult;

        public TimeSpan timeElapsed { get; set; }

        static Random rnd = new Random();

        DateTime ts;
        DateTime te;

        public Math(int mSize)
        {
            mLen = mSize;
            matrix1 = new int[mSize, mSize];
            matrix2 = new int[mSize, mSize];
            matrixResult = new int[mSize, mSize];

            for (int i = 0; i < mSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    matrix1[i, j] = rnd.Next(0, 11);
                    matrix2[i, j] = rnd.Next(0, 11);
                }
            }
        }

        public int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
        {
            ts = DateTime.Now;

            Parallel.For(0, mLen, iline => {
                Parallel.For(0, mLen, i => Multiply(matrixResult, i, iline, mLen));
            });

            timeElapsed = DateTime.Now - ts;
            return matrixResult;
        }

        private void Multiply(int[,] result, int i, int line, int len)
        {
            for (int j = 0; j < len; j++)
            {
                result[line, i] += matrix1[line, j] * matrix2[j, i];
            }
        }

        public string MatrixToString(int[,] matrix, string name)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(name + Environment.NewLine);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append($"{matrix[i, j]}\t");
                }
                sb.AppendLine();
            }
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
