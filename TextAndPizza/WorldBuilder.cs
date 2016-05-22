﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextAndPizza
{
    public partial class WorldBuilder : Form
    {
        public TreeNode selected;
        public TreeNode selectedItem;
        public TreeNode selectedEntity;
        World WorldBuild;
        Room selectedRoom;

        public WorldBuilder()
        {
            InitializeComponent();
            WorldBuild = new World();
            hideAll();
        }

        private void worldTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selected = worldTreeView.SelectedNode;
            selectedRoom = WorldBuild.worldRooms[selected.Text];
            RoomName.Text = WorldBuild.worldRooms[selected.Text].Name;
            RoomDescription.Text = WorldBuild.worldRooms[selected.Text].Description;
            //Load the data for the combo boxes
            //North
            NorthExitCombo.DataSource = new BindingSource(WorldBuild.worldRooms, null);
            NorthExitCombo.DisplayMember = "Key";
            NorthExitCombo.ValueMember = "Value";
            //This should make the dropdown boxes display the proper values of the north exit, but it doesn't. Must fix this.
            if (WorldBuild.worldRooms[selected.Text].NorthExit != null)
            {
                NorthExitCombo.SelectedValue = WorldBuild.worldRooms[selected.Text].NorthExit;
            } else
            {
                NorthExitCombo.SelectedValue = WorldBuild.worldRooms[selected.Text];
            }
            //East
            EastExitCombo.DataSource = new BindingSource(WorldBuild.worldRooms, null);
            EastExitCombo.DisplayMember = "Key";
            EastExitCombo.ValueMember = "Value";
            //South
            SouthExitCombo.DataSource = new BindingSource(WorldBuild.worldRooms, null);
            SouthExitCombo.DisplayMember = "Key";
            SouthExitCombo.ValueMember = "Value";
            //West
            WestExitCombo.DataSource = new BindingSource(WorldBuild.worldRooms, null);
            WestExitCombo.DisplayMember = "Key";
            WestExitCombo.ValueMember = "Value";
            //BeginingRoom
            StartingRoomCombo.DataSource = new BindingSource(WorldBuild.worldRooms, null);
            StartingRoomCombo.DisplayMember = "Key";
            StartingRoomCombo.ValueMember = "Value";
            //Set combo box values
            if (WorldBuild.CurrentRoom != null)
            {
                StartingRoomCombo.SelectedValue = WorldBuild.CurrentRoom;
            } else
            {
                StartingRoomCombo.SelectedValue = selectedRoom;
            }
            //Manage the items pane
            selectedItem = null;
            ItemTreeView.Nodes.Clear();
            ItemName.Text = "";
            ItemDescription.Text = "";
            ItemDefence.Text = "0";
            ItemStrength.Text = "0";
            foreach (KeyValuePair<String, Item> entry in selectedRoom.Item)
            {
                ItemTreeView.Nodes.Add(entry.Key);
            }
        }

        private void makeUneditable()
        {
            RoomName.ReadOnly = true;
            RoomDescription.ReadOnly = true;
        }

        private void hideAll()
        {
            worldTreeView.Visible = false;
            WorldNameLabel.Visible = false;
            WorldName.Visible = false;
            RoomNameLabel.Visible = false;
            RoomName.Visible = false;
            RoomDescriptionLabel.Visible = false;
            RoomDescription.Visible = false;
            NorthExitLabel.Visible = false;
            NorthExitCombo.Visible = false;
            EastExitLabel.Visible = false;
            EastExitCombo.Visible = false;
            SouthExitLabel.Visible = false;
            SouthExitCombo.Visible = false;
            WestExitLabel.Visible = false;
            WestExitCombo.Visible = false;
            StartingRoomLabel.Visible = false;
            StartingRoomCombo.Visible = false;
            ItemEntityTabs.Visible = false;
        }

        private void showAll()
        {
            worldTreeView.Visible = true;
            WorldNameLabel.Visible = true;
            WorldName.Visible = true;
            RoomNameLabel.Visible = true;
            RoomName.Visible = true;
            RoomDescriptionLabel.Visible = true;
            RoomDescription.Visible = true;
            NorthExitLabel.Visible = true;
            NorthExitCombo.Visible = true;
            EastExitLabel.Visible = true;
            EastExitCombo.Visible = true;
            SouthExitLabel.Visible = true;
            SouthExitCombo.Visible = true;
            WestExitLabel.Visible = true;
            WestExitCombo.Visible = true;
            StartingRoomLabel.Visible = true;
            StartingRoomCombo.Visible = true;
            ItemEntityTabs.Visible = true;
        }

        private void makeEditable()
        {
            RoomName.ReadOnly = false;
            RoomDescription.ReadOnly = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
 
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void RoomName_TextChanged(object sender, EventArgs e)
        {
            if (selected != null)
            {
                WorldBuild.worldRooms[selected.Text].setName(RoomName.Text);
            }
        }

        private void ItemsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorldBuild.setStartRoom(StartingRoomCombo.Text);
            WorldBuild.Save("%appdata%\\" + WorldName.Text + ".tapwf");
            MessageBox.Show("World Saved:" + Environment.NewLine + "%appdata%\\" + WorldName.Text + ".tapwf");
        }

        private void ItemsTab_Click(object sender, EventArgs e)
        {

        }

        private void EntitiesTab_Click(object sender, EventArgs e)
        {

        }

        private void RoomId_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorldBuild.AddRoom(RoomId.Text, null, null, null, null, null, null, null, null);
            TreeNode roomNode = worldTreeView.Nodes.Add(RoomId.Text);
        }

        private void RoomDescription_TextChanged(object sender, EventArgs e)
        {
            if (selected != null)
            {
                WorldBuild.worldRooms[selected.Text].setDescription(RoomDescription.Text);
            }
        }

        private void RoomId_Click(object sender, EventArgs e)
        {

        }

        private void openWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenWorldDialog.ShowDialog() == DialogResult.OK)
            {
                showAll();
                openWorldToolStripMenuItem.Enabled = false;
                newWorldToolStripMenuItem.Enabled = false;
                string worldPath = OpenWorldDialog.FileName;
                WorldBuild = World.Load(worldPath);
                foreach (KeyValuePair<String, Room> entry in WorldBuild.worldRooms)
                {
                    worldTreeView.Nodes.Add(entry.Key);
                }
            }
        }

        private void OpenWorldDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void WorldBuilder_Load(object sender, EventArgs e)
        {

        }

        private void toolStripItemId_Click(object sender, EventArgs e)
        {

        }

        private void newWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private void NorthExitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NorthExitCombo.Text.Contains(selected.Text))
            {
                WorldBuild.worldRooms[selected.Text].setNorthExit(null);
            }
            else
            {
                WorldBuild.worldRooms[selected.Text].setNorthExit(WorldBuild.worldRooms[NorthExitCombo.Text]);
            }
        }

        private void EastExitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EastExitCombo.Text.Contains(selected.Text))
            {
                WorldBuild.worldRooms[selected.Text].setEastExit(null);
            }
            else
            {
                WorldBuild.worldRooms[selected.Text].setEastExit(WorldBuild.worldRooms[EastExitCombo.Text]);
            }
        }

        private void SouthExitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SouthExitCombo.Text.Contains(selected.Text))
            {
                WorldBuild.worldRooms[selected.Text].setSouthExit(null);
            }
            else
            {
                WorldBuild.worldRooms[selected.Text].setSouthExit(WorldBuild.worldRooms[SouthExitCombo.Text]);
            }
        }

        private void WestExitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WestExitCombo.Text.Contains(selected.Text))
            {
                WorldBuild.worldRooms[selected.Text].setWestExit(null);
            }
            else
            {
                WorldBuild.worldRooms[selected.Text].setWestExit(WorldBuild.worldRooms[WestExitCombo.Text]);
            }
        }

        private void ItemTab_Click(object sender, EventArgs e)
        {

        }

        private void EntityTab_Click(object sender, EventArgs e)
        {

        }

        private void StrengthMinusButton_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(ItemStrength.Text);
            n--;
            ItemStrength.Text = n.ToString();
        }

        private void StrengthPlusButton_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(ItemStrength.Text);
            n++;
            ItemStrength.Text = n.ToString();
        }

        private void ItemName_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedRoom.changeItemName(selectedItem.Text, ItemName.Text);
            }
        }

        private void ItemDescription_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedRoom.changeItemDescription(selectedItem.Text, ItemDescription.Text);
            }
        }

        private void ItemTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedItem = ItemTreeView.SelectedNode;
            ItemName.Text = selectedRoom.Item[selectedItem.Text].getName();
            ItemDescription.Text = selectedRoom.Item[selectedItem.Text].getDescription();
            ItemStrength.Text = selectedRoom.Item[selectedItem.Text].getStrengthStats().ToString();
            ItemDefence.Text = selectedRoom.Item[selectedItem.Text].getDefenceStats().ToString();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemTreeView.Nodes.Add(ItemId.Text);
            selectedRoom.addItem(ItemId.Text, null, null, 0, 0);
        }

        private void ItemStrength_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedRoom.changeItemStrength(selectedItem.Text, Int32.Parse(ItemStrength.Text));
            }
        }

        private void ItemDefence_TextChanged(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                selectedRoom.changeItemDefence(selectedItem.Text, Int32.Parse(ItemStrength.Text));
            }
        }

        private void DefenceMinusButton_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(ItemDefence.Text);
            n--;
            ItemDefence.Text = n.ToString();
        }

        private void DefencePlusButton_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(ItemDefence.Text);
                n++;
            ItemDefence.Text = n.ToString();
        }

        private void EntityTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void EntityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EntityDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntityTreeView.Nodes.Add(EntityId.Text);
            try {
                selectedRoom.addEntity(EntityId.Text, null, 1, 0, 0);
            } catch
            {
                //Ignore
            }
        }

        private void EntityId_Click(object sender, EventArgs e)
        {

        }
    }
}
