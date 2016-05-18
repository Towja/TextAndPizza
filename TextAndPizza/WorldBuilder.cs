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
        World WorldBuild;

        public WorldBuilder()
        {
            InitializeComponent();
            WorldBuild = new World();
            hideAll();
        }

        private void worldTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selected = worldTreeView.SelectedNode;
            RoomName.Text = WorldBuild.worldRooms[selected.Text].Name;
            RoomDescription.Text = WorldBuild.worldRooms[selected.Text].Description;
            //Load the data for the combo boxes
            //North
            NorthExitCombo.DataSource = new BindingSource(WorldBuild.worldRooms, null);
            NorthExitCombo.DisplayMember = "Key";
            NorthExitCombo.ValueMember = "Value";
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
            //BeginningRoom
            StartingRoomCombo.DataSource = new BindingSource(WorldBuild.worldRooms, null);
            StartingRoomCombo.DisplayMember = "Key";
            StartingRoomCombo.ValueMember = "Value";
            //Set combo box values
            StartingRoomCombo.SelectedValue = WorldBuild.CurrentRoom;
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

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void newWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private void NorthExitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NorthExitCombo.Text == selected.Text)
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
            if (EastExitCombo.Text == selected.Text)
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
            if (SouthExitCombo.Text == selected.Text)
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
            if (WestExitCombo.Text == selected.Text)
            {
                WorldBuild.worldRooms[selected.Text].setWestExit(null);
            }
            else
            {
                WorldBuild.worldRooms[selected.Text].setWestExit(WorldBuild.worldRooms[WestExitCombo.Text]);
            }
        }
    }
}
