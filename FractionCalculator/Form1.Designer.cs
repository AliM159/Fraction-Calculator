namespace FractionCalculator
{
    partial class FractionCalculator
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
            firstFraction = new Label();
            secondFraction = new Label();
            devision = new Label();
            devision2 = new Label();
            firstTop = new TextBox();
            firstBottom = new TextBox();
            secondTop = new TextBox();
            operationsGroup = new GroupBox();
            division = new RadioButton();
            multiplication = new RadioButton();
            subtraction = new RadioButton();
            addition = new RadioButton();
            secondBottom = new TextBox();
            resultTop = new TextBox();
            resultBottom = new TextBox();
            devision3 = new Label();
            equal = new Label();
            performOperation = new Button();
            result = new Label();
            btnClear = new Button();
            btnExit = new Button();
            operationsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // firstFraction
            // 
            firstFraction.AutoSize = true;
            firstFraction.Font = new Font("Segoe UI", 10.875F);
            firstFraction.Location = new Point(116, 194);
            firstFraction.Name = "firstFraction";
            firstFraction.Size = new Size(70, 40);
            firstFraction.TabIndex = 0;
            firstFraction.Text = "First";
            // 
            // secondFraction
            // 
            secondFraction.AutoSize = true;
            secondFraction.Font = new Font("Segoe UI", 10.875F);
            secondFraction.Location = new Point(671, 194);
            secondFraction.Name = "secondFraction";
            secondFraction.Size = new Size(110, 40);
            secondFraction.TabIndex = 1;
            secondFraction.Text = "Second";
            // 
            // devision
            // 
            devision.AutoSize = true;
            devision.Font = new Font("Segoe UI", 10.875F);
            devision.Location = new Point(141, 273);
            devision.Name = "devision";
            devision.Size = new Size(28, 40);
            devision.TabIndex = 2;
            devision.Text = "/";
            // 
            // devision2
            // 
            devision2.AutoSize = true;
            devision2.Font = new Font("Segoe UI", 10.875F);
            devision2.Location = new Point(720, 261);
            devision2.Name = "devision2";
            devision2.Size = new Size(28, 40);
            devision2.TabIndex = 3;
            devision2.Text = "/";
            // 
            // firstTop
            // 
            firstTop.Font = new Font("Segoe UI", 10.875F);
            firstTop.Location = new Point(92, 270);
            firstTop.Name = "firstTop";
            firstTop.Size = new Size(43, 46);
            firstTop.TabIndex = 0;
            // 
            // firstBottom
            // 
            firstBottom.Font = new Font("Segoe UI", 10.875F);
            firstBottom.Location = new Point(175, 270);
            firstBottom.Name = "firstBottom";
            firstBottom.Size = new Size(43, 46);
            firstBottom.TabIndex = 1;
            // 
            // secondTop
            // 
            secondTop.Font = new Font("Segoe UI", 10.875F);
            secondTop.Location = new Point(671, 259);
            secondTop.Name = "secondTop";
            secondTop.Size = new Size(43, 46);
            secondTop.TabIndex = 7;
            // 
            // operationsGroup
            // 
            operationsGroup.Controls.Add(division);
            operationsGroup.Controls.Add(multiplication);
            operationsGroup.Controls.Add(subtraction);
            operationsGroup.Controls.Add(addition);
            operationsGroup.Font = new Font("Segoe UI", 10.875F);
            operationsGroup.Location = new Point(368, 71);
            operationsGroup.Name = "operationsGroup";
            operationsGroup.Size = new Size(163, 363);
            operationsGroup.TabIndex = 2;
            operationsGroup.TabStop = false;
            operationsGroup.Text = "Operation";
            // 
            // division
            // 
            division.AutoSize = true;
            division.Font = new Font("Segoe UI", 10.875F);
            division.Location = new Point(37, 292);
            division.Name = "division";
            division.Size = new Size(59, 44);
            division.TabIndex = 6;
            division.TabStop = true;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            // 
            // multiplication
            // 
            multiplication.AutoSize = true;
            multiplication.Font = new Font("Segoe UI", 10.875F);
            multiplication.Location = new Point(37, 216);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(60, 44);
            multiplication.TabIndex = 5;
            multiplication.TabStop = true;
            multiplication.Text = "*";
            multiplication.UseVisualStyleBackColor = true;
            // 
            // subtraction
            // 
            subtraction.AutoSize = true;
            subtraction.Font = new Font("Segoe UI", 10.875F);
            subtraction.Location = new Point(37, 141);
            subtraction.Name = "subtraction";
            subtraction.Size = new Size(60, 44);
            subtraction.TabIndex = 4;
            subtraction.TabStop = true;
            subtraction.Text = "-";
            subtraction.UseVisualStyleBackColor = true;
            // 
            // addition
            // 
            addition.AutoSize = true;
            addition.Font = new Font("Segoe UI", 10.875F);
            addition.Location = new Point(37, 69);
            addition.Name = "addition";
            addition.Size = new Size(68, 44);
            addition.TabIndex = 3;
            addition.TabStop = true;
            addition.Text = "+";
            addition.UseVisualStyleBackColor = true;
            // 
            // secondBottom
            // 
            secondBottom.Font = new Font("Segoe UI", 10.875F);
            secondBottom.Location = new Point(754, 259);
            secondBottom.Name = "secondBottom";
            secondBottom.Size = new Size(43, 46);
            secondBottom.TabIndex = 8;
            // 
            // resultTop
            // 
            resultTop.Enabled = false;
            resultTop.Font = new Font("Segoe UI", 13.875F);
            resultTop.Location = new Point(1055, 244);
            resultTop.Name = "resultTop";
            resultTop.Size = new Size(43, 57);
            resultTop.TabIndex = 6;
            resultTop.TabStop = false;
            // 
            // resultBottom
            // 
            resultBottom.Enabled = false;
            resultBottom.Font = new Font("Segoe UI", 13.875F);
            resultBottom.Location = new Point(1138, 244);
            resultBottom.Name = "resultBottom";
            resultBottom.Size = new Size(43, 57);
            resultBottom.TabIndex = 7;
            resultBottom.TabStop = false;
            // 
            // devision3
            // 
            devision3.AutoSize = true;
            devision3.Font = new Font("Segoe UI", 10.875F);
            devision3.Location = new Point(1104, 250);
            devision3.Name = "devision3";
            devision3.Size = new Size(28, 40);
            devision3.TabIndex = 12;
            devision3.Text = "/";
            // 
            // equal
            // 
            equal.AutoSize = true;
            equal.Font = new Font("Segoe UI", 10.875F);
            equal.Location = new Point(901, 255);
            equal.Name = "equal";
            equal.Size = new Size(37, 40);
            equal.TabIndex = 13;
            equal.Text = "=";
            // 
            // performOperation
            // 
            performOperation.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            performOperation.Location = new Point(242, 478);
            performOperation.Name = "performOperation";
            performOperation.Size = new Size(680, 81);
            performOperation.TabIndex = 9;
            performOperation.Text = "Perform Operation";
            performOperation.UseVisualStyleBackColor = true;
            performOperation.Click += performOperation_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.Location = new Point(1075, 185);
            result.Name = "result";
            result.Size = new Size(93, 40);
            result.TabIndex = 14;
            result.Text = "Result";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(242, 618);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(254, 81);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(668, 618);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(254, 81);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // FractionCalculator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1278, 949);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(result);
            Controls.Add(performOperation);
            Controls.Add(equal);
            Controls.Add(devision3);
            Controls.Add(resultBottom);
            Controls.Add(resultTop);
            Controls.Add(secondBottom);
            Controls.Add(operationsGroup);
            Controls.Add(secondTop);
            Controls.Add(firstBottom);
            Controls.Add(firstTop);
            Controls.Add(devision2);
            Controls.Add(devision);
            Controls.Add(secondFraction);
            Controls.Add(firstFraction);
            Name = "FractionCalculator";
            Text = "Fraction Calculator";
            operationsGroup.ResumeLayout(false);
            operationsGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstFraction;
        private Label secondFraction;
        private Label devision;
        private Label devision2;
        private TextBox firstTop;
        private TextBox firstBottom;
        private TextBox secondTop;
        private GroupBox operationsGroup;
        private TextBox secondBottom;
        private TextBox resultTop;
        private TextBox resultBottom;
        private RadioButton division;
        private RadioButton multiplication;
        private RadioButton subtraction;
        private RadioButton addition;
        private Label devision3;
        private Label equal;
        private Button performOperation;
        private Label result;
        private Button btnClear;
        private Button btnExit;
    }
}
