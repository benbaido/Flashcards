using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashcards
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnTestCards_Click(object sender, EventArgs e)
        {
            testForms.testCards test = new testForms.testCards();
            test.Show();
        }

        private void btnTestPacks_Click(object sender, EventArgs e)
        {
            testForms.testPack test = new testForms.testPack();
            test.Show();
        }
    }
}
