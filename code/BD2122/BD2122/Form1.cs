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

        private void bntRecipeInsert_click(object sender, EventArgs e)
        {
            ///set code here
        }

        private void btnIngredientInsert_click(object sender, EventArgs e)
        {
            ///set code here
        }

        private void btnStepInsert_click(object sender, EventArgs e)
        {
            ///set code here
        }

        private void btnUploadImage_click(object sender, EventArgs e)
        {
            ///set code here
        }
    }
}