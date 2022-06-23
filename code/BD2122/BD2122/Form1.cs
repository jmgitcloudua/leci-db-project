using System.Windows.Forms;

namespace BD2122
{
    public partial class Form1 : Form
    {
        private DBManager dbManager;
        private int stepID = -1;
        
		public Form1()
        {
            InitializeComponent();
            this.dbManager = new DBManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxStepNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntRecipeInsert_Click(object sender, EventArgs e)
        {

            string recipeName = txtBoxRecipeName.Text;
            string recipeAuhorName = txtBoxRecipeAuthorName.Text;
            Int32 recipeCaloriesName = Int32.Parse(txtBoxRecipeCalories.Text);
            Int32 recipePreparingTime = Int32.Parse(txtBoxRecipePreparingTime.Text);
            dbManager.insertRecipie(recipeName, recipeAuhorName, recipeCaloriesName, recipePreparingTime);
            MessageBox.Show("Receita Salva com sucesso", "Inserir Receita", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIngredientInsert_Click(object sender, EventArgs e)
        {
            dbManager.addIngredientTran(txtBoxIngredientName.Text, txtBoxIngredientDescription.Text, stepID, 0, "g");
            //dbManager.addIngredientTran(txtBoxIngredientName.Text, txtBoxStepDescription.Text);
            MessageBox.Show("Ingrediente Salvo com sucesso", "Inserir Ingrediente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnUtensilInsert_Click(object sender, EventArgs e)
        {
            string utensilName = txtBoxNameUtensil.Text;
            Int32 utensilDimension = Int32.Parse(txtBoxDimensionUtensil.Text);  
            string utensilUnit   = txtBoxDimensionUtensil.Text;
            dbManager.insertUtensil(utensilName, utensilDimension, utensilUnit);
            MessageBox.Show("Utensílio Salvo com sucesso", "Inserir Utensílio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCategoryInsert_Click(object sender, EventArgs e)
        {
            dbManager.insertCategory(txtBoxCategoryName.Text, txtBoxCategoryDescription.Text);
            MessageBox.Show("Categoria Salvo com sucesso", "Inserir Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnStepInsert_Click(object sender, EventArgs e)
        {
            Int32 stepNum = Int32.Parse(txtBoxStepNumber.Text);
            string stepDescription = txtBoxStepDescription.Text;
            string stepImg = btnUploadImage.Text;
            string recipie = txtBoxRecipeName.Text;
            //dbManager.insertStep(stepNum, stepDescription, stepImg);
            dbManager.addStepTran(recipie, stepNum, stepDescription, stepImg);                                // ------------------------------------     
            MessageBox.Show("Step Salvo com sucesso", "Inserir Step", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFolder = new OpenFileDialog();
            openFolder.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                btnUploadImage.Image = new Bitmap(openFolder.FileName);
            }
        }
    }
}
