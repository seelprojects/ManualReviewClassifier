using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualReviewClassifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> inputReviews { get; set; }
        private List<string> inputLabels { get; set; }
        string inputFileName = @"\Reviews.txt";
        string inputLabelName = @"\ReviewLabels.txt";


        /// <summary>
        /// Import Reviews from Selected File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importReviewsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(fileFolder.Text))
                {
                    inputReviews = new List<string>();
                    inputLabels = new List<string>();

                    using (var sR = new StreamReader(fileFolder.Text + inputFileName))
                    {
                        var line = "";
                        while ((line = sR.ReadLine()) != null)
                        {
                            inputReviews.Add(line);
                        }
                        sR.Close();
                    }

                    using (var sR = new StreamReader(fileFolder.Text + inputLabelName))
                    {
                        var line = "";
                        while ((line = sR.ReadLine()) != null)
                        {
                            inputLabels.Add(line);
                        }
                        sR.Close();
                    }
                    if (inputReviews.Count != inputLabels.Count)
                    {
                        MessageBox.Show("Input data or data label corrupted");
                    }
                    else
                    {
                        UpdateListView();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong with data import");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateListView()
        {
            if(dataListview.Items.Count > 0)
                dataListview.Items.Clear();

            dataListview.View = View.Details;
            ColumnHeader header0 = new ColumnHeader();
            header0.Text = "Index";
            header0.Width = 50;
            header0.TextAlign = HorizontalAlignment.Left;
            dataListview.Columns.Add(header0);

            dataListview.View = View.Details;
            ColumnHeader header1 = new ColumnHeader();
            header1.Text = "Review";
            header1.TextAlign = HorizontalAlignment.Left;
            dataListview.Columns.Add(header1);

            ColumnHeader header2 = new ColumnHeader();
            header2.Text = "Classification";
            header2.Width = 100;
            header2.TextAlign = HorizontalAlignment.Center;
            dataListview.Columns.Add(header2);

            for (int i = 0; i < inputReviews.Count; i++)
            {
                dataListview.Items.Add(new ListViewItem(new string[] { i.ToString(), inputReviews[i], inputLabels[i] }));
            }

            dataListview.GridLines = true;
            dataListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            dataListview.Columns[2].Width = 100;
            
            dataListview.Columns[1].Width = 660;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var actualLabel = inputLabels[dataListview.SelectedItems[0].Index];
                
                if (actualLabel.Contains("Dep")) { dependabilityCheckbox.Checked = true; } else { dependabilityCheckbox.Checked = false; }
                if (actualLabel.Contains("Per")) { performanceCheckbox.Checked = true; } else { performanceCheckbox.Checked = false; }
                if (actualLabel.Contains("Sup")) { supportabilityCheckbox.Checked = true; } else { supportabilityCheckbox.Checked = false; }
                if (actualLabel.Contains("Usa")) { usabilityCheckbox.Checked = true; } else { usabilityCheckbox.Checked = false; }
                if (actualLabel.Contains("Mis")) { miscellaneousCheckbox.Checked = true; } else { miscellaneousCheckbox.Checked = false; }
                
                previewTextbox.Text = inputReviews[dataListview.SelectedItems[0].Index];
            }
            catch { }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dependabilityButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedindex = dataListview.SelectedItems[0].Index;

                bool containsDep = false;
                bool containsPer = false;
                bool containsSup = false;
                bool containsUsa = false;
                bool containsMis = false;

                if (inputLabels[selectedindex].Contains("Dep")) { containsDep = true; }
                if (inputLabels[selectedindex].Contains("Per")) { containsPer = true; }
                if (inputLabels[selectedindex].Contains("Sup")) { containsSup = true; }
                if (inputLabels[selectedindex].Contains("Usa")) { containsUsa = true; }
                if (inputLabels[selectedindex].Contains("Mis")) { containsMis = true; }

                containsDep = !containsDep;

                string classification = null;

                if (containsDep) { classification = "Dep"; }
                if (containsPer) { classification = classification == null ? "Per" : classification + ",Per"; }
                if (containsSup) { classification = classification == null ? "Sup" : classification + ",Sup"; }
                if (containsUsa) { classification = classification == null ? "Usa" : classification + ",Usa"; }
                if (classification == null) { classification = "Mis"; }

                //UpdateClassification
                inputLabels[selectedindex] = classification;
                
                //UpdateClassificationFile
                using (var sW = new StreamWriter(fileFolder.Text + inputLabelName))
                {
                    foreach (var item in inputLabels)
                    {
                        sW.WriteLine(item);
                    }
                    sW.Close();
                }
                
                dataListview.Items[selectedindex].SubItems[2].Text = classification;

                //Refresh Evrything
                //UpdateListView();
                dataListview.Items[selectedindex].Selected = false;
                dataListview.Items[selectedindex].Selected = true;
                dataListview.EnsureVisible(selectedindex);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void performanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedindex = dataListview.SelectedItems[0].Index;

                bool containsDep = false;
                bool containsPer = false;
                bool containsSup = false;
                bool containsUsa = false;
                bool containsMis = false;

                if (inputLabels[selectedindex].Contains("Dep")) { containsDep = true; }
                if (inputLabels[selectedindex].Contains("Per")) { containsPer = true; }
                if (inputLabels[selectedindex].Contains("Sup")) { containsSup = true; }
                if (inputLabels[selectedindex].Contains("Usa")) { containsUsa = true; }
                if (inputLabels[selectedindex].Contains("Mis")) { containsMis = true; }

                containsPer = !containsPer;

                string classification = null;

                if (containsDep) { classification = "Dep"; }
                if (containsPer) { classification = classification == null ? "Per" : classification + ",Per"; }
                if (containsSup) { classification = classification == null ? "Sup" : classification + ",Sup"; }
                if (containsUsa) { classification = classification == null ? "Usa" : classification + ",Usa"; }
                if (classification == null) { classification = "Mis"; }

                //UpdateClassification
                inputLabels[selectedindex] = classification;

                //UpdateClassificationFile
                using (var sW = new StreamWriter(fileFolder.Text + inputLabelName))
                {
                    foreach (var item in inputLabels)
                    {
                        sW.WriteLine(item);
                    }
                    sW.Close();
                }

                dataListview.Items[selectedindex].SubItems[2].Text = classification;



                //Refresh Evrything
                //UpdateListView();
                dataListview.Items[selectedindex].Selected = false;
                dataListview.Items[selectedindex].Selected = true;
                dataListview.EnsureVisible(selectedindex);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supportabilityButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedindex = dataListview.SelectedItems[0].Index;

                bool containsDep = false;
                bool containsPer = false;
                bool containsSup = false;
                bool containsUsa = false;
                bool containsMis = false;

                if (inputLabels[selectedindex].Contains("Dep")) { containsDep = true; }
                if (inputLabels[selectedindex].Contains("Per")) { containsPer = true; }
                if (inputLabels[selectedindex].Contains("Sup")) { containsSup = true; }
                if (inputLabels[selectedindex].Contains("Usa")) { containsUsa = true; }
                if (inputLabels[selectedindex].Contains("Mis")) { containsMis = true; }

                containsSup = !containsSup;

                string classification = null;

                if (containsDep) { classification = "Dep"; }
                if (containsPer) { classification = classification == null ? "Per" : classification + ",Per"; }
                if (containsSup) { classification = classification == null ? "Sup" : classification + ",Sup"; }
                if (containsUsa) { classification = classification == null ? "Usa" : classification + ",Usa"; }
                if (classification == null) { classification = "Mis"; }

                //UpdateClassification
                inputLabels[selectedindex] = classification;

                //UpdateClassificationFile
                using (var sW = new StreamWriter(fileFolder.Text + inputLabelName))
                {
                    foreach (var item in inputLabels)
                    {
                        sW.WriteLine(item);
                    }
                    sW.Close();
                }

                dataListview.Items[selectedindex].SubItems[2].Text = classification;



                //Refresh Evrything
                //UpdateListView();
                dataListview.Items[selectedindex].Selected = false;
                dataListview.Items[selectedindex].Selected = true;
                dataListview.EnsureVisible(selectedindex);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usabilityButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedindex = dataListview.SelectedItems[0].Index;

                bool containsDep = false;
                bool containsPer = false;
                bool containsSup = false;
                bool containsUsa = false;
                bool containsMis = false;

                if (inputLabels[selectedindex].Contains("Dep")) { containsDep = true; }
                if (inputLabels[selectedindex].Contains("Per")) { containsPer = true; }
                if (inputLabels[selectedindex].Contains("Sup")) { containsSup = true; }
                if (inputLabels[selectedindex].Contains("Usa")) { containsUsa = true; }
                if (inputLabels[selectedindex].Contains("Mis")) { containsMis = true; }

                containsUsa = !containsUsa;

                string classification = null;

                if (containsDep) { classification = "Dep"; }
                if (containsPer) { classification = classification == null ? "Per" : classification + ",Per"; }
                if (containsSup) { classification = classification == null ? "Sup" : classification + ",Sup"; }
                if (containsUsa) { classification = classification == null ? "Usa" : classification + ",Usa"; }
                if (classification == null) { classification = "Mis"; }

                //UpdateClassification
                inputLabels[selectedindex] = classification;

                //UpdateClassificationFile
                using (var sW = new StreamWriter(fileFolder.Text + inputLabelName))
                {
                    foreach (var item in inputLabels)
                    {
                        sW.WriteLine(item);
                    }
                    sW.Close();
                }

                dataListview.Items[selectedindex].SubItems[2].Text = classification;



                //Refresh Evrything
                //UpdateListView();
                dataListview.Items[selectedindex].Selected = false;
                dataListview.Items[selectedindex].Selected = true;
                dataListview.EnsureVisible(selectedindex);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            var selectedindex = dataListview.SelectedItems[0].Index;
            dataListview.Items[selectedindex].Selected = false;
            dataListview.Items[selectedindex + 1].Selected = true;
            dataListview.EnsureVisible(selectedindex + 1);
        }


        /// <summary>
        /// Input File Path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputFilePathTextBox_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileFolder.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        /// <summary>
        /// Info Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Make sure the selected directory has review file named as \"Reviews.txt\" and label file named as \"ReviewLabels.txt\"");
        }
    }
}
