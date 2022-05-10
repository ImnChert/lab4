namespace lab4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			e.Node.Nodes.Clear();
			string[] dirs;
			try
			{
				if (Directory.Exists(e.Node.FullPath))
				{
					dirs = Directory.GetDirectories(e.Node.FullPath);
					if (dirs.Length != 0)
					{
						for (int i = 0; i < dirs.Length; i++)
						{
							TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
							FillTreeNode(dirNode, dirs[i]);
							e.Node.Nodes.Add(dirNode);
						}
					}
				}
			}
			catch { }
		}

		void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			e.Node.Nodes.Clear();
			string[] dirs;
			try
			{
				if (Directory.Exists(e.Node.FullPath))
				{
					dirs = Directory.GetDirectories(e.Node.FullPath);
					if (dirs.Length != 0)
					{
						for (int i = 0; i < dirs.Length; i++)
						{
							TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
							FillTreeNode(dirNode, dirs[i]);
							e.Node.Nodes.Add(dirNode);
						}
					}
				}
			}
			catch { }
		}

		private void FillTreeNode(TreeNode driveNode, string path)
		{
			try
			{
				string[] dirs = Directory.GetDirectories(path);
				foreach (string dir in dirs)
				{
					var dirNode = new TreeNode();
					dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
					driveNode.Nodes.Add(dirNode);
				}
			}
			catch { }
		}

		private void button1_Click(object sender, EventArgs e)
		{
			treeView1.Nodes.Clear();
			treeView1.BeforeSelect += treeView1_BeforeSelect;
			treeView1.BeforeExpand += treeView1_BeforeExpand;

			OpenDrive(_paths[comboBox1.SelectedIndex]);

			RemoveButton.Visible = true;
		}

		private string[] _paths =
		{
			@"D:\моя\твоя",
			@"D:\моя\не твоя"
		};

		private void OpenDrive(string path)
		{
			TreeNode driveNode = new TreeNode
			{
				Text = path
			};

			FillTreeNode(driveNode, driveNode.Text);
			treeView1.Nodes.Add(driveNode);
			treeView1.Visible = true;
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			var dir = new DirectoryInfo(Path.Combine(treeView1.SelectedNode.FullPath));
			dir.Delete();
			treeView1.SelectedNode.Remove();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;

			string filename = openFileDialog1.FileName;

			string fileText = File.ReadAllText(filename);
			richTextBox1.Text = fileText;
			richTextBox1.Visible = true;
		}
	}
}