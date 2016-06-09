using System;
using System.IO;
using System.Windows.Forms;

namespace ErrorCollectorApp
{
    public class fileSetting
    {
        private string _saaPath = "D:\\Alliance\\Access";
        private string _swpsePath = "D:\\Alliance\\WebPlatformSE";
        private string _sagPath = "D:\\Alliance\\Gateway";
        private string _snlPath = "D:\\SWIFT\\SWIFTNet\\SNL";
        private string filePath = Directory.GetCurrentDirectory() + "\\fileSetting.dat";

        //public string fileSetting { get; set; }
        public string saaPath 
        {
            get { return _saaPath; }
            set { _saaPath = value; }
        }
        public string swpsePath 
        {
            get { return _swpsePath; }
            set { _swpsePath = value; }
        }
        public string sagPath
        {
            get { return _sagPath; }
            set { _sagPath = value; }
        }
        public string snlPath 
        {
            get { return _snlPath; }
            set { _snlPath = value; }
        }

        public bool saaCheck { get; set; }
        public bool swpseCheck { get; set; }
        public bool sagCheck { get; set; }
        public bool snlCheck { get; set; }
        public bool eventCheck { get; set; }

        public void fileBuilding()
        {
            //Check fileSetting created
            if (!File.Exists(filePath))
            {
                try
                {
                    File.WriteAllLines(filePath, new string[] { "[PATH_SETTING]", 
                        "SAA=" + saaPath + ",false" , 
                        "SWPSE=" + swpsePath + ",false" , 
                        "SAG=" + sagPath + ",false" , 
                        "SNL=" + snlPath + ",false" , 
                        "eventlog=false"});
                }
                catch (IOException e)
                {
                    MessageBox.Show("An I/O error occurred while creating the file.\n" + e, "File creation error!!!", MessageBoxButtons.OK);
                }
                catch (ArgumentException e)
                {
                    MessageBox.Show("Invalid path.\n" + e, "File creation error!!!", MessageBoxButtons.OK);
                }
                catch (UnauthorizedAccessException e)
                {
                    MessageBox.Show("No permission to create the file in this folder.\n" + e, "File creation error!!!", MessageBoxButtons.OK);
                }
            }
        }

        public void fileReadPath()
        {
            try
            {
                string[] tempRead = File.ReadAllLines(filePath);
                saaPath = tempRead[1].Substring(tempRead[1].IndexOf("=") + 1, tempRead[1].IndexOf(",") - 4);
                swpsePath = tempRead[2].Substring(tempRead[2].IndexOf("=") + 1, tempRead[2].IndexOf(",") - 6);
                sagPath = tempRead[3].Substring(tempRead[3].IndexOf("=") + 1, tempRead[3].IndexOf(",") - 4);
                snlPath = tempRead[4].Substring(tempRead[4].IndexOf("=") + 1, tempRead[4].IndexOf(",") - 4);

                saaCheck = Convert.ToBoolean(tempRead[1].Substring(tempRead[1].IndexOf(",") + 1));
                swpseCheck = Convert.ToBoolean(tempRead[2].Substring(tempRead[2].IndexOf(",") + 1));
                sagCheck = Convert.ToBoolean(tempRead[3].Substring(tempRead[3].IndexOf(",") + 1));
                snlCheck = Convert.ToBoolean(tempRead[4].Substring(tempRead[4].IndexOf(",") + 1));
                eventCheck = Convert.ToBoolean(tempRead[5].Substring(tempRead[5].IndexOf("=") + 1));
            }
            catch (IOException e)
            {
                MessageBox.Show("An I/O error occurred while creating the file.\n" + e, "File reading error!!!", MessageBoxButtons.OK);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Invalid path.\n" + e, "File reading error!!!", MessageBoxButtons.OK);
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("No permission to create the file in this folder.\n" + e, "File reading error!!!", MessageBoxButtons.OK);
            }
        }

        public void fileSave()
        {
            try
            {
                File.WriteAllLines(filePath, new string[] { "[PATH_SETTING]", 
                    "SAA=" + saaPath + "," + saaCheck , 
                    "SWPSE=" + swpsePath + "," + swpseCheck , 
                    "SAG=" + sagPath + "," + sagCheck , 
                    "SNL=" + snlPath + "," + snlCheck , 
                    "eventlog=" + eventCheck });
            }
            catch (IOException e)
            {
                MessageBox.Show("An I/O error occurred while creating the file.\n" + e, "File creation error!!!", MessageBoxButtons.OK);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Invalid path.\n" + e, "File creation error!!!", MessageBoxButtons.OK);
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("No permission to create the file in this folder.\n" + e, "File creation error!!!", MessageBoxButtons.OK);
            }
        }
    }
}    

