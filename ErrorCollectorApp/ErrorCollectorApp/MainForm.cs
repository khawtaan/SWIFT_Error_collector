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

namespace ErrorCollectorApp
{
    public partial class MainForm : Form
    {
        //Declare default directory
        fileSetting dataPath = new fileSetting();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Default setting
            textBoxSAA.Enabled = false;
            textBoxSWPSE.Enabled = false;
            textBoxSAGSNL.Enabled = false;
            textBoxSNL.Enabled = false;

            //MessageBox.Show("test");

            dataPath.fileBuilding();
            dataPath.fileReadPath();

            //Set data to textBox & checkBox
            if (Directory.Exists(dataPath.saaPath)) { textBoxSAA.Text = dataPath.saaPath; }
            else { textBoxSAA.Text = "Please manual browse to SAA folder."; }
            if (Directory.Exists(dataPath.swpsePath)) { textBoxSWPSE.Text = dataPath.swpsePath; }
            else { textBoxSWPSE.Text = "Please manual browse to SWPSE folder."; }
            if (Directory.Exists(dataPath.sagPath)) { textBoxSAGSNL.Text = dataPath.sagPath; }
            else { textBoxSAGSNL.Text = "Please manual browse to SAG folder."; }
            if (Directory.Exists(dataPath.snlPath)) { textBoxSNLplus.Text = dataPath.snlPath;
                textBoxSNL.Text = dataPath.snlPath;
            }
            else { textBoxSNL.Text = "Please manual browse to SNL folder.";
                textBoxSNLplus.Text = textBoxSNL.Text; 
            }
                        
            checkBoxSAA.Checked = dataPath.saaCheck;
            checkBoxSWPSE.Checked = dataPath.swpseCheck;
            checkBoxSAGSNL.Checked = dataPath.sagCheck;
            checkBoxSNL.Checked = dataPath.snlCheck;
            checkBoxEventLog.Checked = dataPath.eventCheck;
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Get lastest data
            dataPath.saaCheck = checkBoxSAA.Checked;
            dataPath.swpseCheck = checkBoxSWPSE.Checked;
            dataPath.sagCheck = checkBoxSAGSNL.Checked;
            dataPath.snlCheck = checkBoxSNL.Checked;
            dataPath.eventCheck = checkBoxEventLog.Checked;

            if (Directory.Exists(textBoxSAA.Text)) { dataPath.saaPath = textBoxSAA.Text; }
            else { dataPath.saaPath = ""; }
            if (Directory.Exists(textBoxSWPSE.Text)) { dataPath.swpsePath = textBoxSWPSE.Text; }
            else { dataPath.swpsePath = ""; }
            if (Directory.Exists(textBoxSAGSNL.Text)) { dataPath.sagPath = textBoxSAGSNL.Text; }
            else { dataPath.sagPath = ""; }
            if (Directory.Exists(textBoxSNL.Text)) { dataPath.snlPath = textBoxSNL.Text; }
            else { dataPath.snlPath = ""; }

            //Save selected to fileSetting.dat
            dataPath.fileSave();
        }

        private void checkBoxSAA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSAA.Checked == true) 
            {
                groupBoxSAA.Enabled = true;
            }
            else
            {
                groupBoxSAA.Enabled = false;
            }
        }
        private void checkBoxSWPSE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSWPSE.Checked == true)
            {
                groupBoxSWPSE.Enabled = true;
            }
            else
            {
                groupBoxSWPSE.Enabled = false;
            }
        }
        private void checkBoxSAGSNL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSAGSNL.Checked == true)
            {
                groupBoxSAGSNL.Enabled = true;
                groupBoxSNL.Enabled = false;
                checkBoxSNL.Enabled = false;
                checkBoxSNL.Checked = false;
            }
            else
            {
                groupBoxSAGSNL.Enabled = false;
                groupBoxSNL.Enabled = false;
                checkBoxSNL.Enabled = true;
            }
        }
        private void checkBoxSNL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSNL.Checked == true)
            {
                groupBoxSNL.Enabled = true;
            }
            else
            {
                groupBoxSNL.Enabled = false;
            }
        }

        private void buttonSAA_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBoxSAA.Text = folderBrowserDialog.SelectedPath;
        }
        private void buttonSWPSE_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBoxSWPSE.Text = folderBrowserDialog.SelectedPath;
        }
        private void buttonSAGSNL_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBoxSAGSNL.Text = folderBrowserDialog.SelectedPath;
        }
        private void buttonSNLplus_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBoxSNLplus.Text = folderBrowserDialog.SelectedPath;
            textBoxSNL.Text = folderBrowserDialog.SelectedPath;
        }
        private void buttonSNL_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBoxSNL.Text = folderBrowserDialog.SelectedPath;
            textBoxSNLplus.Text = folderBrowserDialog.SelectedPath;
        }

    }
}
