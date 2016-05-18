using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            NorthExitCombo.DataSource = new BindingSource(WorldBuild.worldRooms, null);
            NorthExitCombo.DisplayMember = "Key";
            NorthExitCombo.ValueMember = "Value";

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
            WorldBuild.setStartRoom(selected.Text);
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

        private void NorthExitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NorthExitCombo.Text == selected.Text)
            {
                //MessageBox.Show("Ping");
            } else
            {
                //MessageBox.Show(selected.Text);
                //WorldBuild.worldRooms[selected.Text].setNorthExit(WorldBuild.worldRooms[NorthExitCombo.Text]);
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
    }
}
