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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntRecipeInsert = new System.Windows.Forms.Button();
            this.txtBoxRecipePreparingTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRecipeCalories = new System.Windows.Forms.TextBox();
            this.txtBoxRecipeName = new System.Windows.Forms.TextBox();
            this.txtBoxRecipeDuration = new System.Windows.Forms.TextBox();
            this.txtBoxRecipeAuthorName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIngredientInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxIngreRecipeName = new System.Windows.Forms.TextBox();
            this.txtBoxIngredientName = new System.Windows.Forms.TextBox();
            this.txtBoxIngredientQuanity = new System.Windows.Forms.TextBox();
            this.textBoxIngredientDescription = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtBoxStepRecipeName = new System.Windows.Forms.TextBox();
            this.btnStepInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxStepNumber = new System.Windows.Forms.TextBox();
            this.txtBoxStepDescriptio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE GESTÃO DE RCEITAS CULINÁRIAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(395, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "INSERIR OS DADOS DE ACORDO A ORDEM NUMÉRICA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bntRecipeInsert);
            this.groupBox1.Controls.Add(this.txtBoxRecipePreparingTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxRecipeCalories);
            this.groupBox1.Controls.Add(this.txtBoxRecipeName);
            this.groupBox1.Controls.Add(this.txtBoxRecipeDuration);
            this.groupBox1.Controls.Add(this.txtBoxRecipeAuthorName);
            this.groupBox1.Location = new System.Drawing.Point(31, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 449);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RECEITA";
            // 
            // bntRecipeInsert
            // 
            this.bntRecipeInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.bntRecipeInsert.ForeColor = System.Drawing.Color.Black;
            this.bntRecipeInsert.Location = new System.Drawing.Point(87, 372);
            this.bntRecipeInsert.Name = "bntRecipeInsert";
            this.bntRecipeInsert.Size = new System.Drawing.Size(113, 39);
            this.bntRecipeInsert.TabIndex = 4;
            this.bntRecipeInsert.Text = "INSERIR";
            this.bntRecipeInsert.UseVisualStyleBackColor = false;
            this.bntRecipeInsert.Click += new System.EventHandler(this.bntRecipeInsert_Click);
            // 
            // txtBoxRecipePreparingTime
            // 
            this.txtBoxRecipePreparingTime.Location = new System.Drawing.Point(16, 291);
            this.txtBoxRecipePreparingTime.Name = "txtBoxRecipePreparingTime";
            this.txtBoxRecipePreparingTime.PlaceholderText = "Insira o tempo de preparação";
            this.txtBoxRecipePreparingTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRecipePreparingTime.Size = new System.Drawing.Size(276, 27);
            this.txtBoxRecipePreparingTime.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(334, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxRecipeCalories
            // 
            this.txtBoxRecipeCalories.Location = new System.Drawing.Point(16, 232);
            this.txtBoxRecipeCalories.Name = "txtBoxRecipeCalories";
            this.txtBoxRecipeCalories.PlaceholderText = "Insira a caloria";
            this.txtBoxRecipeCalories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRecipeCalories.Size = new System.Drawing.Size(276, 27);
            this.txtBoxRecipeCalories.TabIndex = 7;
            // 
            // txtBoxRecipeName
            // 
            this.txtBoxRecipeName.Location = new System.Drawing.Point(16, 68);
            this.txtBoxRecipeName.Name = "txtBoxRecipeName";
            this.txtBoxRecipeName.PlaceholderText = "Insira o nome";
            this.txtBoxRecipeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRecipeName.Size = new System.Drawing.Size(276, 27);
            this.txtBoxRecipeName.TabIndex = 4;
            // 
            // txtBoxRecipeDuration
            // 
            this.txtBoxRecipeDuration.Location = new System.Drawing.Point(16, 179);
            this.txtBoxRecipeDuration.Name = "txtBoxRecipeDuration";
            this.txtBoxRecipeDuration.PlaceholderText = "Insira a duração";
            this.txtBoxRecipeDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRecipeDuration.Size = new System.Drawing.Size(276, 27);
            this.txtBoxRecipeDuration.TabIndex = 6;
            // 
            // txtBoxRecipeAuthorName
            // 
            this.txtBoxRecipeAuthorName.Location = new System.Drawing.Point(16, 125);
            this.txtBoxRecipeAuthorName.Name = "txtBoxRecipeAuthorName";
            this.txtBoxRecipeAuthorName.PlaceholderText = "Insira o autor";
            this.txtBoxRecipeAuthorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRecipeAuthorName.Size = new System.Drawing.Size(276, 27);
            this.txtBoxRecipeAuthorName.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIngredientInsert);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxIngreRecipeName);
            this.groupBox2.Controls.Add(this.txtBoxIngredientName);
            this.groupBox2.Controls.Add(this.txtBoxIngredientQuanity);
            this.groupBox2.Controls.Add(this.textBoxIngredientDescription);
            this.groupBox2.Location = new System.Drawing.Point(422, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 449);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INGREDIENTES";
            // 
            // btnIngredientInsert
            // 
            this.btnIngredientInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIngredientInsert.ForeColor = System.Drawing.Color.Black;
            this.btnIngredientInsert.Location = new System.Drawing.Point(104, 372);
            this.btnIngredientInsert.Name = "btnIngredientInsert";
            this.btnIngredientInsert.Size = new System.Drawing.Size(113, 39);
            this.btnIngredientInsert.TabIndex = 4;
            this.btnIngredientInsert.Text = "INSERIR";
            this.btnIngredientInsert.UseVisualStyleBackColor = false;
            this.btnIngredientInsert.Click += new System.EventHandler(this.btnIngredientInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(293, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "2";
            // 
            // txtBoxIngreRecipeName
            // 
            this.txtBoxIngreRecipeName.Location = new System.Drawing.Point(16, 232);
            this.txtBoxIngreRecipeName.Name = "txtBoxIngreRecipeName";
            this.txtBoxIngreRecipeName.PlaceholderText = "Insira o nome da receita";
            this.txtBoxIngreRecipeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxIngreRecipeName.Size = new System.Drawing.Size(276, 27);
            this.txtBoxIngreRecipeName.TabIndex = 7;
            // 
            // txtBoxIngredientName
            // 
            this.txtBoxIngredientName.Location = new System.Drawing.Point(16, 68);
            this.txtBoxIngredientName.Name = "txtBoxIngredientName";
            this.txtBoxIngredientName.PlaceholderText = "Insira o nome";
            this.txtBoxIngredientName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxIngredientName.Size = new System.Drawing.Size(276, 27);
            this.txtBoxIngredientName.TabIndex = 4;
            // 
            // txtBoxIngredientQuanity
            // 
            this.txtBoxIngredientQuanity.Location = new System.Drawing.Point(16, 179);
            this.txtBoxIngredientQuanity.Name = "txtBoxIngredientQuanity";
            this.txtBoxIngredientQuanity.PlaceholderText = "Insira a quantidade";
            this.txtBoxIngredientQuanity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxIngredientQuanity.Size = new System.Drawing.Size(276, 27);
            this.txtBoxIngredientQuanity.TabIndex = 6;
            // 
            // textBoxIngredientDescription
            // 
            this.textBoxIngredientDescription.Location = new System.Drawing.Point(16, 125);
            this.textBoxIngredientDescription.Multiline = true;
            this.textBoxIngredientDescription.Name = "textBoxIngredientDescription";
            this.textBoxIngredientDescription.PlaceholderText = "Insira a descrição";
            this.textBoxIngredientDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxIngredientDescription.Size = new System.Drawing.Size(276, 27);
            this.textBoxIngredientDescription.TabIndex = 5;
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
            this.groupBox3.Controls.Add(this.txtBoxStepRecipeName);
            this.groupBox3.Controls.Add(this.btnStepInsert);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtBoxStepNumber);
            this.groupBox3.Controls.Add(this.txtBoxStepDescriptio);
            this.groupBox3.Location = new System.Drawing.Point(809, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 449);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STEP";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUploadImage.BackgroundImage")));
            this.btnUploadImage.Location = new System.Drawing.Point(25, 232);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(267, 127);
            this.btnUploadImage.TabIndex = 9;
            this.btnUploadImage.Text = "Upload image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            // 
            // txtBoxStepRecipeName
            // 
            this.txtBoxStepRecipeName.Location = new System.Drawing.Point(16, 179);
            this.txtBoxStepRecipeName.Name = "txtBoxStepRecipeName";
            this.txtBoxStepRecipeName.PlaceholderText = "Insira o nome da receita";
            this.txtBoxStepRecipeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxStepRecipeName.Size = new System.Drawing.Size(276, 27);
            this.txtBoxStepRecipeName.TabIndex = 8;
            // 
            // btnStepInsert
            // 
            this.btnStepInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStepInsert.ForeColor = System.Drawing.Color.Black;
            this.btnStepInsert.Location = new System.Drawing.Point(104, 372);
            this.btnStepInsert.Name = "btnStepInsert";
            this.btnStepInsert.Size = new System.Drawing.Size(113, 39);
            this.btnStepInsert.TabIndex = 4;
            this.btnStepInsert.Text = "INSERIR";
            this.btnStepInsert.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(293, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "3";
            // 
            // txtBoxStepNumber
            // 
            this.txtBoxStepNumber.Location = new System.Drawing.Point(16, 68);
            this.txtBoxStepNumber.Name = "txtBoxStepNumber";
            this.txtBoxStepNumber.PlaceholderText = "Insira o número";
            this.txtBoxStepNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxStepNumber.Size = new System.Drawing.Size(276, 27);
            this.txtBoxStepNumber.TabIndex = 7;
            this.txtBoxStepNumber.TextChanged += new System.EventHandler(this.txtBoxStepNumber_TextChanged);
            // 
            // txtBoxStepDescriptio
            // 
            this.txtBoxStepDescriptio.Location = new System.Drawing.Point(16, 125);
            this.txtBoxStepDescriptio.Name = "txtBoxStepDescriptio";
            this.txtBoxStepDescriptio.PlaceholderText = "Insira a descrição";
            this.txtBoxStepDescriptio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxStepDescriptio.Size = new System.Drawing.Size(276, 27);
            this.txtBoxStepDescriptio.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private TextBox txtBoxRecipeDuration;
        private Button bntRecipeInsert;
        private TextBox txtBoxRecipePreparingTime;
        private TextBox txtBoxRecipeCalories;
        private GroupBox groupBox2;
        private Button btnIngredientInsert;
        private Label label4;
        private TextBox txtBoxIngreRecipeName;
        private TextBox txtBoxIngredientName;
        private TextBox txtBoxIngredientQuanity;
        private TextBox textBoxIngredientDescription;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox3;
        private Button btnStepInsert;
        private Label label5;
        private TextBox txtBoxStepNumber;
        private TextBox txtBoxStepDescriptio;
        private Button btnUploadImage;
        private TextBox txtBoxStepRecipeName;
        private Label label6;

        public EventHandler btnStepInsert_click { get; private set; }
    }
}
