using System.Drawing;
using System.Drawing.Drawing2D;

namespace GridView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public class version1
        {
            public static string v = "Version " + GridView.Form1.codesversion1.v;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.list1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amuletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ringsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloaksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glovesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bootsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bootyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batteriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battleDungeonKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.craftToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireCrackersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceReaversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAUKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteNPCPagersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scannersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unMannedMiningToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recoveryPillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.towersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siegeKitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ammoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gMCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolConvertCode = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.codeRadioBtn = new System.Windows.Forms.RadioButton();
            this.nameRadioBtn = new System.Windows.Forms.RadioButton();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.list1ToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.list2ToolStripMenuItem,
            this.gMCommandsToolStripMenuItem,
            this.toolConvertCode,
            this.updatesToolStripMenuItem,
            this.clearListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // list1ToolStripMenuItem
            // 
            this.list1ToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.list1ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.list1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessoriesToolStripMenuItem,
            this.file1ToolStripMenuItem,
            this.bootyToolStripMenuItem,
            this.potionsToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.oreToolStripMenuItem,
            this.miscToolStripMenuItem,
            this.weaponsToolStripMenuItem,
            this.towersToolStripMenuItem,
            this.trapsToolStripMenuItem,
            this.siegeKitsToolStripMenuItem,
            this.boxesToolStripMenuItem,
            this.ammoToolStripMenuItem});
            this.list1ToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.list1ToolStripMenuItem.Name = "list1ToolStripMenuItem";
            this.list1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.list1ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.list1ToolStripMenuItem.Text = "Items";
            // 
            // accessoriesToolStripMenuItem
            // 
            this.accessoriesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.accessoriesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.accessoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amuletsToolStripMenuItem,
            this.ringsToolStripMenuItem,
            this.cloaksToolStripMenuItem});
            this.accessoriesToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            this.accessoriesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.accessoriesToolStripMenuItem.Text = "Accessories";
            this.accessoriesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // amuletsToolStripMenuItem
            // 
            this.amuletsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.amuletsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.amuletsToolStripMenuItem.Name = "amuletsToolStripMenuItem";
            this.amuletsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.amuletsToolStripMenuItem.Text = "Amulets";
            this.amuletsToolStripMenuItem.Click += new System.EventHandler(this.amuletsToolStripMenuItem_Click);
            // 
            // ringsToolStripMenuItem
            // 
            this.ringsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ringsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.ringsToolStripMenuItem.Name = "ringsToolStripMenuItem";
            this.ringsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.ringsToolStripMenuItem.Text = "Rings";
            this.ringsToolStripMenuItem.Click += new System.EventHandler(this.ringsToolStripMenuItem_Click);
            // 
            // cloaksToolStripMenuItem
            // 
            this.cloaksToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.cloaksToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.cloaksToolStripMenuItem.Name = "cloaksToolStripMenuItem";
            this.cloaksToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cloaksToolStripMenuItem.Text = "Cloaks";
            this.cloaksToolStripMenuItem.Click += new System.EventHandler(this.cloaksToolStripMenuItem_Click);
            // 
            // file1ToolStripMenuItem
            // 
            this.file1ToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.file1ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.file1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helmetToolStripMenuItem,
            this.upperToolStripMenuItem,
            this.lowerToolStripMenuItem,
            this.glovesToolStripMenuItem,
            this.bootsToolStripMenuItem,
            this.shieldsToolStripMenuItem});
            this.file1ToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.file1ToolStripMenuItem.Name = "file1ToolStripMenuItem";
            this.file1ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.file1ToolStripMenuItem.Text = "Armor";
            // 
            // helmetToolStripMenuItem
            // 
            this.helmetToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.helmetToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.helmetToolStripMenuItem.Name = "helmetToolStripMenuItem";
            this.helmetToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.helmetToolStripMenuItem.Text = "Helmet";
            this.helmetToolStripMenuItem.Click += new System.EventHandler(this.helmetToolStripMenuItem_Click);
            // 
            // upperToolStripMenuItem
            // 
            this.upperToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.upperToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.upperToolStripMenuItem.Name = "upperToolStripMenuItem";
            this.upperToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.upperToolStripMenuItem.Text = "Upper";
            this.upperToolStripMenuItem.Click += new System.EventHandler(this.upperToolStripMenuItem_Click);
            // 
            // lowerToolStripMenuItem
            // 
            this.lowerToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.lowerToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.lowerToolStripMenuItem.Name = "lowerToolStripMenuItem";
            this.lowerToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.lowerToolStripMenuItem.Text = "Lower";
            this.lowerToolStripMenuItem.Click += new System.EventHandler(this.lowerToolStripMenuItem_Click);
            // 
            // glovesToolStripMenuItem
            // 
            this.glovesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.glovesToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.glovesToolStripMenuItem.Name = "glovesToolStripMenuItem";
            this.glovesToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.glovesToolStripMenuItem.Text = "Gloves";
            this.glovesToolStripMenuItem.Click += new System.EventHandler(this.glovesToolStripMenuItem_Click);
            // 
            // bootsToolStripMenuItem
            // 
            this.bootsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.bootsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.bootsToolStripMenuItem.Name = "bootsToolStripMenuItem";
            this.bootsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.bootsToolStripMenuItem.Text = "Boots";
            this.bootsToolStripMenuItem.Click += new System.EventHandler(this.bootsToolStripMenuItem_Click);
            // 
            // shieldsToolStripMenuItem
            // 
            this.shieldsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.shieldsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.shieldsToolStripMenuItem.Name = "shieldsToolStripMenuItem";
            this.shieldsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.shieldsToolStripMenuItem.Text = "Shields";
            this.shieldsToolStripMenuItem.Click += new System.EventHandler(this.shieldsToolStripMenuItem_Click);
            // 
            // bootyToolStripMenuItem
            // 
            this.bootyToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.bootyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bootyToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.bootyToolStripMenuItem.Name = "bootyToolStripMenuItem";
            this.bootyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bootyToolStripMenuItem.Text = "Booty";
            this.bootyToolStripMenuItem.Click += new System.EventHandler(this.bootyToolStripMenuItem_Click);
            // 
            // potionsToolStripMenuItem
            // 
            this.potionsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.potionsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.potionsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.potionsToolStripMenuItem.Name = "potionsToolStripMenuItem";
            this.potionsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.potionsToolStripMenuItem.Text = "Potions";
            this.potionsToolStripMenuItem.Click += new System.EventHandler(this.potionsToolStripMenuItem_Click);
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.resourcesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resourcesToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.resourcesToolStripMenuItem.Text = "Resources";
            this.resourcesToolStripMenuItem.Click += new System.EventHandler(this.resourcesToolStripMenuItem_Click);
            // 
            // oreToolStripMenuItem
            // 
            this.oreToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.oreToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.oreToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.oreToolStripMenuItem.Name = "oreToolStripMenuItem";
            this.oreToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.oreToolStripMenuItem.Text = "Ore";
            this.oreToolStripMenuItem.Click += new System.EventHandler(this.oreToolStripMenuItem_Click);
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.miscToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animusToolStripMenuItem,
            this.bagsToolStripMenuItem,
            this.batteriesToolStripMenuItem,
            this.battleDungeonKeysToolStripMenuItem,
            this.couponsToolStripMenuItem,
            this.craftToolsToolStripMenuItem,
            this.eventItemsToolStripMenuItem,
            this.fireCrackersToolStripMenuItem,
            this.forceReaversToolStripMenuItem,
            this.mapsToolStripMenuItem,
            this.mAUKeysToolStripMenuItem,
            this.questItemsToolStripMenuItem,
            this.remoteNPCPagersToolStripMenuItem,
            this.scannersToolStripMenuItem,
            this.scrollsToolStripMenuItem,
            this.ticketsToolStripMenuItem,
            this.unMannedMiningToolsToolStripMenuItem,
            this.recoveryPillsToolStripMenuItem});
            this.miscToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.miscToolStripMenuItem.Text = "Misc";
            // 
            // animusToolStripMenuItem
            // 
            this.animusToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.animusToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.animusToolStripMenuItem.Name = "animusToolStripMenuItem";
            this.animusToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.animusToolStripMenuItem.Text = "Animus";
            this.animusToolStripMenuItem.Click += new System.EventHandler(this.animusToolStripMenuItem_Click);
            // 
            // bagsToolStripMenuItem
            // 
            this.bagsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.bagsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.bagsToolStripMenuItem.Name = "bagsToolStripMenuItem";
            this.bagsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.bagsToolStripMenuItem.Text = "Bags";
            this.bagsToolStripMenuItem.Click += new System.EventHandler(this.bagsToolStripMenuItem_Click);
            // 
            // batteriesToolStripMenuItem
            // 
            this.batteriesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.batteriesToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.batteriesToolStripMenuItem.Name = "batteriesToolStripMenuItem";
            this.batteriesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.batteriesToolStripMenuItem.Text = "Batteries";
            this.batteriesToolStripMenuItem.Click += new System.EventHandler(this.batteriesToolStripMenuItem_Click);
            // 
            // battleDungeonKeysToolStripMenuItem
            // 
            this.battleDungeonKeysToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.battleDungeonKeysToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.battleDungeonKeysToolStripMenuItem.Name = "battleDungeonKeysToolStripMenuItem";
            this.battleDungeonKeysToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.battleDungeonKeysToolStripMenuItem.Text = "Battle Dungeon Keys";
            this.battleDungeonKeysToolStripMenuItem.Click += new System.EventHandler(this.battleDungeonKeysToolStripMenuItem_Click);
            // 
            // couponsToolStripMenuItem
            // 
            this.couponsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.couponsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.couponsToolStripMenuItem.Name = "couponsToolStripMenuItem";
            this.couponsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.couponsToolStripMenuItem.Text = "Coupons";
            this.couponsToolStripMenuItem.Click += new System.EventHandler(this.couponsToolStripMenuItem_Click);
            // 
            // craftToolsToolStripMenuItem
            // 
            this.craftToolsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.craftToolsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.craftToolsToolStripMenuItem.Name = "craftToolsToolStripMenuItem";
            this.craftToolsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.craftToolsToolStripMenuItem.Text = "Craft Tools";
            this.craftToolsToolStripMenuItem.Click += new System.EventHandler(this.craftToolsToolStripMenuItem_Click);
            // 
            // eventItemsToolStripMenuItem
            // 
            this.eventItemsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.eventItemsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.eventItemsToolStripMenuItem.Name = "eventItemsToolStripMenuItem";
            this.eventItemsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.eventItemsToolStripMenuItem.Text = "Event Items";
            this.eventItemsToolStripMenuItem.Click += new System.EventHandler(this.eventItemsToolStripMenuItem_Click);
            // 
            // fireCrackersToolStripMenuItem
            // 
            this.fireCrackersToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.fireCrackersToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.fireCrackersToolStripMenuItem.Name = "fireCrackersToolStripMenuItem";
            this.fireCrackersToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.fireCrackersToolStripMenuItem.Text = "Fire Crackers";
            this.fireCrackersToolStripMenuItem.Click += new System.EventHandler(this.fireCrackersToolStripMenuItem_Click);
            // 
            // forceReaversToolStripMenuItem
            // 
            this.forceReaversToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.forceReaversToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.forceReaversToolStripMenuItem.Name = "forceReaversToolStripMenuItem";
            this.forceReaversToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.forceReaversToolStripMenuItem.Text = "Force Reavers";
            this.forceReaversToolStripMenuItem.Click += new System.EventHandler(this.forceReaversToolStripMenuItem_Click);
            // 
            // mapsToolStripMenuItem
            // 
            this.mapsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mapsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.mapsToolStripMenuItem.Name = "mapsToolStripMenuItem";
            this.mapsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.mapsToolStripMenuItem.Text = "Maps";
            this.mapsToolStripMenuItem.Click += new System.EventHandler(this.mapsToolStripMenuItem_Click);
            // 
            // mAUKeysToolStripMenuItem
            // 
            this.mAUKeysToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mAUKeysToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.mAUKeysToolStripMenuItem.Name = "mAUKeysToolStripMenuItem";
            this.mAUKeysToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.mAUKeysToolStripMenuItem.Text = "MAU Keys";
            this.mAUKeysToolStripMenuItem.Click += new System.EventHandler(this.mAUKeysToolStripMenuItem_Click);
            // 
            // questItemsToolStripMenuItem
            // 
            this.questItemsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.questItemsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.questItemsToolStripMenuItem.Name = "questItemsToolStripMenuItem";
            this.questItemsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.questItemsToolStripMenuItem.Text = "Quest Items";
            this.questItemsToolStripMenuItem.Click += new System.EventHandler(this.questItemsToolStripMenuItem_Click);
            // 
            // remoteNPCPagersToolStripMenuItem
            // 
            this.remoteNPCPagersToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.remoteNPCPagersToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.remoteNPCPagersToolStripMenuItem.Name = "remoteNPCPagersToolStripMenuItem";
            this.remoteNPCPagersToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.remoteNPCPagersToolStripMenuItem.Text = "Remote NPC Pagers";
            this.remoteNPCPagersToolStripMenuItem.Click += new System.EventHandler(this.remoteNPCPagersToolStripMenuItem_Click);
            // 
            // scannersToolStripMenuItem
            // 
            this.scannersToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.scannersToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.scannersToolStripMenuItem.Name = "scannersToolStripMenuItem";
            this.scannersToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.scannersToolStripMenuItem.Text = "Scanners";
            this.scannersToolStripMenuItem.Click += new System.EventHandler(this.scannersToolStripMenuItem_Click);
            // 
            // scrollsToolStripMenuItem
            // 
            this.scrollsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.scrollsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.scrollsToolStripMenuItem.Name = "scrollsToolStripMenuItem";
            this.scrollsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.scrollsToolStripMenuItem.Text = "Scrolls";
            this.scrollsToolStripMenuItem.Click += new System.EventHandler(this.scrollsToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ticketsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            this.ticketsToolStripMenuItem.Click += new System.EventHandler(this.ticketsToolStripMenuItem_Click);
            // 
            // unMannedMiningToolsToolStripMenuItem
            // 
            this.unMannedMiningToolsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.unMannedMiningToolsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.unMannedMiningToolsToolStripMenuItem.Name = "unMannedMiningToolsToolStripMenuItem";
            this.unMannedMiningToolsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.unMannedMiningToolsToolStripMenuItem.Text = "UnManned Mining Tools";
            this.unMannedMiningToolsToolStripMenuItem.Click += new System.EventHandler(this.unMannedMiningToolsToolStripMenuItem_Click);
            // 
            // recoveryPillsToolStripMenuItem
            // 
            this.recoveryPillsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.recoveryPillsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.recoveryPillsToolStripMenuItem.Name = "recoveryPillsToolStripMenuItem";
            this.recoveryPillsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.recoveryPillsToolStripMenuItem.Text = "Recovery Pills";
            this.recoveryPillsToolStripMenuItem.Click += new System.EventHandler(this.recoveryPillsToolStripMenuItem_Click);
            // 
            // weaponsToolStripMenuItem
            // 
            this.weaponsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.weaponsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.weaponsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.weaponsToolStripMenuItem.Name = "weaponsToolStripMenuItem";
            this.weaponsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.weaponsToolStripMenuItem.Text = "Weapons";
            this.weaponsToolStripMenuItem.Click += new System.EventHandler(this.weaponsToolStripMenuItem_Click);
            // 
            // towersToolStripMenuItem
            // 
            this.towersToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.towersToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.towersToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.towersToolStripMenuItem.Name = "towersToolStripMenuItem";
            this.towersToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.towersToolStripMenuItem.Text = "Towers";
            this.towersToolStripMenuItem.Click += new System.EventHandler(this.towersToolStripMenuItem_Click);
            // 
            // trapsToolStripMenuItem
            // 
            this.trapsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.trapsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.trapsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.trapsToolStripMenuItem.Name = "trapsToolStripMenuItem";
            this.trapsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.trapsToolStripMenuItem.Text = "Traps";
            this.trapsToolStripMenuItem.Click += new System.EventHandler(this.trapsToolStripMenuItem_Click);
            // 
            // siegeKitsToolStripMenuItem
            // 
            this.siegeKitsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.siegeKitsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.siegeKitsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.siegeKitsToolStripMenuItem.Name = "siegeKitsToolStripMenuItem";
            this.siegeKitsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.siegeKitsToolStripMenuItem.Text = "Siege Kits";
            this.siegeKitsToolStripMenuItem.Click += new System.EventHandler(this.siegeKitsToolStripMenuItem_Click);
            // 
            // boxesToolStripMenuItem
            // 
            this.boxesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.boxesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boxesToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.boxesToolStripMenuItem.Name = "boxesToolStripMenuItem";
            this.boxesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.boxesToolStripMenuItem.Text = "Boxes";
            this.boxesToolStripMenuItem.Click += new System.EventHandler(this.boxesToolStripMenuItem_Click);
            // 
            // ammoToolStripMenuItem
            // 
            this.ammoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ammoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ammoToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.ammoToolStripMenuItem.Name = "ammoToolStripMenuItem";
            this.ammoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.ammoToolStripMenuItem.Text = "Ammo";
            this.ammoToolStripMenuItem.Click += new System.EventHandler(this.ammoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Tag = "About RF Codes";
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // list2ToolStripMenuItem
            // 
            this.list2ToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.list2ToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.list2ToolStripMenuItem.Name = "list2ToolStripMenuItem";
            this.list2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.list2ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.list2ToolStripMenuItem.Text = "Monsters";
            this.list2ToolStripMenuItem.Click += new System.EventHandler(this.list2ToolStripMenuItem_Click);
            // 
            // gMCommandsToolStripMenuItem
            // 
            this.gMCommandsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.gMCommandsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.gMCommandsToolStripMenuItem.Name = "gMCommandsToolStripMenuItem";
            this.gMCommandsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.gMCommandsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.gMCommandsToolStripMenuItem.Text = "GM Commands";
            this.gMCommandsToolStripMenuItem.Click += new System.EventHandler(this.gMCommandsToolStripMenuItem_Click);
            // 
            // toolConvertCode
            // 
            this.toolConvertCode.BackColor = System.Drawing.Color.Black;
            this.toolConvertCode.ForeColor = System.Drawing.Color.Red;
            this.toolConvertCode.Name = "toolConvertCode";
            this.toolConvertCode.Size = new System.Drawing.Size(71, 20);
            this.toolConvertCode.Text = "Converter";
            this.toolConvertCode.ToolTipText = "Convert Item Code to Client Code";
            this.toolConvertCode.Click += new System.EventHandler(this.toolConvertCode_Click);
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.updatesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.updatesToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.updatesToolStripMenuItem.Text = "Updates";
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clearListToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.clearListToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView.BackgroundColor = System.Drawing.Color.Black;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridView.ColumnHeadersHeight = 18;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.Code,
            this.Name_});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.GridColor = System.Drawing.Color.Red;
            this.gridView.Location = new System.Drawing.Point(0, 23);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowHeadersWidth = 150;
            this.gridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.gridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.gridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.gridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridView.Size = new System.Drawing.Size(494, 370);
            this.gridView.TabIndex = 1;
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentClick);
            // 
            // Count
            // 
            this.Count.FillWeight = 200F;
            this.Count.Frozen = true;
            this.Count.HeaderText = "Index";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Count.ToolTipText = "Index Value";
            this.Count.Width = 38;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Code.ToolTipText = "Command Code";
            this.Code.Width = 50;
            // 
            // Name_
            // 
            this.Name_.FillWeight = 200F;
            this.Name_.HeaderText = "Name";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            this.Name_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Name_.ToolTipText = "Name or description";
            this.Name_.Width = 386;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by";
            // 
            // codeRadioBtn
            // 
            this.codeRadioBtn.AutoSize = true;
            this.codeRadioBtn.Location = new System.Drawing.Point(94, 406);
            this.codeRadioBtn.Name = "codeRadioBtn";
            this.codeRadioBtn.Size = new System.Drawing.Size(49, 17);
            this.codeRadioBtn.TabIndex = 3;
            this.codeRadioBtn.TabStop = true;
            this.codeRadioBtn.Text = "code";
            this.codeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // nameRadioBtn
            // 
            this.nameRadioBtn.AutoSize = true;
            this.nameRadioBtn.Checked = true;
            this.nameRadioBtn.Location = new System.Drawing.Point(149, 406);
            this.nameRadioBtn.Name = "nameRadioBtn";
            this.nameRadioBtn.Size = new System.Drawing.Size(51, 17);
            this.nameRadioBtn.TabIndex = 4;
            this.nameRadioBtn.TabStop = true;
            this.nameRadioBtn.Text = "name";
            this.nameRadioBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Black;
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.Red;
            this.searchBtn.Location = new System.Drawing.Point(221, 410);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Black;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox.Location = new System.Drawing.Point(94, 425);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 6;
            // 
            // clearBtn
            // 
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(221, 438);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(432, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "NiteMare";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email Me:";
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(494, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.nameRadioBtn);
            this.Controls.Add(this.codeRadioBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 502);
            this.MinimumSize = new System.Drawing.Size(510, 502);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RF Online Codes by NiteMare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem list1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem list2ToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton codeRadioBtn;
        private System.Windows.Forms.RadioButton nameRadioBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem weaponsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glovesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bootsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oreToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amuletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ringsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloaksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batteriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem craftToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceReaversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireCrackersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAUKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scannersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrollsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unMannedMiningToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bootyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem battleDungeonKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couponsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteNPCPagersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recoveryPillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem towersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siegeKitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ammoToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem gMCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolConvertCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
    }
}

