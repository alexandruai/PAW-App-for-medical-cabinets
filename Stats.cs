using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet_Medical_Alexandru_Andra_1052
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void labeltv_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void labeltv_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePath =(string[]) e.Data.GetData(DataFormats.FileDrop, false);
             
            foreach(String path in filePath)
            {
                string[] content = File.ReadAllLines(path);

                TreeNode root = new TreeNode("Medici");
                treeView.Nodes.Add(root);

                foreach(String line in content)
                {
                    string[] tokens = line.Split('\t');

                    TreeNode child = new TreeNode(tokens[0]);
                    root.Nodes.Add(child);

                    TreeNode _1grandchild = new TreeNode(tokens[1]);
                    TreeNode _2grandchild = new TreeNode(tokens[2]);
                    TreeNode _3grandchild = new TreeNode(tokens[3]);
                    TreeNode _4grandchild = new TreeNode(tokens[4]);

                    child.Nodes.Add(_1grandchild);
                    child.Nodes.Add(_2grandchild);
                    child.Nodes.Add(_3grandchild);
                    child.Nodes.Add(_4grandchild);
                }

                treeView.ExpandAll();
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selected = treeView.SelectedNode;

            toolStripLbS.Text = "Ati selectat nodul: " + selected.FullPath;
        }
    }
}
