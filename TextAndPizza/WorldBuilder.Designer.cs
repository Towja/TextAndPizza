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
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomName = new System.Windows.Forms.TextBox();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.RoomDescription = new System.Windows.Forms.TextBox();
            this.RoomDescriptionLabel = new System.Windows.Forms.Label();
            this.ItemsAndEntitesTabs = new System.Windows.Forms.TabControl();
            this.ItemsTab = new System.Windows.Forms.TabPage();
            this.EntitiesTab = new System.Windows.Forms.TabPage();
            this.WorldName = new System.Windows.Forms.TextBox();
            this.WorldNameLabel = new System.Windows.Forms.Label();
            this.RoomId = new System.Windows.Forms.ToolStripTextBox();
            this.addRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ItemsAndEntitesTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldTreeView
            // 
            this.worldTreeView.Location = new System.Drawing.Point(12, 28);
            this.worldTreeView.Name = "worldTreeView";
            this.worldTreeView.Size = new System.Drawing.Size(178, 142);
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
            this.openWorldToolStripMenuItem,
            this.saveWorldToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openWorldToolStripMenuItem.Text = "Open World...";
            // 
            // saveWorldToolStripMenuItem
            // 
            this.saveWorldToolStripMenuItem.Name = "saveWorldToolStripMenuItem";
            this.saveWorldToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveWorldToolStripMenuItem.Text = "Save World...";
            this.saveWorldToolStripMenuItem.Click += new System.EventHandler(this.saveWorldToolStripMenuItem_Click);
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
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.itemToolStripMenuItem.Text = "Item";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // entityToolStripMenuItem
            // 
            this.entityToolStripMenuItem.Name = "entityToolStripMenuItem";
            this.entityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.entityToolStripMenuItem.Text = "Entity";
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
            // ItemsAndEntitesTabs
            // 
            this.ItemsAndEntitesTabs.Controls.Add(this.ItemsTab);
            this.ItemsAndEntitesTabs.Controls.Add(this.EntitiesTab);
            this.ItemsAndEntitesTabs.Location = new System.Drawing.Point(271, 137);
            this.ItemsAndEntitesTabs.Name = "ItemsAndEntitesTabs";
            this.ItemsAndEntitesTabs.SelectedIndex = 0;
            this.ItemsAndEntitesTabs.Size = new System.Drawing.Size(435, 273);
            this.ItemsAndEntitesTabs.TabIndex = 6;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Location = new System.Drawing.Point(4, 22);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTab.Size = new System.Drawing.Size(427, 247);
            this.ItemsTab.TabIndex = 0;
            this.ItemsTab.Text = "Items";
            this.ItemsTab.UseVisualStyleBackColor = true;
            this.ItemsTab.Click += new System.EventHandler(this.ItemsTab_Click);
            // 
            // EntitiesTab
            // 
            this.EntitiesTab.Location = new System.Drawing.Point(4, 22);
            this.EntitiesTab.Name = "EntitiesTab";
            this.EntitiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.EntitiesTab.Size = new System.Drawing.Size(427, 247);
            this.EntitiesTab.TabIndex = 1;
            this.EntitiesTab.Text = "Entities";
            this.EntitiesTab.UseVisualStyleBackColor = true;
            this.EntitiesTab.Click += new System.EventHandler(this.EntitiesTab_Click);
            // 
            // WorldName
            // 
            this.WorldName.Location = new System.Drawing.Point(90, 176);
            this.WorldName.Name = "WorldName";
            this.WorldName.Size = new System.Drawing.Size(100, 20);
            this.WorldName.TabIndex = 9;
            this.WorldName.Text = "exampleworld";
            // 
            // WorldNameLabel
            // 
            this.WorldNameLabel.AutoSize = true;
            this.WorldNameLabel.Location = new System.Drawing.Point(21, 179);
            this.WorldNameLabel.Name = "WorldNameLabel";
            this.WorldNameLabel.Size = new System.Drawing.Size(69, 13);
            this.WorldNameLabel.TabIndex = 10;
            this.WorldNameLabel.Text = "World Name:";
            // 
            // RoomId
            // 
            this.RoomId.Name = "RoomId";
            this.RoomId.Size = new System.Drawing.Size(100, 23);
            this.RoomId.Text = "Room ID";
            // 
            // addRoomToolStripMenuItem
            // 
            this.addRoomToolStripMenuItem.Name = "addRoomToolStripMenuItem";
            this.addRoomToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addRoomToolStripMenuItem.Text = "Add Room";
            this.addRoomToolStripMenuItem.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // WorldBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 422);
            this.Controls.Add(this.WorldNameLabel);
            this.Controls.Add(this.WorldName);
            this.Controls.Add(this.ItemsAndEntitesTabs);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ItemsAndEntitesTabs.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl ItemsAndEntitesTabs;
        private System.Windows.Forms.TabPage ItemsTab;
        private System.Windows.Forms.TabPage EntitiesTab;
        private System.Windows.Forms.TextBox WorldName;
        private System.Windows.Forms.Label WorldNameLabel;
        private System.Windows.Forms.ToolStripTextBox RoomId;
        private System.Windows.Forms.ToolStripMenuItem addRoomToolStripMenuItem;
    }
}