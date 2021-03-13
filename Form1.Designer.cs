
namespace sum
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.FirstNWord = new System.Windows.Forms.Label();
            this.SecondNWord = new System.Windows.Forms.Label();
            this.ResultWord = new System.Windows.Forms.Label();
            this.PlusButton = new System.Windows.Forms.RadioButton();
            this.MinusButton = new System.Windows.Forms.RadioButton();
            this.MultiplicationButton = new System.Windows.Forms.RadioButton();
            this.DivisionButton = new System.Windows.Forms.RadioButton();
            this.ErrorTable = new System.Windows.Forms.Label();
            this.Mistake = new System.Windows.Forms.Label();
            this.Gradient = new System.Windows.Forms.PictureBox();
            this.Calculator = new System.Windows.Forms.Label();
            this.White = new System.Windows.Forms.PictureBox();
            this.CheckMistakeFirst = new System.Windows.Forms.Label();
            this.CheckMistakeSecond = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gradient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.White)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNumber.Location = new System.Drawing.Point(755, 265);
            this.FirstNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(274, 60);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.Text = "0";
            this.FirstNumber.TextChanged += new System.EventHandler(this.FirstNumber_TextChanged);
            // 
            // SecondNumber
            // 
            this.SecondNumber.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNumber.Location = new System.Drawing.Point(755, 340);
            this.SecondNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(274, 60);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.Text = "0";
            this.SecondNumber.TextChanged += new System.EventHandler(this.SecondNumber_TextChanged);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.ResultLabel.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(746, 542);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(47, 52);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "0";
            // 
            // FirstNWord
            // 
            this.FirstNWord.AutoSize = true;
            this.FirstNWord.BackColor = System.Drawing.Color.White;
            this.FirstNWord.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNWord.Location = new System.Drawing.Point(272, 268);
            this.FirstNWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNWord.Name = "FirstNWord";
            this.FirstNWord.Size = new System.Drawing.Size(264, 52);
            this.FirstNWord.TabIndex = 3;
            this.FirstNWord.Text = "1st number:";
            // 
            // SecondNWord
            // 
            this.SecondNWord.AutoSize = true;
            this.SecondNWord.BackColor = System.Drawing.Color.White;
            this.SecondNWord.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNWord.Location = new System.Drawing.Point(272, 343);
            this.SecondNWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondNWord.Name = "SecondNWord";
            this.SecondNWord.Size = new System.Drawing.Size(288, 52);
            this.SecondNWord.TabIndex = 4;
            this.SecondNWord.Text = "2nd number:";
            // 
            // ResultWord
            // 
            this.ResultWord.AutoSize = true;
            this.ResultWord.BackColor = System.Drawing.Color.White;
            this.ResultWord.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultWord.Location = new System.Drawing.Point(275, 542);
            this.ResultWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultWord.Name = "ResultWord";
            this.ResultWord.Size = new System.Drawing.Size(154, 52);
            this.ResultWord.TabIndex = 5;
            this.ResultWord.Text = "Result:";
            // 
            // PlusButton
            // 
            this.PlusButton.AutoSize = true;
            this.PlusButton.BackColor = System.Drawing.Color.White;
            this.PlusButton.Font = new System.Drawing.Font("Century Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusButton.Location = new System.Drawing.Point(283, 398);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(90, 67);
            this.PlusButton.TabIndex = 6;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.CheckedChanged += new System.EventHandler(this.PlusButton_CheckedChanged);
            // 
            // MinusButton
            // 
            this.MinusButton.AutoSize = true;
            this.MinusButton.BackColor = System.Drawing.Color.White;
            this.MinusButton.Font = new System.Drawing.Font("Century Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusButton.Location = new System.Drawing.Point(283, 451);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(81, 76);
            this.MinusButton.TabIndex = 7;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.CheckedChanged += new System.EventHandler(this.MinusButton_CheckedChanged);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.AutoSize = true;
            this.MultiplicationButton.BackColor = System.Drawing.Color.White;
            this.MultiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplicationButton.Location = new System.Drawing.Point(473, 402);
            this.MultiplicationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(79, 65);
            this.MultiplicationButton.TabIndex = 8;
            this.MultiplicationButton.Text = "*";
            this.MultiplicationButton.UseVisualStyleBackColor = false;
            this.MultiplicationButton.CheckedChanged += new System.EventHandler(this.MultiplicationButton_CheckedChanged);
            // 
            // DivisionButton
            // 
            this.DivisionButton.AutoSize = true;
            this.DivisionButton.BackColor = System.Drawing.Color.White;
            this.DivisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivisionButton.Location = new System.Drawing.Point(473, 451);
            this.DivisionButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(73, 65);
            this.DivisionButton.TabIndex = 9;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = false;
            this.DivisionButton.CheckedChanged += new System.EventHandler(this.DivisionButton_CheckedChanged);
            // 
            // ErrorTable
            // 
            this.ErrorTable.AutoSize = true;
            this.ErrorTable.BackColor = System.Drawing.Color.White;
            this.ErrorTable.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorTable.Location = new System.Drawing.Point(746, 607);
            this.ErrorTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorTable.Name = "ErrorTable";
            this.ErrorTable.Size = new System.Drawing.Size(0, 52);
            this.ErrorTable.TabIndex = 10;
            // 
            // Mistake
            // 
            this.Mistake.AutoSize = true;
            this.Mistake.BackColor = System.Drawing.Color.White;
            this.Mistake.Font = new System.Drawing.Font("Century Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mistake.Location = new System.Drawing.Point(272, 607);
            this.Mistake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mistake.Name = "Mistake";
            this.Mistake.Size = new System.Drawing.Size(0, 52);
            this.Mistake.TabIndex = 11;
            // 
            // Gradient
            // 
            this.Gradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gradient.ImageLocation = "C:\\Users\\Liza\\source\\repos\\sum\\sum\\images\\wallpaper.jpg";
            this.Gradient.Location = new System.Drawing.Point(0, 0);
            this.Gradient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(1419, 920);
            this.Gradient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gradient.TabIndex = 12;
            this.Gradient.TabStop = false;
            // 
            // Calculator
            // 
            this.Calculator.AutoSize = true;
            this.Calculator.BackColor = System.Drawing.Color.White;
            this.Calculator.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculator.Location = new System.Drawing.Point(304, 137);
            this.Calculator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(705, 78);
            this.Calculator.TabIndex = 13;
            this.Calculator.Text = "Calculator for double";
            // 
            // White
            // 
            this.White.ImageLocation = "C:\\Users\\Liza\\source\\repos\\sum\\sum\\images\\white.jpg";
            this.White.Location = new System.Drawing.Point(219, 108);
            this.White.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(988, 673);
            this.White.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.White.TabIndex = 14;
            this.White.TabStop = false;
            // 
            // CheckMistakeFirst
            // 
            this.CheckMistakeFirst.AutoSize = true;
            this.CheckMistakeFirst.BackColor = System.Drawing.Color.White;
            this.CheckMistakeFirst.ForeColor = System.Drawing.Color.Red;
            this.CheckMistakeFirst.Location = new System.Drawing.Point(1058, 265);
            this.CheckMistakeFirst.Name = "CheckMistakeFirst";
            this.CheckMistakeFirst.Size = new System.Drawing.Size(76, 25);
            this.CheckMistakeFirst.TabIndex = 15;
            this.CheckMistakeFirst.Text = "testing";
            // 
            // CheckMistakeSecond
            // 
            this.CheckMistakeSecond.AutoSize = true;
            this.CheckMistakeSecond.BackColor = System.Drawing.Color.White;
            this.CheckMistakeSecond.ForeColor = System.Drawing.Color.Red;
            this.CheckMistakeSecond.Location = new System.Drawing.Point(1063, 340);
            this.CheckMistakeSecond.Name = "CheckMistakeSecond";
            this.CheckMistakeSecond.Size = new System.Drawing.Size(76, 25);
            this.CheckMistakeSecond.TabIndex = 16;
            this.CheckMistakeSecond.Text = "testing";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 920);
            this.Controls.Add(this.CheckMistakeSecond);
            this.Controls.Add(this.CheckMistakeFirst);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.Mistake);
            this.Controls.Add(this.ErrorTable);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.ResultWord);
            this.Controls.Add(this.SecondNWord);
            this.Controls.Add(this.FirstNWord);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Gradient);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Calculator For Integers";
            ((System.ComponentModel.ISupportInitialize)(this.Gradient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.White)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label FirstNWord;
        private System.Windows.Forms.Label SecondNWord;
        private System.Windows.Forms.Label ResultWord;
        private System.Windows.Forms.RadioButton PlusButton;
        private System.Windows.Forms.RadioButton MinusButton;
        private System.Windows.Forms.RadioButton MultiplicationButton;
        private System.Windows.Forms.RadioButton DivisionButton;
        private System.Windows.Forms.Label ErrorTable;
        private System.Windows.Forms.Label Mistake;
        private System.Windows.Forms.PictureBox Gradient;
        private System.Windows.Forms.Label Calculator;
        private System.Windows.Forms.PictureBox White;
        private System.Windows.Forms.Label CheckMistakeFirst;
        private System.Windows.Forms.Label CheckMistakeSecond;
    }
}

