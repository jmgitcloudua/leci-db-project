using System.Windows.Forms;

namespace BD2122
{
    public partial class Form1 : Form
    {

        private DBManager dbManager;

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

        }

        private void btnIngredientInsert_Click(object sender, EventArgs e)
        {

            dbManager.insertIngredient(txtBoxIngredientName.Text, txtBoxStepDescriptio.Text)
        }
    }
}