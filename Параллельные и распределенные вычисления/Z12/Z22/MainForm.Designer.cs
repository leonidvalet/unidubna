namespace Z12
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Button btnGenerateMatrices;
        private System.Windows.Forms.DataGridView dgvMatrixA;
        private System.Windows.Forms.DataGridView dgvMatrixB;
        private System.Windows.Forms.Button btnMultiplySequential;
        private System.Windows.Forms.Label lblTimeSeq;
        private System.Windows.Forms.DataGridView dgvResultSeq;
        private System.Windows.Forms.Button btnMultiplyParallelFor;
        private System.Windows.Forms.Label lblTimeParFor;
        private System.Windows.Forms.DataGridView dgvResultParFor;

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
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.btnGenerateMatrices = new System.Windows.Forms.Button();
            this.dgvMatrixA = new System.Windows.Forms.DataGridView();
            this.dgvMatrixB = new System.Windows.Forms.DataGridView();
            this.btnMultiplySequential = new System.Windows.Forms.Button();
            this.lblTimeSeq = new System.Windows.Forms.Label();
            this.dgvResultSeq = new System.Windows.Forms.DataGridView();
            this.btnMultiplyParallelFor = new System.Windows.Forms.Button();
            this.lblTimeParFor = new System.Windows.Forms.Label();
            this.dgvResultParFor = new System.Windows.Forms.DataGridView();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultSeq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultParFor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(13, 38);
            this.txtRows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(116, 23);
            this.txtRows.TabIndex = 0;
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(137, 38);
            this.txtCols.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(127, 23);
            this.txtCols.TabIndex = 1;
            // 
            // btnGenerateMatrices
            // 
            this.btnGenerateMatrices.Location = new System.Drawing.Point(271, 35);
            this.btnGenerateMatrices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerateMatrices.Name = "btnGenerateMatrices";
            this.btnGenerateMatrices.Size = new System.Drawing.Size(175, 27);
            this.btnGenerateMatrices.TabIndex = 2;
            this.btnGenerateMatrices.Text = "Сгенерировать матрицы";
            this.btnGenerateMatrices.UseVisualStyleBackColor = true;
            this.btnGenerateMatrices.Click += new System.EventHandler(this.btnGenerateMatrices_Click);
            // 
            // dgvMatrixA
            // 
            this.dgvMatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrixA.Location = new System.Drawing.Point(13, 71);
            this.dgvMatrixA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMatrixA.Name = "dgvMatrixA";
            this.dgvMatrixA.Size = new System.Drawing.Size(368, 263);
            this.dgvMatrixA.TabIndex = 3;
            // 
            // dgvMatrixB
            // 
            this.dgvMatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrixB.Location = new System.Drawing.Point(389, 71);
            this.dgvMatrixB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMatrixB.Name = "dgvMatrixB";
            this.dgvMatrixB.Size = new System.Drawing.Size(368, 263);
            this.dgvMatrixB.TabIndex = 4;
            // 
            // btnMultiplySequential
            // 
            this.btnMultiplySequential.Location = new System.Drawing.Point(26, 359);
            this.btnMultiplySequential.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMultiplySequential.Name = "btnMultiplySequential";
            this.btnMultiplySequential.Size = new System.Drawing.Size(175, 27);
            this.btnMultiplySequential.TabIndex = 5;
            this.btnMultiplySequential.Text = "Последовательное умножение";
            this.btnMultiplySequential.UseVisualStyleBackColor = true;
            this.btnMultiplySequential.Click += new System.EventHandler(this.btnMultiplySequential_Click);
            // 
            // lblTimeSeq
            // 
            this.lblTimeSeq.AutoSize = true;
            this.lblTimeSeq.Location = new System.Drawing.Point(13, 667);
            this.lblTimeSeq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeSeq.Name = "lblTimeSeq";
            this.lblTimeSeq.Size = new System.Drawing.Size(223, 15);
            this.lblTimeSeq.TabIndex = 6;
            this.lblTimeSeq.Text = "Время последовательного умножения:";
            // 
            // dgvResultSeq
            // 
            this.dgvResultSeq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultSeq.Location = new System.Drawing.Point(13, 392);
            this.dgvResultSeq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResultSeq.Name = "dgvResultSeq";
            this.dgvResultSeq.Size = new System.Drawing.Size(369, 263);
            this.dgvResultSeq.TabIndex = 7;
            // 
            // btnMultiplyParallelFor
            // 
            this.btnMultiplyParallelFor.Location = new System.Drawing.Point(451, 359);
            this.btnMultiplyParallelFor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMultiplyParallelFor.Name = "btnMultiplyParallelFor";
            this.btnMultiplyParallelFor.Size = new System.Drawing.Size(175, 27);
            this.btnMultiplyParallelFor.TabIndex = 8;
            this.btnMultiplyParallelFor.Text = "Параллельное умножение (Parallel.For)";
            this.btnMultiplyParallelFor.UseVisualStyleBackColor = true;
            this.btnMultiplyParallelFor.Click += new System.EventHandler(this.btnMultiplyParallelFor_Click);
            // 
            // lblTimeParFor
            // 
            this.lblTimeParFor.AutoSize = true;
            this.lblTimeParFor.Location = new System.Drawing.Point(390, 667);
            this.lblTimeParFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeParFor.Name = "lblTimeParFor";
            this.lblTimeParFor.Size = new System.Drawing.Size(200, 15);
            this.lblTimeParFor.TabIndex = 9;
            this.lblTimeParFor.Text = "Время параллельного умножения:";
            // 
            // dgvResultParFor
            // 
            this.dgvResultParFor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultParFor.Location = new System.Drawing.Point(390, 392);
            this.dgvResultParFor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResultParFor.Name = "dgvResultParFor";
            this.dgvResultParFor.Size = new System.Drawing.Size(369, 263);
            this.dgvResultParFor.TabIndex = 10;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(12, 20);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(109, 15);
            this.lblRows.TabIndex = 11;
            this.lblRows.Text = "Количество строк:";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(137, 20);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(130, 15);
            this.lblCols.TabIndex = 12;
            this.lblCols.Text = "Количество столбцов:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 700);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.dgvResultParFor);
            this.Controls.Add(this.lblTimeParFor);
            this.Controls.Add(this.btnMultiplyParallelFor);
            this.Controls.Add(this.dgvResultSeq);
            this.Controls.Add(this.lblTimeSeq);
            this.Controls.Add(this.btnMultiplySequential);
            this.Controls.Add(this.dgvMatrixB);
            this.Controls.Add(this.dgvMatrixA);
            this.Controls.Add(this.btnGenerateMatrices);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.txtRows);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Умножение матриц";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultSeq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultParFor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblRows;
        private Label lblCols;
    }
}