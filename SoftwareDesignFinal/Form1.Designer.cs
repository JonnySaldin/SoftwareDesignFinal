namespace SoftwareDesignFinal
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(51, 175);
            button1.Name = "button1";
            button1.Size = new Size(122, 58);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 2;
            label1.Text = "Recipe Builder";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 542);
            label2.Name = "label2";
            label2.Size = new Size(174, 32);
            label2.TabIndex = 3;
            label2.Text = "Add Ingredient";
            label2.Click += label2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(377, 135);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(752, 356);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += recipeListBox_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(377, 582);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(752, 239);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(377, 542);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 6;
            label3.Text = "Ingredients";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(377, 100);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 7;
            label4.Text = "Recipes";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 95);
            label5.Name = "label5";
            label5.Size = new Size(134, 32);
            label5.TabIndex = 10;
            label5.Text = "Add Recipe";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(51, 582);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(51, 627);
            button2.Name = "button2";
            button2.Size = new Size(122, 58);
            button2.TabIndex = 8;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 1322);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Button button2;
    }
}