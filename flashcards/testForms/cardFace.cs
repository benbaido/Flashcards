using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashcards.testForms
{
    public partial class cardFace : Form
    {
        public cardFace()
        {
            InitializeComponent();
        }

        

        OpenFileDialog openPackDialog = new OpenFileDialog();

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //filter. before | is the little reminder and after | is what it actually is.
            openPackDialog.Filter = "png|*.png";

            //if you actually select a file it doesn't break w00t
            if (openPackDialog.ShowDialog() == DialogResult.OK)
            {
                //just the file name
                tbOpenFile.Text = openPackDialog.SafeFileName;
                //file name w/ address the whole string
                tbFileOpened.Text = openPackDialog.FileName;

            }
        }
    }
}
