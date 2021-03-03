using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Блокнот
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        public static class TextWork
        {
            // Метод поиска текста в TextBox
            // Для использования создаем в форме поиска глобальную переменную 
            // типа int = 0 для стартовой позиции поиска,
            // передаем в метод ссылки на TextBox'ы с исходным и искомым текстами,
            // а также необходимо указать, учитывать ли регистр букв при поиске (True - учитывать, False - не учитывать)
            public static int FindTextBox(ref RichTextBox textBox, string findText, ref int findCutLength, bool register)
            {
                // Поиск с учетом регистра
                if (register == true)
                {
                    if (textBox.Text.Contains(findText))
                    {
                        // Заносим текст в переменную string, удаляем из него уже пройденный 
                        // текст (findCutLength) в переменной nextText
                        string text = textBox.Text;
                        string nextText = text.Remove(0, findCutLength);
                        // Ищем в nextText
                        int resultPosition = nextText.IndexOf(findText);
                        // Если искомое выражение найдено - выделяем его, добавляем его позицию и длину 
                        // к значению пройденного текста (findCutLenght)
                        if (resultPosition != -1)
                        {
                            textBox.Select(resultPosition + findCutLength, findText.Length);
                            textBox.ScrollToCaret();
                            textBox.Focus();
                            findCutLength += findText.Length + resultPosition;
                        }
                        // Если попытка поиска не первая, и больше совпадений в тексте нет - обнуляем
                        // значение пройденного текста и начинаем поиск сначала
                        else if (resultPosition == -1 && findCutLength != 0)
                        {
                            findCutLength = 0;
                            return FindTextBox(ref textBox, findText, ref findCutLength, register);
                        }
                    }
                    else
                    {
                        findCutLength = 0;
                        MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // Поиск без учета регистра
                else if (register == false)
                {
                    if (textBox.Text.ToLower().Contains(findText.ToLower()))
                    {
                        string text = textBox.Text.ToLower();
                        string nextText = text.Remove(0, findCutLength);
                        int resultPosition = nextText.IndexOf(findText.ToLower());

                        if (resultPosition != -1)
                        {
                            textBox.Select(resultPosition + findCutLength, findText.Length);
                            textBox.ScrollToCaret();
                            textBox.Focus();
                            findCutLength += findText.Length + resultPosition;
                        }
                        else if (resultPosition == -1 && findCutLength != 0)
                        {
                            findCutLength = 0;
                            return FindTextBox(ref textBox, findText, ref findCutLength, register);
                        }
                    }
                    // Если текст изначально не содержит результатов поиска - обнуляем findCutLength, выводим сообщение
                    else
                    {
                        findCutLength = 0;
                        MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                return 0;
            }

            // Метод "Заменить"
            public static int ReplaceTextBox(ref RichTextBox textBox, string findText, string replaceText, ref int findCutLength, bool register)
            {
                if (register == true)
                {
                    if (textBox.Text.Contains(findText))
                    {
                        if (textBox.SelectedText == "" || textBox.SelectedText != findText)
                        {
                            string text = textBox.Text;
                            string nextText = text.Remove(0, findCutLength);
                            int resultPosition = nextText.IndexOf(findText);
                            if (resultPosition != -1)
                            {
                                textBox.Select(resultPosition + findCutLength, findText.Length);
                                textBox.ScrollToCaret();
                                textBox.Focus();
                                findCutLength += findText.Length + resultPosition;
                            }
                            else if (resultPosition == -1 && findCutLength != 0)
                            {
                                findCutLength = 0;
                                return ReplaceTextBox(ref textBox, findText, replaceText, ref findCutLength, register);
                            }
                        }
                        else if (textBox.SelectedText == findText)
                        {
                            textBox.SelectedText = replaceText;
                        }
                    }
                    else
                    {
                        findCutLength = 0;
                        MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (register == false)
                {
                    if (textBox.Text.ToLower().Contains(findText.ToLower()))
                    {
                        if (textBox.SelectedText == "" || textBox.SelectedText.ToLower() != findText.ToLower())
                        {
                            string text = textBox.Text.ToLower();
                            string nextText = text.Remove(0, findCutLength);
                            int resultPosition = nextText.IndexOf(findText.ToLower());
                            if (resultPosition != -1)
                            {
                                textBox.Select(resultPosition + findCutLength, findText.Length);
                                textBox.ScrollToCaret();
                                textBox.Focus();
                                findCutLength += findText.Length + resultPosition;
                            }
                            else if (resultPosition == -1 && findCutLength != 0)
                            {
                                findCutLength = 0;
                                return ReplaceTextBox(ref textBox, findText, replaceText, ref findCutLength, register);
                            }
                        }
                        else if (textBox.SelectedText.ToLower() == findText.ToLower())
                        {
                            textBox.SelectedText = replaceText;
                        }
                    }
                    else
                    {
                        findCutLength = 0;
                        MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return 0;
            }

            // Метод "Заменить всё"
            public static int ReplaceAllTextBox(ref RichTextBox textBox, string findText, string replaceText, bool register)
            {
                if (register == true)
                {
                    string text = textBox.Text;
                    string words = findText;
                    if (textBox.Text.Contains(words))
                    {
                        int startPosition = text.IndexOf(words);
                        textBox.Select(startPosition, words.Length);
                        textBox.SelectedText = replaceText;
                        return ReplaceAllTextBox(ref textBox, findText, replaceText, register);
                    }
                    else
                    {
                        MessageBox.Show("Замены произведены успешно.", "Заменить всё", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (register == false)
                {
                    string text = textBox.Text.ToLower();
                    string words = findText.ToLower();
                    if (text.Contains(words))
                    {
                        int startPosition = text.IndexOf(words);
                        textBox.Select(startPosition, findText.Length);
                        textBox.SelectedText = replaceText;
                        return ReplaceAllTextBox(ref textBox, findText, replaceText, register);
                    }
                    else
                    {
                        MessageBox.Show("Замены произведены успешно.", "Заменить всё", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return 0;
            }

            public static void mEditEnableds(ref RichTextBox notebox, ref ToolStripMenuItem mEditCopy, ref ToolStripMenuItem mEditCut, ref ToolStripMenuItem mEditDel)
            {
                if (notebox.Text.Length < 1)
                {
                    mEditCopy.Enabled = false;
                    mEditCut.Enabled = false;
                    mEditDel.Enabled = false;

                }
                else
                {
                    mEditCopy.Enabled = true;
                    mEditCut.Enabled = true;
                    mEditDel.Enabled = true;
                }
            }
        }

        private void SearchForm_Shown(object sender, EventArgs e) // Событие при открытии формы поиска и замены
        {
            textBox1.Focus();
        }

        int findCutLength = 0; // На сколько символов обрезаем текст для поиска

        private void tbFind_TextChanged(object sender, EventArgs e) // Cобытие при изменении текста в tbFind
        {
            findCutLength = 0;
        }

        private void tbReplace_TextChanged(object sender, EventArgs e) // Событие при изменении текста в tbReplace
        {
            findCutLength = 0;
        }

        private void cbReg_CheckStateChanged(object sender, EventArgs e) // Событие при изменении статуса cbReg
        {
            findCutLength = 0;
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e) // Событие при закрытии формы (до закрытия)
        {
            findCutLength = 0;
        }
		private void button4_Click_1(object sender, EventArgs e)
		{
            this.Close();
        }

		private void button2_Click(object sender, EventArgs e)// Кнопка "Заменить всё"
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {

                TextWork.ReplaceAllTextBox(ref main.richTextBox1, textBox1.Text, textBox2.Text, true);

            }
        }

		private void button3_Click(object sender, EventArgs e)// Кнопка "Заменить"
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {

                TextWork.ReplaceTextBox(ref main.richTextBox1, textBox1.Text, textBox2.Text, ref findCutLength, true);
            }
        }

		private void button1_Click(object sender, EventArgs e)// Кнопка "Найти"
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                TextWork.FindTextBox(ref main.richTextBox1, textBox1.Text, ref findCutLength, false);
            }
        }
	}
}
