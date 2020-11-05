#define COLOR

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.RegularExpressions;

namespace SortedTree
{
    /// <summary>
    /// Ursprunget till det här programmet kommer från
    /// program-exemplet SortedTree, vilket hör till boken
    /// Essential Algorithms, skriven av Rod Stephans.
    /// Fyll på med egen information... .
    /// Namn:
    /// Datum:
    /// </summary>
    public partial class ProgramGUI : Form
    {
        private ITree tree = null;

        #region Drawing Methods
        private void treePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Position the tree.
            if (tree != null && tree.Count > 0)
            {
                (tree as Tree).PositionSubtree(10, 10);

                // Draw the links.
                (tree as Tree).DrawSubtreeLinks(e.Graphics, Pens.Blue);

                // Draw the nodes.
                (tree as Tree).DrawSubtreeNodes(e.Graphics, this.Font,
                    Brushes.Blue, Brushes.LightBlue, Pens.Blue);
            }
        }
        #endregion

        public ProgramGUI()
        {
            InitializeComponent();
        }

        private void ProgramGUI_Load(object sender, EventArgs e)
        {
            tree = new Tree();
            UpdateGUI();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxKey.Text))
                return;

            string key = textBoxKey.Text.Trim();
            tree.Add(key, 0);

            UpdateGUI();
        }

        private void UpdateGUI()
        {
            textBoxKey.Clear();
            textBoxKey.Focus();
            PictureBoxTree.Refresh();
        }

        private void TraverseButton_Click(object sender, EventArgs e)
        {
            TraverseListbox.Items.Clear();
            tree.Traverse(TraverseListbox);
        }

        private void TreeContains_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxKey.Text))
                return;

            string key = textBoxKey.Text.Trim();
            if (tree.Contains(key)) { MessageBox.Show(key + " is in the tree"); }
            else
            {
                MessageBox.Show(key + " is not in the tree");
            }

        }

        private void GetValue_Button_Click(object sender, EventArgs e)
        {

            UserInput getorset = new UserInput(tree);
            getorset.ShowDialog();
        }

        private void TreeHeight_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tree height is: " + tree.Height());
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxKey.Text))
                return;

            string key = textBoxKey.Text.Trim();
            tree.Remove(key);

            UpdateGUI();
        }

        private void SaveToFile_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            saveFileDialog1.Title = "Save Text File";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "TXT files|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tree.Traverse(saveFileDialog1.FileName);
            }
        }

        private void ImportTxtButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string pathToFile = "";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(theDialog.FileName.ToString());
                pathToFile = theDialog.FileName;

            }

            if (File.Exists(pathToFile))
            {

                string text;
                using (StreamReader sr = new StreamReader(pathToFile))
                {
                    text = sr.ReadToEnd().ToLower();
                }
                text = text.Replace(Environment.NewLine, " ");
                Regex reg_exp = new Regex("[^a-zA-Z0-9]");
                text = reg_exp.Replace(text, " ");
                string[] textarray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in textarray)
                {
                    if (!tree.Contains(word))
                    {
                        tree.Add(word, 1);
                    }
                    else
                    {
                        int currentvalue = tree.Get(word);
                        tree.Set(word, currentvalue + 1);
                    }
                }
                UpdateGUI();
            }
        }

    }
}
