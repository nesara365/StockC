namespace Stock_Csharp
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 243);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 8;
            label3.Text = "Stock Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 177);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 7;
            label2.Text = "Stock Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 113);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 6;
            label1.Text = "Stock Code";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 240);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 27);
            textBox3.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(606, 275);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(77, 325);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(655, 351);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "View";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 483);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
    }
}