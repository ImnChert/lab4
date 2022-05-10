namespace lab4
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.OppentButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(248, 31);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(213, 354);
			this.treeView1.TabIndex = 0;
			this.treeView1.Visible = false;
			this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
			this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Моя папка",
			"Не моя папка"});
			this.comboBox1.Location = new System.Drawing.Point(33, 127);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(139, 27);
			this.comboBox1.TabIndex = 1;
			// 
			// OppentButton
			// 
			this.OppentButton.Location = new System.Drawing.Point(53, 193);
			this.OppentButton.Name = "OppentButton";
			this.OppentButton.Size = new System.Drawing.Size(86, 26);
			this.OppentButton.TabIndex = 2;
			this.OppentButton.Text = "Open";
			this.OppentButton.UseVisualStyleBackColor = true;
			this.OppentButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(53, 247);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(86, 26);
			this.RemoveButton.TabIndex = 3;
			this.RemoveButton.Text = "Remove";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Visible = false;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(581, 301);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 26);
			this.button1.TabIndex = 5;
			this.button1.Text = "Считать с файла";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(545, 85);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
			this.richTextBox1.Size = new System.Drawing.Size(195, 153);
			this.richTextBox1.TabIndex = 6;
			this.richTextBox1.Text = "";
			this.richTextBox1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.OppentButton);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.treeView1);
			this.Name = "Form1";
			this.Text = "Форма номер 1";
			this.ResumeLayout(false);

		}

		#endregion
		private TreeView treeView1;
		private ComboBox comboBox1;
		private Button OppentButton;
		private Button RemoveButton;
		private OpenFileDialog openFileDialog1;
		private Button button1;
		private RichTextBox richTextBox1;
	}
}