namespace Z11
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMatrixSize;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMatrixSize = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            this.txtMatrixSize.Location = new System.Drawing.Point(12, 12);
            this.txtMatrixSize.Name = "txtMatrixSize";
            this.txtMatrixSize.Size = new System.Drawing.Size(200, 20);
            this.txtMatrixSize.TabIndex = 0;

            this.btnCalculate.Location = new System.Drawing.Point(12, 38);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 67);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(400, 300);
            this.richTextBoxOutput.TabIndex = 2;
            this.richTextBoxOutput.Text = "";

            this.ClientSize = new System.Drawing.Size(424, 381);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMatrixSize);
            this.Name = "MainForm";
            this.Text = "Умножение матриц";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}