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

namespace TextAndPizza
{
    public partial class WorldBuilder : Form
    {
        public TreeNode selected;
        public TreeNode selectedItem;
        public TreeNode selectedEntity;
        World WorldBuild;
        Room selectedRoom;
        Entity selectedE;

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
            //Manage the entities pane
            selectedEntity = null;
            EntityTreeView.Nodes.Clear();
            EntityName.Text = "";
            EntityHealth.Text = "";
            foreach (KeyValuePair<String, Entity> entry in selectedRoom.EntityD)
            {
                EntityTreeView.Nodes.Add(entry.Key);
            }
            selectedE = null;
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
            RoomId.Text = "";
        }

        private void openWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenWorldDialog.ShowDialog() == DialogResult.OK)
            {
                string worldPath = OpenWorldDialog.FileName;
                WorldBuild = World.Load(worldPath, ".tapwf");
                if (WorldBuild != null)
                {
                    showAll();
                    openWorldToolStripMenuItem.Enabled = false;
                    newWorldToolStripMenuItem.Enabled = false;

                    WorldName.Text = Path.GetFileNameWithoutExtension(worldPath);
                    foreach (KeyValuePair<String, Room> entry in WorldBuild.worldRooms)
                    {
                        worldTreeView.Nodes.Add(entry.Key);
                    }
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
            ItemId.Text = "";
        }

        private void newWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private string ParseRoomId(string id)
        {
            var commaIndex = id.IndexOf(',');

            if (commaIndex == -1)
            {
                return id;
            }

            return id.Substring(1, commaIndex - 1);
        }

        private void NorthExitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ParseRoomId(NorthExitCombo.Text) == selected.Text)
            {
                WorldBuild.worldRooms[selected.Text].setNorthExit(null);
            }
            else
            {
                WorldBuild.worldRooms[selected.Text].setNorthExit(WorldBuild.worldRooms[ParseRoomId(NorthExitCombo.Text)]);
            }
        }

        private void EastExitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ParseRoomId(EastExitCombo.Text) == selected.Text)
            {
                WorldBuild.worldRooms[selected.Text].setEastExit(null);
            }
            else
            {
                WorldBuild.worldRooms[selected.Text].setEastExit(WorldBuild.worldRooms[ParseRoomId(EastExitCombo.Text)]);
            }
        }

        private void SouthExitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ParseRoomId(SouthExitCombo.Text) == selected.Text)
            {
                WorldBuild.worldRooms[selected.Text].setSouthExit(null);
            }
            else
            {
                WorldBuild.worldRooms[selected.Text].setSouthExit(WorldBuild.worldRooms[ParseRoomId(SouthExitCombo.Text)]);
            }
        }

        private void WestExitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ParseRoomId(WestExitCombo.Text) == selected.Text)
            {
                WorldBuild.worldRooms[selected.Text].setWestExit(null);
            }
            else
            {
                WorldBuild.worldRooms[selected.Text].setWestExit(WorldBuild.worldRooms[ParseRoomId(WestExitCombo.Text)]);
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
            selectedEntity = EntityTreeView.SelectedNode;
            selectedE = selectedRoom.EntityD[selectedEntity.Text];
            EntityName.Text = selectedE.getName();
            EntityHealth.Text = selectedE.getMaxHealth().ToString();
            EntityDefence.Text = selectedE.getDefence().ToString();
            EntityStrength.Text = selectedE.getStrength().ToString();
        }

        private void EntityName_TextChanged(object sender, EventArgs e)
        {
            selectedE.setName(EntityName.Text);
        }

        private void addEntityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntityTreeView.Nodes.Add(EntityId.Text);
            try {
                selectedRoom.addEntity(EntityId.Text, "", 1, 0, 0);
            } catch
            {
                MessageBox.Show("Entity could not be added");
            }
        }

        private void EntityId_Click(object sender, EventArgs e)
        {
            EntityId.Text = "";
        }

        private void EntityHealth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (EntityHealth != null)
                {
                    selectedE.setMaxHealth(Int32.Parse(EntityHealth.Text));
                }
            }
            catch
            {
                MessageBox.Show("You must only have numbers in the entity health box.");
            }
            
        }

        private void WorldName_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorldName_Click(object sender, EventArgs e)
        {
            WorldName.Text = "";
        }

        private void EntityStrength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (EntityStrength.Text != null)
                {
                    selectedE.setStrength(Int32.Parse(EntityStrength.Text));
                }
            }
            catch
            {
                MessageBox.Show("You must only have numbers in the entity strength box");
            }
            
        }

        private void EntityDefence_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (EntityDefence.Text != null)
                {
                    selectedE.setDefence(Int32.Parse(EntityDefence.Text));
                }
            }
            catch
            {
                MessageBox.Show("You must only have numbers in the entity defence box");
            }
        }

        private void exportWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorldBuild.setStartRoom(StartingRoomCombo.Text);
            WorldBuild.Save("%appdata%\\" + WorldName.Text + ".tapsv");
            MessageBox.Show("World Saved:" + Environment.NewLine + "%appdata%\\" + WorldName.Text + ".tapsv");
        }
    }
}
