using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD2122
{
    public partial class Form2 : Form
    {
        private DBManager dbManager;
        public Form2()
        {
            InitializeComponent();
            this.dbManager = new DBManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recipie r = dbManager.getRecipie(recipieNameTxt.Text);

            if (r == null)
                return;

            authorTxt.Text = r.author;
            timeTxt.Text = r.preparingTime.ToString();
            caloriesTxt.Text = r.calories.ToString();

            List<string> steps = dbManager.listSteps(r.name);
            
            foreach (string step in steps)
            {
                richTextBox1.Text += step + '\n';
            }
        }
    }
}
