using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Words_Concatenation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            //check if a word entered in the text box
            string word=txtNewWord.Text.Trim();
            if (!String.IsNullOrEmpty(word) && !comboBoxAnother.Items.Contains(word))
            {
                comboBoxWord.Items.Add(txtNewWord.Text.Trim());
                comboBoxAnother.Items.Add(txtNewWord.Text.Trim());
                MessageBox.Show(word + " has been succefully added");
            }
            else
            {
                MessageBox.Show("Error: Please enter a word or check if the word has not been added already");
            }
            //Ensuring that words have been selected from combo boxes
            string selectedWord1 = comboBoxWord.SelectedItem as string;
            string selectedWord2=comboBoxAnother.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedWord1) && string.IsNullOrEmpty(selectedWord2))
            {
                MessageBox.Show("Please select a word for each combo box");
            }
            else
            {
                MessageBox.Show("You have selected words " + selectedWord1 + " " +  selectedWord2);
            }

        }

        private void comboBoxWord_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void radioBtnWord_CheckedChanged(object sender, EventArgs e)
        {
            //radio button checked the concatenate button must read Remove item
            if (radioBtnWord.Checked)
            {
                btnConcatenate.Text = "Remove Item";
            }
        }

        private void btnConcatenate_Click(object sender, EventArgs e)
        {
            //Removing selected item from combo box
            if (radioBtnWord.Checked)
            {
                if (comboBoxWord.SelectedIndex >= 0)
                {
                    comboBoxWord.Items.RemoveAt(comboBoxWord.SelectedIndex);
                    MessageBox.Show(comboBoxWord.Text + " has been succefully removed");
                }
            }
            else if (radioBtnAnother.Checked)
            {
                if (comboBoxAnother.SelectedIndex >= 0)
                {
                    comboBoxAnother.Items.RemoveAt(comboBoxAnother.SelectedIndex);
                    MessageBox.Show(comboBoxAnother.Text + " has been succefully removed");
                }
            }
            //Ensuring that different words have been selected from the combo boxes
            if (comboBoxWord.SelectedItem != null && comboBoxAnother.SelectedItem != null)
            {
                MessageBox.Show("Success both combo boxes have selected items");
            }
            else
            {
                MessageBox.Show("Please select an item from both ComboBoxes.");
            }

            string selectedItem1 = comboBoxWord.SelectedItem?.ToString();
            string selectedItem2 = comboBoxAnother.SelectedItem?.ToString();

            // Check if both ComboBoxes have a selected item
            if (!string.IsNullOrEmpty(selectedItem1) && !string.IsNullOrEmpty(selectedItem2))
            {
                // Check if the selected items are different
                if (selectedItem1 != selectedItem2)
                {
                    MessageBox.Show("Seccess different have been selected in both ComboBoxes.");
                }
                else
                {
                    MessageBox.Show("Please select different items in both ComboBoxes.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from both ComboBoxes.");
            }
            //displying in the label
            lblDisplay.Text=selectedItem1  + selectedItem2;
        }

    private void radioBtnAnother_CheckedChanged(object sender, EventArgs e)
        {
                btnConcatenate.Text = "Remove Item";
            
        }
    }
}
