namespace Z3
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
            this.TextInput = new System.Windows.Forms.TextBox();
            this.UpdateTextButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.TextDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(12, 12);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(262, 23);
            this.TextInput.TabIndex = 0;
            // 
            // UpdateTextButton
            // 
            this.UpdateTextButton.Location = new System.Drawing.Point(12, 41);
            this.UpdateTextButton.Name = "UpdateTextButton";
            this.UpdateTextButton.Size = new System.Drawing.Size(100, 23);
            this.UpdateTextButton.TabIndex = 1;
            this.UpdateTextButton.Text = "Обновить текст";
            this.UpdateTextButton.UseVisualStyleBackColor = true;
            this.UpdateTextButton.Click += new System.EventHandler(this.UpdateTextButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(118, 41);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 23);
            this.UndoButton.TabIndex = 2;
            this.UndoButton.Text = "Отмена";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Location = new System.Drawing.Point(199, 41);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(75, 23);
            this.RedoButton.TabIndex = 3;
            this.RedoButton.Text = "Назад";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // TextDisplay
            // 
            this.TextDisplay.AutoSize = true;
            this.TextDisplay.Location = new System.Drawing.Point(12, 82);
            this.TextDisplay.Name = "TextDisplay";
            this.TextDisplay.Size = new System.Drawing.Size(0, 15);
            this.TextDisplay.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextDisplay);
            this.Controls.Add(this.RedoButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.UpdateTextButton);
            this.Controls.Add(this.TextInput);
            this.Name = "MainForm";
            this.Text = "Редактор текста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextInput;
        private Button UpdateTextButton;
        private Button UndoButton;
        private Button RedoButton;
        private Label TextDisplay;
    }
}