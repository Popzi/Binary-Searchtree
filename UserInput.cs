using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortedTree
{
    public partial class UserInput : Form
    {
        private ITree tree = null;
        public UserInput(ITree _tree)
        {
            InitializeComponent();
            tree = _tree;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetValue_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxKey.Text))
                return;

            string key = textBoxKey.Text.Trim();
            int result = tree.Get(key);
            if (result != -1) { textBoxValue.Text = result.ToString(); }
            else
            {
                textBoxValue.Text = key + " finns ej i trädet.";
            }
        }

        private void SetValue_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxKey.Text))
                return;

            string key = textBoxKey.Text.Trim();
            int newValue = Convert.ToInt32(textBoxValue.Text.Trim());
            int result = tree.Get(key);
            if (result != -1) {
                tree.Set(key, newValue);
            }
            else
            {
                textBoxValue.Text = key + " finns ej i trädet.";
            }
        }
    }
}
