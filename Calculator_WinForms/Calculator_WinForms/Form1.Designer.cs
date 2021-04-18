
namespace Calculator_WinForms
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button10, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button11, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button12, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button13, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button14, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.button15, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 614);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.input1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 96);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.input2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 96);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.input3);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 96);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.input4);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(178, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 96);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.input5);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(353, 309);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 96);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.input6);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 411);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 96);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.input7);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(178, 411);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(169, 96);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.input8);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(353, 411);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(169, 96);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.input9);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(178, 513);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(169, 98);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.input0);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(528, 207);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(172, 96);
            this.button11.TabIndex = 10;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.add);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(528, 309);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(172, 96);
            this.button12.TabIndex = 11;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.subtract);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(528, 411);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(172, 96);
            this.button13.TabIndex = 12;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.multiply);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(528, 513);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(172, 98);
            this.button14.TabIndex = 13;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.divide);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(353, 513);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(169, 98);
            this.button15.TabIndex = 14;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.equals);
            // 
            // richTextBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBox1, 4);
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(697, 96);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 27);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 617);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Winforms Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

