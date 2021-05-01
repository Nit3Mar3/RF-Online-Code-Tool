using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using StringExtensions;

namespace GridView
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            textBox.ForeColor = SystemColors.GrayText;
            textBox.Text = "Search";
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            this.textBox.Enter += new System.EventHandler(this.textBox_Enter);
        }


        private void toolConvertCode_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            Converter.Instance.Show();
        }

        //Sets version information shown in window title and about sections.
        public class codesversion1
        {
            public static string v = "Version " + Application.ProductVersion;
        }
        public class rfversion2
        {
            public static string e = "Episode 2.2.3.2";
        }
        //reads a list file and loads the columns into the grid view
        private void loadFile(string filename)
        {
            //load the assembly object
            System.Reflection.Assembly myAssembly = this.GetType().Assembly;
            //load the resources manager
            System.Resources.ResourceManager myManager = new
                    System.Resources.ResourceManager("RFOnlineCodes.Properties.Resources", myAssembly);
            //read the resource file contents
            String fileContents = myManager.GetObject(filename.Substring(0,filename.IndexOf('.'))) as string;                                    

            //set the encoding for the stream
            ASCIIEncoding encoding = new ASCIIEncoding();
            //create stream
            MemoryStream stream = new MemoryStream(encoding.GetBytes(fileContents));
            //create stream reader
            StreamReader sr = new StreamReader(stream);           
            
            string line;
            //read stream line by line
            while((line=sr.ReadLine())!=null)
            {
                //split the line using the , separator
                string[] parts = line.Split(',');
                //remove start and end spaces and '
                for (int i = 0; i < parts.Length; i++)
                {
                    parts[i] = parts[i].Trim();
                    parts[i] = parts[i].Substring(1, parts[i].Length - 2);
                }
                //add to grid view
                gridView.Rows.Add(parts);
            }                            
        }
        //the clear button 
        private void clearBtn_Click(object sender, EventArgs e)
        {
            //unhide all rows
            for (int i = 0; i < gridView.Rows.Count; i++)
                gridView.Rows[i].Visible = true;
                
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
                //get the search term from the textbox
                String searchTerm = textBox.Text;
                //if the column index is 1 then we search by code and if 2 we search by name
                int columnIndex = 0;
                if (codeRadioBtn.Checked)
                    columnIndex = 1;
                else
                    columnIndex = 2;

                gridView.ClearSelection();

                bool found = false;

            for (int i = 0; i < gridView.Rows.Count; i++)
            {
                //show only rows with searchTerm found
                if (gridView.Rows[i].Cells[columnIndex].Value.ToString().Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    gridView.Rows[i].Selected = true;
                    gridView.Rows[i].Visible = true;
                    found = true;
                }
                else
                {
                    gridView.Rows[i].Selected = false;
                    gridView.Rows[i].Visible = false;
                }
                }
                //display message if no item was found 
                if (!found)
                {
                    MessageBox.Show("The search term was not found", "Warning");
                }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0)
            {
                textBox.Text = "Search";
                textBox.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBox_Enter(object sender, EventArgs e)
        {
            if (textBox.Text == "Search")
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void weaponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("WeaponItem.txt");
        }

        private void helmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("HelmetItem.txt");
        }

        private void upperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("UpperItem.txt");
        }

        private void lowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("LowerItem.txt");
        }

        private void glovesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("GauntletItem.txt");
        }

        private void bootsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("ShoeItem.txt");
        }

        private void shieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("ShieldItem.txt");
        }

        private void potionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("PotionItem.txt");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RF Online Codes" +
                                        "\nCoded By: NiteMare \n" + codesversion1.v + "\nFor: " + rfversion2.e,
                                        "About RF Online Codes",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Asterisk);
        }

        private void amuletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("AmuletItem.txt");
        }

        private void ringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("RingItem.txt");
        }

        private void cloaksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("CloakItem.txt");
        }

        private void bootyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("BootyItem.txt");
        }

        private void resourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("ResourceItem.txt");
        }

        private void oreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("OreItem.txt");
        }

        private void animusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("AnimusItem.txt");
        }

        private void bagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("BagItem.txt");
        }

        private void batteriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("BatteryItem.txt");
        }

        private void battleDungeonKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("BattleDungeonItem.txt");
        }

        private void couponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("CouponItem.txt");
        }

        private void craftToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("MakeToolItem.txt");
        }

        private void eventItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("EventItem.txt");
        }

        private void fireCrackersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("FireCracker.txt");
        }

        private void forceReaversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("ForceItem.txt");
        }

        private void mapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("MapItem.txt");
        }

        private void mAUKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("UnitKeyItem.txt");
        }

        private void questItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("QuestItem.txt");
        }

        private void remoteNPCPagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("NPCLinkItem.txt");
        }

        private void scannersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("RadarItem.txt");
        }

        private void scrollsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("TOWNItem.txt");
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("TicketItem.txt");
        }

        private void unMannedMiningToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("UNmannedminer.txt");
        }

        private void recoveryPillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("RecoveryItem.txt");
        }

        private void towersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("GuardTowerItem.txt");
        }

        private void trapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("TrapItem.txt");
        }

        private void siegeKitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("SiegeKitItem.txt");
        }

        private void boxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("BoxItem.txt");
        }

        private void ammoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("BulletItem.txt");
        }

        private void gMCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("Commands.txt");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process toLink; string page = "http://www.google.com/recaptcha/mailhide/d?k=0116r6N-vPTbVFNESsMe9U3g==&c=DgVzFz5jpv4862A9sIm94NciMwIWGMZMVU4u5iuBGHQ="; toLink = Process.Start(page);
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
            loadFile("MonsterCharacter.txt");
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.Rows.Clear();
        }

        private void updatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process toLink; string page = "http://forum.ragezone.com/f479/release-rf-online-codes-tool-1097328/#post8602772"; toLink = Process.Start(page);
        }
        //private void textBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //        searchBtn_Click(sender, e);
        //}
    }
}
