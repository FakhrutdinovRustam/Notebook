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

namespace Блокнот
{
	
	public partial class Form1 : Form
	{
		private string FilePath;
		public Form1()
		{
			InitializeComponent();
		}
		bool tbChange = false;
		string docPath = "";
		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					FilePath = dialog.FileName;
					richTextBox1.Text = File.ReadAllText(FilePath);
				}
			}
		}

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(FilePath))
			{
				using (SaveFileDialog dialog = new SaveFileDialog())
				{
					if(dialog.ShowDialog() == DialogResult.OK)
					{
						FilePath = dialog.FileName;
						File.WriteAllText(FilePath, richTextBox1.Text);
					}
				}
			}
			File.WriteAllText(FilePath, richTextBox1.Text);
		}

		private void переносПоСловамToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (переносПоСловамToolStripMenuItem.Checked == true)
			{
				переносПоСловамToolStripMenuItem.Checked =false;
				richTextBox1.WordWrap = false;
			}
			else if(переносПоСловамToolStripMenuItem.Checked == false)
			{
				переносПоСловамToolStripMenuItem.Checked = true;
				richTextBox1.WordWrap = true;
			}
		}

		private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Undo();
		}

		private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

		private void времяИДатаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Text += DateTime.Now;
		}

		private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FontDialog dialog = new FontDialog())
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					richTextBox1.Font = dialog.Font;
				}
			}

		}

		private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
		{

			if (tbChange == true)
			{
				DialogResult message = MessageBox.Show("Сохранить текущий документ перед созданием нового?", "Создание документа", MessageBoxButtons.YesNoCancel);
				if (message == DialogResult.Yes)
				{
					if (docPath != "")
					{
						FileWork.SaveFile(ref richTextBox1, ref tbChange, ref docPath);
						FileWork.CreateFile(ref richTextBox1, ref tbChange, ref docPath);
					}
					else if (docPath == "")
					{
						FileWork.SaveAsFile(ref richTextBox1, ref tbChange, ref docPath);
						FileWork.CreateFile(ref richTextBox1, ref tbChange, ref docPath);
					}
				}
				else if (message == DialogResult.No)
				{
					FileWork.CreateFile(ref richTextBox1, ref tbChange, ref docPath);
				}
			}
			else
			{
				FileWork.CreateFile(ref richTextBox1, ref tbChange, ref docPath);
			}
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			tbChange = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Width = Properties.Settings.Default.formWidth;
			this.Height = Properties.Settings.Default.formHeight;
			richTextBox1.Font = Properties.Settings.Default.textFont;
			if (Properties.Settings.Default.statusStripVisible == true)
			{ строкаСостоянияToolStripMenuItem.CheckState = CheckState.Checked; }
			else
			{ строкаСостоянияToolStripMenuItem.CheckState = CheckState.Unchecked; }
			if (Properties.Settings.Default.textTransfer == true)
			{ переносПоСловамToolStripMenuItem.CheckState = CheckState.Checked; }
			else
			{ переносПоСловамToolStripMenuItem.CheckState = CheckState.Unchecked; }
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.formWidth = this.Width;
			Properties.Settings.Default.formHeight = this.Height;
			Properties.Settings.Default.textTransfer = richTextBox1.WordWrap;
			Properties.Settings.Default.textFont = richTextBox1.Font;
			Properties.Settings.Default.statusStripVisible = statusStrip1.Visible;
			Properties.Settings.Default.Save();
			
			
		}

		private void строкаСостоянияToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void параметрыСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
			}
		}

		private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (printDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					printDocument1.Print();
				}
				catch (Exception)
				{
					MessageBox.Show("Ошибка параметров печати.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			tbChange = true;
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
