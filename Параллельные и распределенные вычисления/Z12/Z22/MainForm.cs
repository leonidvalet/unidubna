using System;
using System.Windows.Forms;

namespace Z12
{
    public partial class MainForm : Form
    {
        private int[,] matrixA;
        private int[,] matrixB;
        private int[,] resultMatrixSeq;
        private int[,] resultMatrixParFor;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerateMatrices_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRows.Text, out int rows) && int.TryParse(txtCols.Text, out int cols))
            {
                matrixA = Math.GenerateRandomMatrix(rows, cols);
                matrixB = Math.GenerateRandomMatrix(cols, rows);

                DisplayMatrix(matrixA, dgvMatrixA);
                DisplayMatrix(matrixB, dgvMatrixB);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные размеры матриц.");
            }
        }

        private void btnMultiplySequential_Click(object sender, EventArgs e)
        {
            double timeTaken = Math.MeasureTime(() => resultMatrixSeq = Math.MultiplyMatricesSequential(matrixA, matrixB));
            lblTimeSeq.Text = $"Время последовательного умножения: {timeTaken:F6} сек.";

            DisplayMatrix(resultMatrixSeq, dgvResultSeq);
        }

        private void btnMultiplyParallelFor_Click(object sender, EventArgs e)
        {
            double timeTaken = Math.MeasureTime(() => resultMatrixParFor = Math.MultiplyMatricesParallelUsingParallelFor(matrixA, matrixB));
            lblTimeParFor.Text = $"Время параллельного умножения: {timeTaken:F6} сек.";

            DisplayMatrix(resultMatrixParFor, dgvResultParFor);
        }

        private void DisplayMatrix(int[,] matrix, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < cols; i++)
            {
                dgv.Columns.Add($"col{i}", i.ToString());
            }

            for (int i = 0; i < rows; i++)
            {
                dgv.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    dgv[j, i].Value = matrix[i, j];
                }
            }
        }
    }
}