using System;
using System.Windows.Forms;

namespace Z11
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Обработчик нажатия на кнопку
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Проверяем ввод размера матрицы
            if (int.TryParse(txtMatrixSize.Text, out int size) && size > 0)
            {
                // Создаем объект Math и выполняем вычисления
                Math math = new Math(size);
                int[,] matrixResult = math.MatrixMult(math.matrix1, math.matrix2);

                // Выводим результаты в RichTextBox
                richTextBoxOutput.Clear();
                richTextBoxOutput.AppendText(math.MatrixToString(math.matrix1, "Матрица 1:"));
                richTextBoxOutput.AppendText(math.MatrixToString(math.matrix2, "Матрица 2:"));
                richTextBoxOutput.AppendText(math.MatrixToString(matrixResult, "Результат умножения:"));
                richTextBoxOutput.AppendText($"Время выполнения: {math.timeElapsed}");
            }
            else
            {
                MessageBox.Show("Введите корректный размер матрицы (целое число больше 0).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}