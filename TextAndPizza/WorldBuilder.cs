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
            RoomName.Text = selected.Text;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode roomNode = worldTreeView.Nodes.Add("New Room");
        }
 
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void RoomName_TextChanged(object sender, EventArgs e)
        {
        }

        private void ItemsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            selected.Text = RoomName.Text;
        }
    }
}
