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
        }

        private void worldTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selected = worldTreeView.SelectedNode;
            RoomId.Text = selected.Text;
            

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
            WorldBuild.worldRooms[selected.Text].setName(RoomName.Text);
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
            WorldBuild.Save("%appdata%\\" + WorldName.Text + ".bin");
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
            WorldBuild.worldRooms[selected.Text].setDescription(RoomDescription.Text);
        }
    }
}
