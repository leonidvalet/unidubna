namespace Z2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddCircleButton = new System.Windows.Forms.Button();
            this.AddSquareButton = new System.Windows.Forms.Button();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCircleButton
            // 
            this.AddCircleButton.Location = new System.Drawing.Point(49, 12);
            this.AddCircleButton.Name = "AddCircleButton";
            this.AddCircleButton.Size = new System.Drawing.Size(133, 23);
            this.AddCircleButton.TabIndex = 0;
            this.AddCircleButton.Text = "Добавить круг";
            this.AddCircleButton.UseVisualStyleBackColor = true;
            this.AddCircleButton.Click += new System.EventHandler(this.AddCircleButton_Click_1);
            // 
            // AddSquareButton
            // 
            this.AddSquareButton.Location = new System.Drawing.Point(188, 12);
            this.AddSquareButton.Name = "AddSquareButton";
            this.AddSquareButton.Size = new System.Drawing.Size(133, 23);
            this.AddSquareButton.TabIndex = 1;
            this.AddSquareButton.Text = "Добавить квадрат";
            this.AddSquareButton.UseVisualStyleBackColor = true;
            this.AddSquareButton.Click += new System.EventHandler(this.AddSquareButton_Click_1);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.Color.White;
            this.DrawingPanel.Location = new System.Drawing.Point(12, 41);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(460, 308);
            this.DrawingPanel.TabIndex = 2;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(327, 12);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Очистка";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.AddSquareButton);
            this.Controls.Add(this.AddCircleButton);
            this.Name = "MainForm";
            this.Text = "Квадратные треугольники";
            this.ResumeLayout(false);

        }



        #endregion

        private Button AddCircleButton;
        private Button AddSquareButton;
        private Panel DrawingPanel;
        private Button ClearBtn;
    }
}