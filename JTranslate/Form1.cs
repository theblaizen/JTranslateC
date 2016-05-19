using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace JTranslate
{
    public partial class JTranslateForm : Form
    {
        private Dictionary<string, string> dictionary_eng_por = new Dictionary<string, string>();
        private Dictionary<string, string> dictionary_por_eng = new Dictionary<string, string>();

        private long words_indict_; //count of dictinary words
        private long not_translated_words_; //count of not translated words
        private long words_original_; // count of words original
        private bool change_method; // seting eng/por or por/eng dictionary

        public JTranslateForm()
        {
            InitializeComponent();
            readFromFile();
            Install();
        }


        //pre init.
        private void Install()
        {
            lbWords.Text = words_indict_.ToString();
            cb.Items.Add("Eng/Por");
            cb.Items.Add("Por/Eng");
            cb.SelectedIndex = 0;
        }


        /**************************_EVENTS_*********************************/
        private void btnClear_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            lbPath.Text = "";
            lbNotTranslated.Text = "";
            lbOriginalWords.Text = "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string path = openFileDialog1.FileName;
                            tb1.Text = System.IO.File.ReadAllText(path);
                            lbPath.Text = path;

                            string original_w = tb1.Text;
                            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
                            string[] words_count = original_w.Split(separators, StringSplitOptions.RemoveEmptyEntries); ;

                            for (int i = 0; i < words_count.Length; i++)
                                words_original_++;

                            lbOriginalWords.Text = words_original_.ToString();
                            words_count = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb1.Text))
                MessageBox.Show("Nothing to translate.", "Error #87", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                translate();
                not_translated_words_ = 0;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb1.Text))
                MessageBox.Show("Nothing to save.", "Error #89", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                saveFileDialog1.Title = "Save translation";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                    {
                        sw.Write(tb2.Text);
                        sw.Close();
                    }
                }
            }
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            string buff = tb2.Text;
            tb1.Text = buff;
            tb2.Text = "";
        }


        /*************************_METHODS_*******************************/
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb.SelectedItem.ToString().Equals("Eng/Por"))
                change_method = true;
            else
                change_method = false;
        }

        private string capitalizeFirstLetter(string fresh, string original)
        {
            string original_copy = original.ToLower();

            if (original.Substring(0, 1).Equals(original_copy.Substring(0, 1)))
                return fresh;
            if (!original.Substring(0, 1).Equals(original_copy.Substring(0, 1)))
                return fresh.Substring(0, 1).ToUpper() + fresh.Substring(1);

            return fresh;
        }
        
        private void readFromFile()
        {
            string line = "", line2 = "";

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("data/dict.txt");

            while ((line = file.ReadLine()) != null)
            {
                line2 = file.ReadLine();

                if (!dictionary_eng_por.ContainsKey(line))
                    dictionary_eng_por.Add(line, line2);

                if (!dictionary_por_eng.ContainsKey(line2))
                    dictionary_por_eng.Add(line2, line);
                
                words_indict_++;
            }

            file.Close();
        }

        private void translate()
        {
            string original = tb1.Text, wrap = "", last_ = "", buff = "";
            string[] words_original = original.Split(' ');

            Dictionary<string, string> dict;
            if (change_method)
                dict = dictionary_eng_por;
            else
                dict = dictionary_por_eng;

            for (int i = 0; i < words_original.Length; i++)
            {
                wrap = words_original[i].ToLower();

                if (wrap.Length == 0) continue;

                if (dict.ContainsKey(wrap))
                {
                    buff = capitalizeFirstLetter(dict[wrap], words_original[i]);
                    last_ += buff + " ";
                }
                else if ( words_original[i][words_original[i].Length - 1] == '.' || words_original[i][words_original[i].Length - 1] == ','
                        || words_original[i][words_original[i].Length - 1] == '!' || words_original[i][words_original[i].Length - 1] == '?'
                        || words_original[i][words_original[i].Length - 1] == '-' || words_original[i][words_original[i].Length - 1] == ':'
                        || words_original[i][words_original[i].Length - 1] == ';' )
                {
                    if (dict.ContainsKey(words_original[i].Substring(0, words_original[i].Length - 1)))
                    {
                        buff = capitalizeFirstLetter(dict[words_original[i].Substring(0, words_original[i].Length - 1)], 
                            words_original[i].Substring(0, words_original[i].Length - 1));
                        last_ += buff + words_original[i][words_original[i].Length - 1] + " " + " ";
                    }
                    else
                    {
                        buff = capitalizeFirstLetter(words_original[i], words_original[i]);
                        last_ += buff + " ";
                        not_translated_words_++;
                    }
                }
                else
                {
                    buff = capitalizeFirstLetter(words_original[i], words_original[i]);
                    last_ += buff + " ";
                    not_translated_words_++;
                }
            }

            last_ = Regex.Replace(last_, @"\s+", " ");
            tb2.Text = last_;
            lbNotTranslated.Text = not_translated_words_.ToString();
        }

    }
}
