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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRecipeName = new System.Windows.Forms.TextBox();
            this.txtBoxAuthorName = new System.Windows.Forms.TextBox();
            this.txtBoxDuration = new System.Windows.Forms.TextBox();
            this.txtBoxCalories = new System.Windows.Forms.TextBox();
            this.txtBoxPreparingTime = new System.Windows.Forms.TextBox();
            this.bntRecipeSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE GESTÃO DE RCEITAS CULINÁRIAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(360, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "INSERIR DADOS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntRecipeSubmit);
            this.groupBox1.Controls.Add(this.txtBoxPreparingTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxCalories);
            this.groupBox1.Controls.Add(this.txtBoxRecipeName);
            this.groupBox1.Controls.Add(this.txtBoxDuration);
            this.groupBox1.Controls.Add(this.txtBoxAuthorName);
            this.groupBox1.Location = new System.Drawing.Point(31, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 449);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(292, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxRecipeName
            // 
            this.txtBoxRecipeName.Location = new System.Drawing.Point(16, 68);
            this.txtBoxRecipeName.Name = "txtBoxRecipeName";
            this.txtBoxRecipeName.PlaceholderText = "Ensira o nome";
            this.txtBoxRecipeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRecipeName.Size = new System.Drawing.Size(276, 27);
            this.txtBoxRecipeName.TabIndex = 4;
            // 
            // txtBoxAuthorName
            // 
            this.txtBoxAuthorName.Location = new System.Drawing.Point(16, 126);
            this.txtBoxAuthorName.Name = "txtBoxAuthorName";
            this.txtBoxAuthorName.PlaceholderText = "Ensira o autor";
            this.txtBoxAuthorName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxAuthorName.Size = new System.Drawing.Size(276, 27);
            this.txtBoxAuthorName.TabIndex = 5;
            // 
            // txtBoxDuration
            // 
            this.txtBoxDuration.Location = new System.Drawing.Point(16, 179);
            this.txtBoxDuration.Name = "txtBoxDuration";
            this.txtBoxDuration.PlaceholderText = "Ensira a duração";
            this.txtBoxDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxDuration.Size = new System.Drawing.Size(276, 27);
            this.txtBoxDuration.TabIndex = 6;
            // 
            // txtBoxCalories
            // 
            this.txtBoxCalories.Location = new System.Drawing.Point(16, 232);
            this.txtBoxCalories.Name = "txtBoxCalories";
            this.txtBoxCalories.PlaceholderText = "Ensira a caloria";
            this.txtBoxCalories.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxCalories.Size = new System.Drawing.Size(276, 27);
            this.txtBoxCalories.TabIndex = 7;
            // 
            // txtBoxPreparingTime
            // 
            this.txtBoxPreparingTime.Location = new System.Drawing.Point(16, 290);
            this.txtBoxPreparingTime.Name = "txtBoxPreparingTime";
            this.txtBoxPreparingTime.PlaceholderText = "Ensira o tempo de preparação";
            this.txtBoxPreparingTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxPreparingTime.Size = new System.Drawing.Size(276, 27);
            this.txtBoxPreparingTime.TabIndex = 8;
            // 
            // bntRecipeSubmit
            // 
            this.bntRecipeSubmit.BackColor = System.Drawing.Color.RoyalBlue;
            this.bntRecipeSubmit.ForeColor = System.Drawing.Color.Black;
            this.bntRecipeSubmit.Location = new System.Drawing.Point(92, 387);
            this.bntRecipeSubmit.Name = "bntRecipeSubmit";
            this.bntRecipeSubmit.Size = new System.Drawing.Size(113, 39);
            this.bntRecipeSubmit.TabIndex = 4;
            this.bntRecipeSubmit.Text = "INSERIR";
            this.bntRecipeSubmit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private TextBox txtBoxAuthorName;
        private TextBox txtBoxDuration;
        private Button bntRecipeSubmit;
        private TextBox txtBoxPreparingTime;
        private TextBox txtBoxCalories;
    }
}