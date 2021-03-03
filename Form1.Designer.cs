using System;

namespace Блокнот
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.параметрыСтраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.времяИДатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.найтиИЗаменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.переносПоСловамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.строкаСостоянияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.толькоЧтениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusLinesCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusWordsCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusCharSpaceCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusCharCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.параметрыСтраницыToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
			this.файлToolStripMenuItem.Text = "Файл";
			this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
			// 
			// создатьToolStripMenuItem
			// 
			this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
			this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.создатьToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
			this.создатьToolStripMenuItem.Text = "Создать";
			this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
			this.открытьToolStripMenuItem.Text = "Открыть";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// параметрыСтраницыToolStripMenuItem
			// 
			this.параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
			this.параметрыСтраницыToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
			this.параметрыСтраницыToolStripMenuItem.Text = "Параметры страницы";
			this.параметрыСтраницыToolStripMenuItem.Click += new System.EventHandler(this.параметрыСтраницыToolStripMenuItem_Click);
			// 
			// печатьToolStripMenuItem
			// 
			this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
			this.печатьToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
			this.печатьToolStripMenuItem.Text = "Печать";
			this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// правкаToolStripMenuItem
			// 
			this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem,
            this.времяИДатаToolStripMenuItem,
            this.найтиИЗаменитьToolStripMenuItem});
			this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
			this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
			this.правкаToolStripMenuItem.Text = "Правка";
			// 
			// отменитьToolStripMenuItem
			// 
			this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
			this.отменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.отменитьToolStripMenuItem.Text = "Отменить";
			this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
			// 
			// вырезатьToolStripMenuItem
			// 
			this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
			this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.вырезатьToolStripMenuItem.Text = "Вырезать";
			this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
			// 
			// копироватьToolStripMenuItem
			// 
			this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
			this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.копироватьToolStripMenuItem.Text = "Копировать";
			this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
			// 
			// вставитьToolStripMenuItem
			// 
			this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
			this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.вставитьToolStripMenuItem.Text = "Вставить";
			this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
			// 
			// выделитьВсеToolStripMenuItem
			// 
			this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
			this.выделитьВсеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
			this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
			// 
			// времяИДатаToolStripMenuItem
			// 
			this.времяИДатаToolStripMenuItem.Name = "времяИДатаToolStripMenuItem";
			this.времяИДатаToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.времяИДатаToolStripMenuItem.Text = "Время и дата";
			this.времяИДатаToolStripMenuItem.Click += new System.EventHandler(this.времяИДатаToolStripMenuItem_Click);
			// 
			// найтиИЗаменитьToolStripMenuItem
			// 
			this.найтиИЗаменитьToolStripMenuItem.Name = "найтиИЗаменитьToolStripMenuItem";
			this.найтиИЗаменитьToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
			this.найтиИЗаменитьToolStripMenuItem.Text = "Найти и заменить";
			this.найтиИЗаменитьToolStripMenuItem.Click += new System.EventHandler(this.найтиИЗаменитьToolStripMenuItem_Click);
			// 
			// форматToolStripMenuItem
			// 
			this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.переносПоСловамToolStripMenuItem});
			this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
			this.форматToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
			this.форматToolStripMenuItem.Text = "Формат";
			// 
			// шрифтToolStripMenuItem
			// 
			this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
			this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
			this.шрифтToolStripMenuItem.Text = "Шрифт";
			this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
			// 
			// переносПоСловамToolStripMenuItem
			// 
			this.переносПоСловамToolStripMenuItem.Name = "переносПоСловамToolStripMenuItem";
			this.переносПоСловамToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
			this.переносПоСловамToolStripMenuItem.Text = "Перенос по словам";
			this.переносПоСловамToolStripMenuItem.Click += new System.EventHandler(this.переносПоСловамToolStripMenuItem_Click);
			// 
			// видToolStripMenuItem
			// 
			this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масштабToolStripMenuItem,
            this.строкаСостоянияToolStripMenuItem,
            this.толькоЧтениеToolStripMenuItem});
			this.видToolStripMenuItem.Name = "видToolStripMenuItem";
			this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
			this.видToolStripMenuItem.Text = "Вид";
			// 
			// масштабToolStripMenuItem
			// 
			this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
			this.масштабToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.масштабToolStripMenuItem.Text = "Масштаб";
			this.масштабToolStripMenuItem.Click += new System.EventHandler(this.масштабToolStripMenuItem_Click);
			// 
			// строкаСостоянияToolStripMenuItem
			// 
			this.строкаСостоянияToolStripMenuItem.CheckOnClick = true;
			this.строкаСостоянияToolStripMenuItem.Name = "строкаСостоянияToolStripMenuItem";
			this.строкаСостоянияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.строкаСостоянияToolStripMenuItem.Text = "Строка состояния";
			this.строкаСостоянияToolStripMenuItem.Click += new System.EventHandler(this.строкаСостоянияToolStripMenuItem_Click);
			// 
			// толькоЧтениеToolStripMenuItem
			// 
			this.толькоЧтениеToolStripMenuItem.CheckOnClick = true;
			this.толькоЧтениеToolStripMenuItem.Name = "толькоЧтениеToolStripMenuItem";
			this.толькоЧтениеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.толькоЧтениеToolStripMenuItem.Text = "Только чтение";
			this.толькоЧтениеToolStripMenuItem.Click += new System.EventHandler(this.толькоЧтениеToolStripMenuItem_Click);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
			this.оПрограммеToolStripMenuItem.Text = "О программе";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLinesCount,
            this.toolStripStatusLabel2,
            this.statusWordsCount,
            this.toolStripStatusLabel3,
            this.statusCharSpaceCount,
            this.toolStripStatusLabel4,
            this.statusCharCount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 424);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 26);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
			// 
			// statusLinesCount
			// 
			this.statusLinesCount.Name = "statusLinesCount";
			this.statusLinesCount.Size = new System.Drawing.Size(119, 20);
			this.statusLinesCount.Text = "statusLinesCount";
			this.statusLinesCount.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
			// 
			// statusWordsCount
			// 
			this.statusWordsCount.Name = "statusWordsCount";
			this.statusWordsCount.Size = new System.Drawing.Size(151, 20);
			this.statusWordsCount.Text = "toolStripStatusLabel2";
			// 
			// statusCharSpaceCount
			// 
			this.statusCharSpaceCount.Name = "statusCharSpaceCount";
			this.statusCharSpaceCount.Size = new System.Drawing.Size(151, 20);
			this.statusCharSpaceCount.Text = "toolStripStatusLabel3";
			// 
			// statusCharCount
			// 
			this.statusCharCount.Name = "statusCharCount";
			this.statusCharCount.Size = new System.Drawing.Size(151, 20);
			this.statusCharCount.Text = "toolStripStatusLabel4";
			// 
			// printDialog1
			// 
			this.printDialog1.Document = this.printDocument1;
			this.printDialog1.UseEXDialog = true;
			// 
			// pageSetupDialog1
			// 
			this.pageSetupDialog1.Document = this.printDocument1;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 28);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(800, 396);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			this.richTextBox1.WordWrap = false;
			this.richTextBox1.CursorChanged += new System.EventHandler(this.richTextBox1_CursorChanged);
			this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(135, 20);
			this.toolStripStatusLabel1.Text = "Количесвто строк:";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(129, 20);
			this.toolStripStatusLabel2.Text = "Количество слов:";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(265, 20);
			this.toolStripStatusLabel3.Text = "Количество символов с пробелами :";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(166, 20);
			this.toolStripStatusLabel4.Text = "Количество символов:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Блокнот v.2.0";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void richTextBox1_CursorChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void Form1_TextChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem масштабToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem строкаСостоянияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem переносПоСловамToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem времяИДатаToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel statusLinesCount;
		private System.Windows.Forms.ToolStripStatusLabel statusWordsCount;
		private System.Windows.Forms.ToolStripStatusLabel statusCharSpaceCount;
		private System.Windows.Forms.ToolStripStatusLabel statusCharCount;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.ToolStripMenuItem параметрыСтраницыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		public System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ToolStripMenuItem найтиИЗаменитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem толькоЧтениеToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
	}
}

