namespace BD2122
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntRecipeInsert = new System.Windows.Forms.Button();
            this.txtBoxRecipePreparingTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRecipeCalories = new System.Windows.Forms.TextBox();
            this.txtBoxRecipeName = new System.Windows.Forms.TextBox();
            this.txtBoxRecipeAuthorName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIngredientInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxIngredientName = new System.Windows.Forms.TextBox();
            this.txtBoxIngredientDescription = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.btnStepInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxStepNumber = new System.Windows.Forms.TextBox();
            this.txtBoxStepDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCategoryInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxCategoryName = new System.Windows.Forms.TextBox();
            this.txtBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtBoxUnitUtensil = new System.Windows.Forms.TextBox();
            this.btnUtensilInsert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxNameUtensil = new System.Windows.Forms.TextBox();
            this.txtBoxDimensionUtensil = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(319, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE GESTÃO DE RCEITAS CULINÁRIAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(389, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "INSERIR OS DADOS DE ACORDO A ORDEM NUMÉRICA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntRecipeInsert);
            this.groupBox1.Controls.Add(this.txtBoxRecipePreparingTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxRecipeCalories);
            this.groupBox1.Controls.Add(this.txtBoxRecipeName);
            this.groupBox1.Controls.Add(this.txtBoxRecipeAuthorName);
            this.groupBox1.Location = new System.Drawing.Point(27, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(315, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECEITA";
            // 
            // bntRecipeInsert
            // 
            this.bntRecipeInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.bntRecipeInsert.ForeColor = System.Drawing.Color.Black;
            this.bntRecipeInsert.Location = new System.Drawing.Point(86, 199);
            this.bntRecipeInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntRecipeInsert.Name = "bntRecipeInsert";
            this.bntRecipeInsert.Size = new System.Drawing.Size(99, 29);
            this.bntRecipeInsert.TabIndex = 4;
            this.bntRecipeInsert.Text = "INSERIR";
            this.bntRecipeInsert.UseVisualStyleBackColor = false;
            this.bntRecipeInsert.Click += new System.EventHandler(this.bntRecipeInsert_Click);
            // 
            // txtBoxRecipePreparingTime
            // 
            this.txtBoxRecipePreparingTime.Location = new System.Drawing.Point(14, 161);
            this.txtBoxRecipePreparingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxRecipePreparingTime.Name = "txtBoxRecipePreparingTime";
            this.txtBoxRecipePreparingTime.PlaceholderText = "Insira o tempo de preparação";
            this.txtBoxRecipePreparingTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRecipePreparingTime.Size = new System.Drawing.Size(275, 23);
            this.txtBoxRecipePreparingTime.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(292, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxRecipeCalories
            // 
            this.txtBoxRecipeCalories.Location = new System.Drawing.Point(16, 125);
            this.txtBoxRecipeCalories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxRecipeCalories.Name = "txtBoxRecipeCalories";
            this.txtBoxRecipeCalories.PlaceholderText = "Insira a caloria";
            this.txtBoxRecipeCalories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRecipeCalories.Size = new System.Drawing.Size(274, 23);
            this.txtBoxRecipeCalories.TabIndex = 7;
            // 
            // txtBoxRecipeName
            // 
            this.txtBoxRecipeName.Location = new System.Drawing.Point(16, 51);
            this.txtBoxRecipeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxRecipeName.Name = "txtBoxRecipeName";
            this.txtBoxRecipeName.PlaceholderText = "Insira o nome";
            this.txtBoxRecipeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRecipeName.Size = new System.Drawing.Size(274, 23);
            this.txtBoxRecipeName.TabIndex = 4;
            // 
            // txtBoxRecipeAuthorName
            // 
            this.txtBoxRecipeAuthorName.Location = new System.Drawing.Point(14, 87);
            this.txtBoxRecipeAuthorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxRecipeAuthorName.Name = "txtBoxRecipeAuthorName";
            this.txtBoxRecipeAuthorName.PlaceholderText = "Insira o autor";
            this.txtBoxRecipeAuthorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRecipeAuthorName.Size = new System.Drawing.Size(275, 23);
            this.txtBoxRecipeAuthorName.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIngredientInsert);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxIngredientName);
            this.groupBox2.Controls.Add(this.txtBoxIngredientDescription);
            this.groupBox2.Location = new System.Drawing.Point(422, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(315, 252);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INGREDIENTES";
            // 
            // btnIngredientInsert
            // 
            this.btnIngredientInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIngredientInsert.ForeColor = System.Drawing.Color.Black;
            this.btnIngredientInsert.Location = new System.Drawing.Point(100, 199);
            this.btnIngredientInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngredientInsert.Name = "btnIngredientInsert";
            this.btnIngredientInsert.Size = new System.Drawing.Size(99, 29);
            this.btnIngredientInsert.TabIndex = 4;
            this.btnIngredientInsert.Text = "INSERIR";
            this.btnIngredientInsert.UseVisualStyleBackColor = false;
            this.btnIngredientInsert.Click += new System.EventHandler(this.btnIngredientInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(295, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "3";
            // 
            // txtBoxIngredientName
            // 
            this.txtBoxIngredientName.Location = new System.Drawing.Point(12, 51);
            this.txtBoxIngredientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxIngredientName.Name = "txtBoxIngredientName";
            this.txtBoxIngredientName.PlaceholderText = "Insira o nome";
            this.txtBoxIngredientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxIngredientName.Size = new System.Drawing.Size(275, 23);
            this.txtBoxIngredientName.TabIndex = 4;
            // 
            // txtBoxIngredientDescription
            // 
            this.txtBoxIngredientDescription.Location = new System.Drawing.Point(14, 87);
            this.txtBoxIngredientDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxIngredientDescription.Multiline = true;
            this.txtBoxIngredientDescription.Name = "txtBoxIngredientDescription";
            this.txtBoxIngredientDescription.PlaceholderText = "Insira a descrição";
            this.txtBoxIngredientDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxIngredientDescription.Size = new System.Drawing.Size(274, 21);
            this.txtBoxIngredientDescription.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUploadImage);
            this.groupBox3.Controls.Add(this.btnStepInsert);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtBoxStepNumber);
            this.groupBox3.Controls.Add(this.txtBoxStepDescription);
            this.groupBox3.Location = new System.Drawing.Point(805, 80);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(315, 508);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STEP";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUploadImage.Location = new System.Drawing.Point(26, 125);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(267, 202);
            this.btnUploadImage.TabIndex = 10;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // btnStepInsert
            // 
            this.btnStepInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStepInsert.ForeColor = System.Drawing.Color.Black;
            this.btnStepInsert.Location = new System.Drawing.Point(123, 460);
            this.btnStepInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStepInsert.Name = "btnStepInsert";
            this.btnStepInsert.Size = new System.Drawing.Size(99, 29);
            this.btnStepInsert.TabIndex = 4;
            this.btnStepInsert.Text = "INSERIR";
            this.btnStepInsert.UseVisualStyleBackColor = false;
            this.btnStepInsert.Click += new System.EventHandler(this.btnStepInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(295, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "5";
            // 
            // txtBoxStepNumber
            // 
            this.txtBoxStepNumber.Location = new System.Drawing.Point(16, 41);
            this.txtBoxStepNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxStepNumber.Name = "txtBoxStepNumber";
            this.txtBoxStepNumber.PlaceholderText = "Insira o número";
            this.txtBoxStepNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxStepNumber.Size = new System.Drawing.Size(278, 23);
            this.txtBoxStepNumber.TabIndex = 7;
            this.txtBoxStepNumber.TextChanged += new System.EventHandler(this.txtBoxStepNumber_TextChanged);
            // 
            // txtBoxStepDescription
            // 
            this.txtBoxStepDescription.Location = new System.Drawing.Point(16, 77);
            this.txtBoxStepDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxStepDescription.Name = "txtBoxStepDescription";
            this.txtBoxStepDescription.PlaceholderText = "Insira a descrição";
            this.txtBoxStepDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxStepDescription.Size = new System.Drawing.Size(278, 23);
            this.txtBoxStepDescription.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(913, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "PESQUISAR RECEITA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(298, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCategoryInsert);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtBoxCategoryName);
            this.groupBox4.Controls.Add(this.txtBoxCategoryDescription);
            this.groupBox4.Location = new System.Drawing.Point(27, 337);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(315, 252);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CATEGORIA";
            // 
            // btnCategoryInsert
            // 
            this.btnCategoryInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCategoryInsert.ForeColor = System.Drawing.Color.Black;
            this.btnCategoryInsert.Location = new System.Drawing.Point(86, 204);
            this.btnCategoryInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategoryInsert.Name = "btnCategoryInsert";
            this.btnCategoryInsert.Size = new System.Drawing.Size(99, 29);
            this.btnCategoryInsert.TabIndex = 4;
            this.btnCategoryInsert.Text = "INSERIR";
            this.btnCategoryInsert.UseVisualStyleBackColor = false;
            this.btnCategoryInsert.Click += new System.EventHandler(this.btnCategoryInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(292, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "2";
            // 
            // txtBoxCategoryName
            // 
            this.txtBoxCategoryName.Location = new System.Drawing.Point(16, 51);
            this.txtBoxCategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxCategoryName.Name = "txtBoxCategoryName";
            this.txtBoxCategoryName.PlaceholderText = "Insira o nome";
            this.txtBoxCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxCategoryName.Size = new System.Drawing.Size(274, 23);
            this.txtBoxCategoryName.TabIndex = 4;
            // 
            // txtBoxCategoryDescription
            // 
            this.txtBoxCategoryDescription.Location = new System.Drawing.Point(14, 94);
            this.txtBoxCategoryDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxCategoryDescription.Name = "txtBoxCategoryDescription";
            this.txtBoxCategoryDescription.PlaceholderText = "Insira a descrição";
            this.txtBoxCategoryDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxCategoryDescription.Size = new System.Drawing.Size(275, 23);
            this.txtBoxCategoryDescription.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtBoxUnitUtensil);
            this.groupBox5.Controls.Add(this.btnUtensilInsert);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtBoxNameUtensil);
            this.groupBox5.Controls.Add(this.txtBoxDimensionUtensil);
            this.groupBox5.Location = new System.Drawing.Point(434, 350);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(315, 239);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "UTENSÍLIOS";
            // 
            // txtBoxUnitUtensil
            // 
            this.txtBoxUnitUtensil.Location = new System.Drawing.Point(12, 127);
            this.txtBoxUnitUtensil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxUnitUtensil.Multiline = true;
            this.txtBoxUnitUtensil.Name = "txtBoxUnitUtensil";
            this.txtBoxUnitUtensil.PlaceholderText = "Insira  unidade";
            this.txtBoxUnitUtensil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxUnitUtensil.Size = new System.Drawing.Size(274, 21);
            this.txtBoxUnitUtensil.TabIndex = 6;
            // 
            // btnUtensilInsert
            // 
            this.btnUtensilInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUtensilInsert.ForeColor = System.Drawing.Color.Black;
            this.btnUtensilInsert.Location = new System.Drawing.Point(102, 191);
            this.btnUtensilInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUtensilInsert.Name = "btnUtensilInsert";
            this.btnUtensilInsert.Size = new System.Drawing.Size(99, 29);
            this.btnUtensilInsert.TabIndex = 4;
            this.btnUtensilInsert.Text = "INSERIR";
            this.btnUtensilInsert.UseVisualStyleBackColor = false;
            this.btnUtensilInsert.Click += new System.EventHandler(this.btnUtensilInsert_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(295, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "4";
            // 
            // txtBoxNameUtensil
            // 
            this.txtBoxNameUtensil.Location = new System.Drawing.Point(12, 51);
            this.txtBoxNameUtensil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNameUtensil.Name = "txtBoxNameUtensil";
            this.txtBoxNameUtensil.PlaceholderText = "Insira o nome";
            this.txtBoxNameUtensil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxNameUtensil.Size = new System.Drawing.Size(275, 23);
            this.txtBoxNameUtensil.TabIndex = 4;
            // 
            // txtBoxDimensionUtensil
            // 
            this.txtBoxDimensionUtensil.Location = new System.Drawing.Point(14, 87);
            this.txtBoxDimensionUtensil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDimensionUtensil.Multiline = true;
            this.txtBoxDimensionUtensil.Name = "txtBoxDimensionUtensil";
            this.txtBoxDimensionUtensil.PlaceholderText = "Insira a dimensão";
            this.txtBoxDimensionUtensil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxDimensionUtensil.Size = new System.Drawing.Size(274, 21);
            this.txtBoxDimensionUtensil.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 600);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private TextBox txtBoxRecipeName;
        private TextBox txtBoxRecipeAuthorName;
        private Button bntRecipeInsert;
        private TextBox txtBoxRecipePreparingTime;
        private TextBox txtBoxRecipeCalories;
        private GroupBox groupBox2;
        private Button btnIngredientInsert;
        private Label label4;
        private TextBox txtBoxIngredientName;
        private TextBox txtBoxIngredientDescription;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox3;
        private Button btnStepInsert;
        private Label label5;
        private TextBox txtBoxStepNumber;
        private TextBox txtBoxStepDescription;
        private Button btnUploadImage;

        private Button button1;

        private Label label6;
        private GroupBox groupBox4;
        private Button btnCategoryInsert;
        private Label label7;
        private TextBox txtBoxCategoryName;
        private TextBox txtBoxCategoryDescription;
        private GroupBox groupBox5;
        private TextBox txtBoxUnitUtensil;
        private Button btnUtensilInsert;
        private Label label8;
        private TextBox txtBoxNameUtensil;
        private TextBox txtBoxDimensionUtensil;
        private EventHandler btnUploadImage_Click;

        public EventHandler btnStepInsert_click { get; private set; }
           
    }
}
