namespace Calculator_2._0
{
    partial class Form1
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
            equationBox = new TextBox();
            label1 = new Label();
            Calculate = new Button();
            resultBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // equationBox
            // 
            equationBox.Location = new Point(328, 94);
            equationBox.Name = "equationBox";
            equationBox.Size = new Size(191, 23);
            equationBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(196, 97);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 1;
            label1.Text = "Please input equation";
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Calculate.Location = new Point(328, 152);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(191, 27);
            Calculate.TabIndex = 2;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(328, 215);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(191, 23);
            resultBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(280, 218);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(resultBox);
            Controls.Add(Calculate);
            Controls.Add(label1);
            Controls.Add(equationBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox equationBox;
        private Label label1;
        private Button Calculate;
        private TextBox resultBox;
        private Label label2;
    }
}
