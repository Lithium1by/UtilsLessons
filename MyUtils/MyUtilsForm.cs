﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtils
{
    public partial class frmUtils : Form
    {
        int count = 0;
        Random rnd;
        char[] spec_char = new char[] { '#', '%', '^', '&', '*', '(' };

        public frmUtils()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработал:Витя Терехов!!!", "О программе");
        }

        private void btnCountPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnCountMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(nudFrom.Value), Convert.ToInt32(nudTo.Value) + 1);
            lblRandomResult.Text = n.ToString();
            if (cbRandom.Checked == true)
            {
                if (tbRandom.Text.IndexOf(n.ToString()) == -1)
                    tbRandom.AppendText(n + "\n");
            }
            else tbRandom.AppendText(n + "\n");
        }

        private void btnRandomListClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
            lblRandomResult.Text = "0";
        }

        private void btnRandomListCopy_Click(object sender, EventArgs e)
        {
            /*добавил проверку на отсутствие текста сам ибо ошибку выбивало 
            по видосу если делать при пустом ТекстБоксе!!!))))*/
            if (tbRandom.Text != "")
            {
                Clipboard.SetText(tbRandom.Text);
            }
            else MessageBox.Show("Нечего копироват Оо");
        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void tsmiInsertTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        void LoadNotepad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки");
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }
        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void frmUtils_Load(object sender, EventArgs e)
        {
            LoadNotepad();
            clbPassProp.SetItemChecked(0, true);
            clbPassProp.SetItemChecked(1, true);
        }

        private void btnPassGreate_Click(object sender, EventArgs e)
        {
            if (clbPassProp.CheckedItems.Count == 0) return;
            string password = "";

            for (int i = 0; i < nudPassLength.Value; i++)
            {
                int n = rnd.Next(0, clbPassProp.CheckedItems.Count);
                string s = clbPassProp.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры":
                        password += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_char[rnd.Next(spec_char.Length)];
                        break;
                }
                tbPassword.Text = password;
                Clipboard.SetText(password);
            }

        }
    }
}
