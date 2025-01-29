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

        // ���������� ������� �� ������
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // ��������� ���� ������� �������
            if (int.TryParse(txtMatrixSize.Text, out int size) && size > 0)
            {
                // ������� ������ Math � ��������� ����������
                Math math = new Math(size);
                int[,] matrixResult = math.MatrixMult(math.matrix1, math.matrix2);

                // ������� ���������� � RichTextBox
                richTextBoxOutput.Clear();
                richTextBoxOutput.AppendText(math.MatrixToString(math.matrix1, "������� 1:"));
                richTextBoxOutput.AppendText(math.MatrixToString(math.matrix2, "������� 2:"));
                richTextBoxOutput.AppendText(math.MatrixToString(matrixResult, "��������� ���������:"));
                richTextBoxOutput.AppendText($"����� ����������: {math.timeElapsed}");
            }
            else
            {
                MessageBox.Show("������� ���������� ������ ������� (����� ����� ������ 0).", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}