namespace TextAndPizza
{
    partial class WorldBuilder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldBuilder));
            this.worldTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomId = new System.Windows.Forms.ToolStripTextBox();
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemId = new System.Windows.Forms.ToolStripTextBox();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntityId = new System.Windows.Forms.ToolStripTextBox();
            this.addEntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomName = new System.Windows.Forms.TextBox();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.RoomDescription = new System.Windows.Forms.TextBox();
            this.RoomDescriptionLabel = new System.Windows.Forms.Label();
            this.WorldName = new System.Windows.Forms.TextBox();
            this.WorldNameLabel = new System.Windows.Forms.Label();
            this.NorthExitCombo = new System.Windows.Forms.ComboBox();
            this.OpenWorldDialog = new System.Windows.Forms.OpenFileDialog();
            this.EastExitCombo = new System.Windows.Forms.ComboBox();
            this.SouthExitCombo = new System.Windows.Forms.ComboBox();
            this.WestExitCombo = new System.Windows.Forms.ComboBox();
            this.NorthExitLabel = new System.Windows.Forms.Label();
            this.EastExitLabel = new System.Windows.Forms.Label();
            this.SouthExitLabel = new System.Windows.Forms.Label();
            this.WestExitLabel = new System.Windows.Forms.Label();
            this.StartingRoomLabel = new System.Windows.Forms.Label();
            this.StartingRoomCombo = new System.Windows.Forms.ComboBox();
            this.ItemEntityTabs = new System.Windows.Forms.TabControl();
            this.ItemTab = new System.Windows.Forms.TabPage();
            this.DefenceMinusButton = new System.Windows.Forms.Button();
            this.DefencePlusButton = new System.Windows.Forms.Button();
            this.StrengthMinusButton = new System.Windows.Forms.Button();
            this.StrengthPlusButton = new System.Windows.Forms.Button();
            this.ItemDefenceLabel = new System.Windows.Forms.Label();
            this.ItemStrengthLabel = new System.Windows.Forms.Label();
            this.ItemDescriptionLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemDefence = new System.Windows.Forms.TextBox();
            this.ItemStrength = new System.Windows.Forms.TextBox();
            this.ItemDescription = new System.Windows.Forms.TextBox();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.ItemTreeView = new System.Windows.Forms.TreeView();
            this.EntityTab = new System.Windows.Forms.TabPage();
            this.EntityDefenceLabel = new System.Windows.Forms.Label();
            this.EntityStrengthLabel = new System.Windows.Forms.Label();
            this.EntityDefence = new System.Windows.Forms.TextBox();
            this.EntityStrength = new System.Windows.Forms.TextBox();
            this.EntityHealthLabel = new System.Windows.Forms.Label();
            this.EntityHealth = new System.Windows.Forms.TextBox();
            this.EntityNameLabel = new System.Windows.Forms.Label();
            this.EntityName = new System.Windows.Forms.TextBox();
            this.EntityTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.ItemEntityTabs.SuspendLayout();
            this.ItemTab.SuspendLayout();
            this.EntityTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldTreeView
            // 
            this.worldTreeView.Location = new System.Drawing.Point(12, 28);
            this.worldTreeView.Name = "worldTreeView";
            this.worldTreeView.Size = new System.Drawing.Size(178, 333);
            this.worldTreeView.TabIndex = 0;
            this.worldTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.worldTreeView_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldToolStripMenuItem,
            this.openWorldToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveWorldToolStripMenuItem,
            this.exportWorldToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newWorldToolStripMenuItem.Text = "New World";
            this.newWorldToolStripMenuItem.Click += new System.EventHandler(this.newWorldToolStripMenuItem_Click);
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openWorldToolStripMenuItem.Text = "Open World...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.openWorldToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // saveWorldToolStripMenuItem
            // 
            this.saveWorldToolStripMenuItem.Name = "saveWorldToolStripMenuItem";
            this.saveWorldToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveWorldToolStripMenuItem.Text = "Save World...";
            this.saveWorldToolStripMenuItem.Click += new System.EventHandler(this.saveWorldToolStripMenuItem_Click);
            // 
            // exportWorldToolStripMenuItem
            // 
            this.exportWorldToolStripMenuItem.Name = "exportWorldToolStripMenuItem";
            this.exportWorldToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exportWorldToolStripMenuItem.Text = "Export World...";
            this.exportWorldToolStripMenuItem.Click += new System.EventHandler(this.exportWorldToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.entityToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.newToolStripMenuItem.Text = "Add";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoomId,
            this.addRoomToolStripMenuItem});
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // RoomId
            // 
            this.RoomId.Name = "RoomId";
            this.RoomId.Size = new System.Drawing.Size(100, 23);
            this.RoomId.Text = "RoomID";
            this.RoomId.Click += new System.EventHandler(this.RoomId_Click);
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addRoomToolStripMenuItem.Text = "Add Room";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemId,
            this.addItemToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.itemToolStripMenuItem.Text = "Item";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // ItemId
            // 
            this.ItemId.Name = "ItemId";
            this.ItemId.Size = new System.Drawing.Size(100, 23);
            this.ItemId.Text = "ItemID";
            this.ItemId.Click += new System.EventHandler(this.toolStripItemId_Click);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // entityToolStripMenuItem
            // 
            this.entityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntityId,
            this.addEntityToolStripMenuItem});
            this.entityToolStripMenuItem.Name = "entityToolStripMenuItem";
            this.entityToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.entityToolStripMenuItem.Text = "Entity";
            // 
            // EntityId
            // 
            this.EntityId.Name = "EntityId";
            this.EntityId.Size = new System.Drawing.Size(100, 23);
            this.EntityId.Text = "EntityID";
            this.EntityId.Click += new System.EventHandler(this.EntityId_Click);
            // 
            // addEntityToolStripMenuItem
            // 
            this.addEntityToolStripMenuItem.Name = "addEntityToolStripMenuItem";
            this.addEntityToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addEntityToolStripMenuItem.Text = "Add Entity";
            this.addEntityToolStripMenuItem.Click += new System.EventHandler(this.addEntityToolStripMenuItem_Click);
            // 
            // RoomName
            // 
            this.RoomName.Location = new System.Drawing.Point(271, 28);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(435, 20);
            this.RoomName.TabIndex = 2;
            this.RoomName.TextChanged += new System.EventHandler(this.RoomName_TextChanged);
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(196, 31);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(69, 13);
            this.RoomNameLabel.TabIndex = 3;
            this.RoomNameLabel.Text = "Room Name:";
            // 
            // RoomDescription
            // 
            this.RoomDescription.Location = new System.Drawing.Point(271, 54);
            this.RoomDescription.Multiline = true;
            this.RoomDescription.Name = "RoomDescription";
            this.RoomDescription.Size = new System.Drawing.Size(435, 67);
            this.RoomDescription.TabIndex = 4;
            this.RoomDescription.TextChanged += new System.EventHandler(this.RoomDescription_TextChanged);
            // 
            // RoomDescriptionLabel
            // 
            this.RoomDescriptionLabel.AutoSize = true;
            this.RoomDescriptionLabel.Location = new System.Drawing.Point(196, 57);
            this.RoomDescriptionLabel.Name = "RoomDescriptionLabel";
            this.RoomDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.RoomDescriptionLabel.TabIndex = 5;
            this.RoomDescriptionLabel.Text = "Description:";
            // 
            // WorldName
            // 
            this.WorldName.Location = new System.Drawing.Point(84, 393);
            this.WorldName.Name = "WorldName";
            this.WorldName.Size = new System.Drawing.Size(106, 20);
            this.WorldName.TabIndex = 9;
            this.WorldName.Text = "WorldName";
            this.WorldName.Click += new System.EventHandler(this.WorldName_Click);
            this.WorldName.TextChanged += new System.EventHandler(this.WorldName_TextChanged);
            // 
            // WorldNameLabel
            // 
            this.WorldNameLabel.AutoSize = true;
            this.WorldNameLabel.Location = new System.Drawing.Point(9, 396);
            this.WorldNameLabel.Name = "WorldNameLabel";
            this.WorldNameLabel.Size = new System.Drawing.Size(69, 13);
            this.WorldNameLabel.TabIndex = 10;
            this.WorldNameLabel.Text = "World Name:";
            // 
            // NorthExitCombo
            // 
            this.NorthExitCombo.FormattingEnabled = true;
            this.NorthExitCombo.Location = new System.Drawing.Point(271, 127);
            this.NorthExitCombo.Name = "NorthExitCombo";
            this.NorthExitCombo.Size = new System.Drawing.Size(121, 21);
            this.NorthExitCombo.TabIndex = 11;
            this.NorthExitCombo.SelectedIndexChanged += new System.EventHandler(this.NorthExitCombo_SelectedIndexChanged);
            this.NorthExitCombo.Click += new System.EventHandler(this.NorthExitCombo_Click);
            // 
            // OpenWorldDialog
            // 
            this.OpenWorldDialog.FileName = "world";
            this.OpenWorldDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenWorldDialog_FileOk);
            // 
            // EastExitCombo
            // 
            this.EastExitCombo.FormattingEnabled = true;
            this.EastExitCombo.Location = new System.Drawing.Point(271, 154);
            this.EastExitCombo.Name = "EastExitCombo";
            this.EastExitCombo.Size = new System.Drawing.Size(121, 21);
            this.EastExitCombo.TabIndex = 12;
            this.EastExitCombo.SelectedIndexChanged += new System.EventHandler(this.EastExitCombo_SelectedIndexChanged);
            this.EastExitCombo.Click += new System.EventHandler(this.EastExitCombo_Click);
            // 
            // SouthExitCombo
            // 
            this.SouthExitCombo.FormattingEnabled = true;
            this.SouthExitCombo.Location = new System.Drawing.Point(271, 181);
            this.SouthExitCombo.Name = "SouthExitCombo";
            this.SouthExitCombo.Size = new System.Drawing.Size(121, 21);
            this.SouthExitCombo.TabIndex = 13;
            this.SouthExitCombo.SelectedIndexChanged += new System.EventHandler(this.SouthExitCombo_SelectedIndexChanged);
            // 
            // WestExitCombo
            // 
            this.WestExitCombo.FormattingEnabled = true;
            this.WestExitCombo.Location = new System.Drawing.Point(271, 208);
            this.WestExitCombo.Name = "WestExitCombo";
            this.WestExitCombo.Size = new System.Drawing.Size(121, 21);
            this.WestExitCombo.TabIndex = 14;
            this.WestExitCombo.SelectedIndexChanged += new System.EventHandler(this.WestExitCombo_SelectedIndexChanged);
            // 
            // NorthExitLabel
            // 
            this.NorthExitLabel.AutoSize = true;
            this.NorthExitLabel.Location = new System.Drawing.Point(196, 130);
            this.NorthExitLabel.Name = "NorthExitLabel";
            this.NorthExitLabel.Size = new System.Drawing.Size(56, 13);
            this.NorthExitLabel.TabIndex = 15;
            this.NorthExitLabel.Text = "North Exit:";
            // 
            // EastExitLabel
            // 
            this.EastExitLabel.AutoSize = true;
            this.EastExitLabel.Location = new System.Drawing.Point(196, 157);
            this.EastExitLabel.Name = "EastExitLabel";
            this.EastExitLabel.Size = new System.Drawing.Size(51, 13);
            this.EastExitLabel.TabIndex = 16;
            this.EastExitLabel.Text = "East Exit:";
            // 
            // SouthExitLabel
            // 
            this.SouthExitLabel.AutoSize = true;
            this.SouthExitLabel.Location = new System.Drawing.Point(196, 184);
            this.SouthExitLabel.Name = "SouthExitLabel";
            this.SouthExitLabel.Size = new System.Drawing.Size(58, 13);
            this.SouthExitLabel.TabIndex = 17;
            this.SouthExitLabel.Text = "South Exit:";
            // 
            // WestExitLabel
            // 
            this.WestExitLabel.AutoSize = true;
            this.WestExitLabel.Location = new System.Drawing.Point(196, 211);
            this.WestExitLabel.Name = "WestExitLabel";
            this.WestExitLabel.Size = new System.Drawing.Size(55, 13);
            this.WestExitLabel.TabIndex = 18;
            this.WestExitLabel.Text = "West Exit:";
            // 
            // StartingRoomLabel
            // 
            this.StartingRoomLabel.AutoSize = true;
            this.StartingRoomLabel.Location = new System.Drawing.Point(9, 373);
            this.StartingRoomLabel.Name = "StartingRoomLabel";
            this.StartingRoomLabel.Size = new System.Drawing.Size(77, 13);
            this.StartingRoomLabel.TabIndex = 19;
            this.StartingRoomLabel.Text = "Starting Room:";
            // 
            // StartingRoomCombo
            // 
            this.StartingRoomCombo.FormattingEnabled = true;
            this.StartingRoomCombo.Location = new System.Drawing.Point(92, 367);
            this.StartingRoomCombo.Name = "StartingRoomCombo";
            this.StartingRoomCombo.Size = new System.Drawing.Size(98, 21);
            this.StartingRoomCombo.TabIndex = 20;
            this.StartingRoomCombo.SelectedIndexChanged += new System.EventHandler(this.StartingRoomCombo_SelectedIndexChanged);
            // 
            // ItemEntityTabs
            // 
            this.ItemEntityTabs.Controls.Add(this.ItemTab);
            this.ItemEntityTabs.Controls.Add(this.EntityTab);
            this.ItemEntityTabs.Location = new System.Drawing.Point(398, 127);
            this.ItemEntityTabs.Name = "ItemEntityTabs";
            this.ItemEntityTabs.SelectedIndex = 0;
            this.ItemEntityTabs.Size = new System.Drawing.Size(308, 283);
            this.ItemEntityTabs.TabIndex = 21;
            // 
            // ItemTab
            // 
            this.ItemTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ItemTab.Controls.Add(this.DefenceMinusButton);
            this.ItemTab.Controls.Add(this.DefencePlusButton);
            this.ItemTab.Controls.Add(this.StrengthMinusButton);
            this.ItemTab.Controls.Add(this.StrengthPlusButton);
            this.ItemTab.Controls.Add(this.ItemDefenceLabel);
            this.ItemTab.Controls.Add(this.ItemStrengthLabel);
            this.ItemTab.Controls.Add(this.ItemDescriptionLabel);
            this.ItemTab.Controls.Add(this.ItemNameLabel);
            this.ItemTab.Controls.Add(this.ItemDefence);
            this.ItemTab.Controls.Add(this.ItemStrength);
            this.ItemTab.Controls.Add(this.ItemDescription);
            this.ItemTab.Controls.Add(this.ItemName);
            this.ItemTab.Controls.Add(this.ItemTreeView);
            this.ItemTab.Location = new System.Drawing.Point(4, 22);
            this.ItemTab.Name = "ItemTab";
            this.ItemTab.Padding = new System.Windows.Forms.Padding(3);
            this.ItemTab.Size = new System.Drawing.Size(300, 257);
            this.ItemTab.TabIndex = 0;
            this.ItemTab.Text = "Items";
            this.ItemTab.Click += new System.EventHandler(this.ItemTab_Click);
            // 
            // DefenceMinusButton
            // 
            this.DefenceMinusButton.Location = new System.Drawing.Point(181, 99);
            this.DefenceMinusButton.Name = "DefenceMinusButton";
            this.DefenceMinusButton.Size = new System.Drawing.Size(17, 20);
            this.DefenceMinusButton.TabIndex = 32;
            this.DefenceMinusButton.Text = "-";
            this.DefenceMinusButton.UseVisualStyleBackColor = true;
            this.DefenceMinusButton.Click += new System.EventHandler(this.DefenceMinusButton_Click);
            // 
            // DefencePlusButton
            // 
            this.DefencePlusButton.Location = new System.Drawing.Point(233, 99);
            this.DefencePlusButton.Name = "DefencePlusButton";
            this.DefencePlusButton.Size = new System.Drawing.Size(17, 20);
            this.DefencePlusButton.TabIndex = 31;
            this.DefencePlusButton.Text = "+";
            this.DefencePlusButton.UseVisualStyleBackColor = true;
            this.DefencePlusButton.Click += new System.EventHandler(this.DefencePlusButton_Click);
            // 
            // StrengthMinusButton
            // 
            this.StrengthMinusButton.Location = new System.Drawing.Point(100, 99);
            this.StrengthMinusButton.Name = "StrengthMinusButton";
            this.StrengthMinusButton.Size = new System.Drawing.Size(17, 20);
            this.StrengthMinusButton.TabIndex = 30;
            this.StrengthMinusButton.Text = "-";
            this.StrengthMinusButton.UseVisualStyleBackColor = true;
            this.StrengthMinusButton.Click += new System.EventHandler(this.StrengthMinusButton_Click);
            // 
            // StrengthPlusButton
            // 
            this.StrengthPlusButton.Location = new System.Drawing.Point(152, 99);
            this.StrengthPlusButton.Name = "StrengthPlusButton";
            this.StrengthPlusButton.Size = new System.Drawing.Size(17, 20);
            this.StrengthPlusButton.TabIndex = 29;
            this.StrengthPlusButton.Text = "+";
            this.StrengthPlusButton.UseVisualStyleBackColor = true;
            this.StrengthPlusButton.Click += new System.EventHandler(this.StrengthPlusButton_Click);
            // 
            // ItemDefenceLabel
            // 
            this.ItemDefenceLabel.AutoSize = true;
            this.ItemDefenceLabel.Location = new System.Drawing.Point(195, 83);
            this.ItemDefenceLabel.Name = "ItemDefenceLabel";
            this.ItemDefenceLabel.Size = new System.Drawing.Size(51, 13);
            this.ItemDefenceLabel.TabIndex = 28;
            this.ItemDefenceLabel.Text = "Defence:";
            // 
            // ItemStrengthLabel
            // 
            this.ItemStrengthLabel.AutoSize = true;
            this.ItemStrengthLabel.Location = new System.Drawing.Point(112, 83);
            this.ItemStrengthLabel.Name = "ItemStrengthLabel";
            this.ItemStrengthLabel.Size = new System.Drawing.Size(50, 13);
            this.ItemStrengthLabel.TabIndex = 27;
            this.ItemStrengthLabel.Text = "Strength:";
            // 
            // ItemDescriptionLabel
            // 
            this.ItemDescriptionLabel.AutoSize = true;
            this.ItemDescriptionLabel.Location = new System.Drawing.Point(100, 32);
            this.ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            this.ItemDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.ItemDescriptionLabel.TabIndex = 26;
            this.ItemDescriptionLabel.Text = "Description:";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(100, 8);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.ItemNameLabel.TabIndex = 25;
            this.ItemNameLabel.Text = "Name:";
            // 
            // ItemDefence
            // 
            this.ItemDefence.Location = new System.Drawing.Point(198, 99);
            this.ItemDefence.Name = "ItemDefence";
            this.ItemDefence.ReadOnly = true;
            this.ItemDefence.Size = new System.Drawing.Size(35, 20);
            this.ItemDefence.TabIndex = 24;
            this.ItemDefence.Text = "0";
            this.ItemDefence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemDefence.TextChanged += new System.EventHandler(this.ItemDefence_TextChanged);
            // 
            // ItemStrength
            // 
            this.ItemStrength.Location = new System.Drawing.Point(117, 99);
            this.ItemStrength.Name = "ItemStrength";
            this.ItemStrength.ReadOnly = true;
            this.ItemStrength.Size = new System.Drawing.Size(35, 20);
            this.ItemStrength.TabIndex = 23;
            this.ItemStrength.Text = "0";
            this.ItemStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemStrength.TextChanged += new System.EventHandler(this.ItemStrength_TextChanged);
            // 
            // ItemDescription
            // 
            this.ItemDescription.Location = new System.Drawing.Point(171, 32);
            this.ItemDescription.Multiline = true;
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Size = new System.Drawing.Size(123, 48);
            this.ItemDescription.TabIndex = 22;
            this.ItemDescription.TextChanged += new System.EventHandler(this.ItemDescription_TextChanged);
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(171, 6);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(123, 20);
            this.ItemName.TabIndex = 22;
            this.ItemName.TextChanged += new System.EventHandler(this.ItemName_TextChanged);
            // 
            // ItemTreeView
            // 
            this.ItemTreeView.Location = new System.Drawing.Point(3, 5);
            this.ItemTreeView.Name = "ItemTreeView";
            this.ItemTreeView.Size = new System.Drawing.Size(91, 246);
            this.ItemTreeView.TabIndex = 0;
            this.ItemTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ItemTreeView_AfterSelect);
            // 
            // EntityTab
            // 
            this.EntityTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EntityTab.Controls.Add(this.EntityDefenceLabel);
            this.EntityTab.Controls.Add(this.EntityStrengthLabel);
            this.EntityTab.Controls.Add(this.EntityDefence);
            this.EntityTab.Controls.Add(this.EntityStrength);
            this.EntityTab.Controls.Add(this.EntityHealthLabel);
            this.EntityTab.Controls.Add(this.EntityHealth);
            this.EntityTab.Controls.Add(this.EntityNameLabel);
            this.EntityTab.Controls.Add(this.EntityName);
            this.EntityTab.Controls.Add(this.EntityTreeView);
            this.EntityTab.Location = new System.Drawing.Point(4, 22);
            this.EntityTab.Name = "EntityTab";
            this.EntityTab.Padding = new System.Windows.Forms.Padding(3);
            this.EntityTab.Size = new System.Drawing.Size(300, 257);
            this.EntityTab.TabIndex = 1;
            this.EntityTab.Text = "Entities";
            this.EntityTab.Click += new System.EventHandler(this.EntityTab_Click);
            // 
            // EntityDefenceLabel
            // 
            this.EntityDefenceLabel.AutoSize = true;
            this.EntityDefenceLabel.Location = new System.Drawing.Point(99, 89);
            this.EntityDefenceLabel.Name = "EntityDefenceLabel";
            this.EntityDefenceLabel.Size = new System.Drawing.Size(51, 13);
            this.EntityDefenceLabel.TabIndex = 32;
            this.EntityDefenceLabel.Text = "Defence:";
            // 
            // EntityStrengthLabel
            // 
            this.EntityStrengthLabel.AutoSize = true;
            this.EntityStrengthLabel.Location = new System.Drawing.Point(100, 62);
            this.EntityStrengthLabel.Name = "EntityStrengthLabel";
            this.EntityStrengthLabel.Size = new System.Drawing.Size(50, 13);
            this.EntityStrengthLabel.TabIndex = 31;
            this.EntityStrengthLabel.Text = "Strength:";
            // 
            // EntityDefence
            // 
            this.EntityDefence.Location = new System.Drawing.Point(171, 86);
            this.EntityDefence.Name = "EntityDefence";
            this.EntityDefence.Size = new System.Drawing.Size(123, 20);
            this.EntityDefence.TabIndex = 30;
            this.EntityDefence.TextChanged += new System.EventHandler(this.EntityDefence_TextChanged);
            // 
            // EntityStrength
            // 
            this.EntityStrength.Location = new System.Drawing.Point(171, 60);
            this.EntityStrength.Name = "EntityStrength";
            this.EntityStrength.Size = new System.Drawing.Size(123, 20);
            this.EntityStrength.TabIndex = 29;
            this.EntityStrength.TextChanged += new System.EventHandler(this.EntityStrength_TextChanged);
            // 
            // EntityHealthLabel
            // 
            this.EntityHealthLabel.AutoSize = true;
            this.EntityHealthLabel.Location = new System.Drawing.Point(100, 36);
            this.EntityHealthLabel.Name = "EntityHealthLabel";
            this.EntityHealthLabel.Size = new System.Drawing.Size(41, 13);
            this.EntityHealthLabel.TabIndex = 28;
            this.EntityHealthLabel.Text = "Health:";
            // 
            // EntityHealth
            // 
            this.EntityHealth.Location = new System.Drawing.Point(171, 33);
            this.EntityHealth.Name = "EntityHealth";
            this.EntityHealth.Size = new System.Drawing.Size(123, 20);
            this.EntityHealth.TabIndex = 27;
            this.EntityHealth.TextChanged += new System.EventHandler(this.EntityHealth_TextChanged);
            // 
            // EntityNameLabel
            // 
            this.EntityNameLabel.AutoSize = true;
            this.EntityNameLabel.Location = new System.Drawing.Point(100, 8);
            this.EntityNameLabel.Name = "EntityNameLabel";
            this.EntityNameLabel.Size = new System.Drawing.Size(38, 13);
            this.EntityNameLabel.TabIndex = 26;
            this.EntityNameLabel.Text = "Name:";
            // 
            // EntityName
            // 
            this.EntityName.Location = new System.Drawing.Point(171, 6);
            this.EntityName.Name = "EntityName";
            this.EntityName.Size = new System.Drawing.Size(123, 20);
            this.EntityName.TabIndex = 23;
            this.EntityName.TextChanged += new System.EventHandler(this.EntityName_TextChanged);
            // 
            // EntityTreeView
            // 
            this.EntityTreeView.Location = new System.Drawing.Point(3, 5);
            this.EntityTreeView.Name = "EntityTreeView";
            this.EntityTreeView.Size = new System.Drawing.Size(91, 246);
            this.EntityTreeView.TabIndex = 1;
            this.EntityTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.EntityTreeView_AfterSelect);
            // 
            // WorldBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 422);
            this.Controls.Add(this.ItemEntityTabs);
            this.Controls.Add(this.StartingRoomCombo);
            this.Controls.Add(this.StartingRoomLabel);
            this.Controls.Add(this.WestExitLabel);
            this.Controls.Add(this.SouthExitLabel);
            this.Controls.Add(this.EastExitLabel);
            this.Controls.Add(this.NorthExitLabel);
            this.Controls.Add(this.WestExitCombo);
            this.Controls.Add(this.SouthExitCombo);
            this.Controls.Add(this.EastExitCombo);
            this.Controls.Add(this.NorthExitCombo);
            this.Controls.Add(this.WorldNameLabel);
            this.Controls.Add(this.WorldName);
            this.Controls.Add(this.RoomDescriptionLabel);
            this.Controls.Add(this.RoomDescription);
            this.Controls.Add(this.RoomNameLabel);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.worldTreeView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorldBuilder";
            this.Text = "WorldBuilder";
            this.Load += new System.EventHandler(this.WorldBuilder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ItemEntityTabs.ResumeLayout(false);
            this.ItemTab.ResumeLayout(false);
            this.ItemTab.PerformLayout();
            this.EntityTab.ResumeLayout(false);
            this.EntityTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView worldTreeView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entityToolStripMenuItem;
        private System.Windows.Forms.TextBox RoomName;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.TextBox RoomDescription;
        private System.Windows.Forms.Label RoomDescriptionLabel;
        private System.Windows.Forms.TextBox WorldName;
        private System.Windows.Forms.Label WorldNameLabel;
        private System.Windows.Forms.ToolStripTextBox RoomId;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
        private System.Windows.Forms.ComboBox NorthExitCombo;
        private System.Windows.Forms.OpenFileDialog OpenWorldDialog;
        private System.Windows.Forms.ComboBox EastExitCombo;
        private System.Windows.Forms.ComboBox SouthExitCombo;
        private System.Windows.Forms.ComboBox WestExitCombo;
        private System.Windows.Forms.Label NorthExitLabel;
        private System.Windows.Forms.Label EastExitLabel;
        private System.Windows.Forms.Label SouthExitLabel;
        private System.Windows.Forms.Label WestExitLabel;
        private System.Windows.Forms.ToolStripTextBox ItemId;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox EntityId;
        private System.Windows.Forms.ToolStripMenuItem addEntityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label StartingRoomLabel;
        private System.Windows.Forms.ComboBox StartingRoomCombo;
        private System.Windows.Forms.TabControl ItemEntityTabs;
        private System.Windows.Forms.TabPage ItemTab;
        private System.Windows.Forms.TabPage EntityTab;
        private System.Windows.Forms.TextBox ItemDescription;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TreeView ItemTreeView;
        private System.Windows.Forms.Button DefencePlusButton;
        private System.Windows.Forms.Button StrengthMinusButton;
        private System.Windows.Forms.Button StrengthPlusButton;
        private System.Windows.Forms.Label ItemDefenceLabel;
        private System.Windows.Forms.Label ItemStrengthLabel;
        private System.Windows.Forms.Label ItemDescriptionLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TextBox ItemDefence;
        private System.Windows.Forms.TextBox ItemStrength;
        private System.Windows.Forms.Button DefenceMinusButton;
        private System.Windows.Forms.Label EntityNameLabel;
        private System.Windows.Forms.TextBox EntityName;
        private System.Windows.Forms.TreeView EntityTreeView;
        private System.Windows.Forms.Label EntityHealthLabel;
        private System.Windows.Forms.TextBox EntityHealth;
        private System.Windows.Forms.Label EntityDefenceLabel;
        private System.Windows.Forms.Label EntityStrengthLabel;
        private System.Windows.Forms.TextBox EntityDefence;
        private System.Windows.Forms.TextBox EntityStrength;
        private System.Windows.Forms.ToolStripMenuItem exportWorldToolStripMenuItem;
    }
}