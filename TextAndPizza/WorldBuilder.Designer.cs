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
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsTree = new System.Windows.Forms.TreeView();
            this.EntityLabel = new System.Windows.Forms.Label();
            this.EntityTree = new System.Windows.Forms.TreeView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldTreeView
            // 
            this.worldTreeView.Location = new System.Drawing.Point(12, 28);
            this.worldTreeView.Name = "worldTreeView";
            this.worldTreeView.Size = new System.Drawing.Size(178, 382);
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
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openWorldToolStripMenuItem.Text = "Open World...";
            // 
            // saveWorldToolStripMenuItem
            // 
            this.saveWorldToolStripMenuItem.Name = "saveWorldToolStripMenuItem";
            this.saveWorldToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveWorldToolStripMenuItem.Text = "Save World...";
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
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(268, 72);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(35, 13);
            this.ItemsLabel.TabIndex = 4;
            this.ItemsLabel.Text = "Items:";
            // 
            // ItemsTree
            // 
            this.ItemsTree.Location = new System.Drawing.Point(271, 88);
            this.ItemsTree.Name = "ItemsTree";
            this.ItemsTree.Size = new System.Drawing.Size(215, 233);
            this.ItemsTree.TabIndex = 5;
            this.ItemsTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ItemsTree_AfterSelect);
            // 
            // EntityLabel
            // 
            this.EntityLabel.AutoSize = true;
            this.EntityLabel.Location = new System.Drawing.Point(489, 72);
            this.EntityLabel.Name = "EntityLabel";
            this.EntityLabel.Size = new System.Drawing.Size(44, 13);
            this.EntityLabel.TabIndex = 6;
            this.EntityLabel.Text = "Entities:";
            // 
            // EntityTree
            // 
            this.EntityTree.Location = new System.Drawing.Point(492, 88);
            this.EntityTree.Name = "EntityTree";
            this.EntityTree.Size = new System.Drawing.Size(215, 233);
            this.EntityTree.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(631, 387);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // WorldBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 422);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EntityTree);
            this.Controls.Add(this.EntityLabel);
            this.Controls.Add(this.ItemsTree);
            this.Controls.Add(this.ItemsLabel);
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
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.TreeView ItemsTree;
        private System.Windows.Forms.Label EntityLabel;
        private System.Windows.Forms.TreeView EntityTree;
        private System.Windows.Forms.Button SaveButton;
    }
}