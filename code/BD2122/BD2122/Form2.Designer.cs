namespace BD2122
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recipieNameTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.caloriesTxt = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recipieNameTxt
            // 
            this.recipieNameTxt.Location = new System.Drawing.Point(12, 48);
            this.recipieNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recipieNameTxt.Name = "recipieNameTxt";
            this.recipieNameTxt.PlaceholderText = "Insira nome de receita";
            this.recipieNameTxt.Size = new System.Drawing.Size(383, 27);
            this.recipieNameTxt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(484, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(14, 98);
            this.authorTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.PlaceholderText = "Insira o nome do autor";
            this.authorTxt.Size = new System.Drawing.Size(190, 27);
            this.authorTxt.TabIndex = 4;
            // 
            // timeTxt
            // 
            this.timeTxt.Location = new System.Drawing.Point(238, 98);
            this.timeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.PlaceholderText = "Insira tempo de preparação";
            this.timeTxt.Size = new System.Drawing.Size(199, 27);
            this.timeTxt.TabIndex = 6;
            this.timeTxt.TextChanged += new System.EventHandler(this.timeTxt_TextChanged);
            // 
            // caloriesTxt
            // 
            this.caloriesTxt.Location = new System.Drawing.Point(484, 98);
            this.caloriesTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.caloriesTxt.Name = "caloriesTxt";
            this.caloriesTxt.PlaceholderText = "Insira calorias";
            this.caloriesTxt.Size = new System.Drawing.Size(190, 27);
            this.caloriesTxt.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 272);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(866, 311);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(14, 140);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(866, 123);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "SISTEMA DE GESTÃO DE RCEITAS CULINÁRIAS";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.caloriesTxt);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recipieNameTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox recipieNameTxt;
        private Button button1;
        private TextBox authorTxt;
        private TextBox timeTxt;
        private TextBox caloriesTxt;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label1;
    }
}