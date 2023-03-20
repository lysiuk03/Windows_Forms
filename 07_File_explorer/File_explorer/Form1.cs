using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace File_explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dir_treeView.Nodes.Clear();
            LoadDir(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), dir_treeView.Nodes);
            LoadImageList();
            file_listView.View = View.Details;
            file_listView.Columns.Add("Name").Width = 200;
            file_listView.Columns.Add("Extencion").Width = 100;
            file_listView.Columns.Add("Create date").Width = 150;
        }

        void LoadImageList()
        {
            ImageList list = new ImageList();
            list.Images.Add(new Bitmap("Images/close.png"));
            list.Images.Add(new Bitmap("Images/open.png"));
            list.Images.Add(new Bitmap("Images/select.png"));
            dir_treeView.ImageList = list;
            list.Images.Add("k", new Bitmap("Images/item.png"));
            file_listView.LargeImageList = list;
            dir_treeView.ImageList.ImageSize = new Size(25, 25);
        }
        void LoadDir(string path, TreeNodeCollection nodes)
        {

            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var subdir in dir.GetDirectories())
            {
                TreeNode newnode = new TreeNode(subdir.Name, 0, 2);
                newnode.Tag = subdir;
                nodes.Add(newnode);
                // dir_treeView.Nodes.Add(subdir.Name);
                if (subdir.GetDirectories().Length > 0)
                {
                    LoadDir(subdir.FullName, newnode.Nodes);
                }
            }
        }

        private void dir_treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void dir_treeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void dir_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            file_listView.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(e.Node.Tag.ToString());
            foreach (var file in dir.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.ImageIndex = 3;
                item.SubItems.Add(file.Extension);
                item.SubItems.Add(file.CreationTime.ToString());
                file_listView.Items.Add(item);
            }
        }


        private void tilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file_listView.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file_listView.View = View.List;
        }

        private void largeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file_listView.View = View.LargeIcon;

        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file_listView.View = View.SmallIcon;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file_listView.View = View.Details;
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string name = "";
            Form2 form = new Form2(name);
            if (form.ShowDialog() == DialogResult.OK)
            {
                name = form.Name;
            }
            string folderPath;
            if (dir_treeView.SelectedNode == null)
            {
                folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\{name}";
            }
            else
            {
                folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + dir_treeView.SelectedNode.FullPath + $@"\{name}";
            }
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                dir_treeView.Nodes.Clear();
                LoadDir(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), dir_treeView.Nodes);
            }
            else
            {
                MessageBox.Show("This folder already exists!");
            }
        }

        private void deleteFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dir_treeView.SelectedNode == null)
            {
                MessageBox.Show("Folder is not selected!");
            }
            else
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + dir_treeView.SelectedNode.FullPath;
                Directory.Delete(path, true);
                dir_treeView.Nodes.Clear();
                LoadDir(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), dir_treeView.Nodes);
            }
        }
    }
}