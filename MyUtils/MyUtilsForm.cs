using System;
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
        Dictionary<string, double> metrica;

        public frmUtils()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("мм", 1);
            metrica.Add("см", 10);
            metrica.Add("дм", 100);
            metrica.Add("м", 1000);
            metrica.Add("км", 1000000);
            metrica.Add("мили", 1609344);
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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbFrom.Text];
            double m2 = metrica[cbTo.Text];
            double n = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (n * m1 / m2).ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string t = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = t;
        }

        private void cbMetrica_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetrica.Text)
            {
                case "длина":
                    metrica.Clear();
                    metrica.Add("мм", 1);
                    metrica.Add("см", 10);
                    metrica.Add("дм", 100);
                    metrica.Add("м", 1000);
                    metrica.Add("км", 1000000);
                    metrica.Add("мили", 1609344);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("мм");
                    cbFrom.Items.Add("см");
                    cbFrom.Items.Add("дм");
                    cbFrom.Items.Add("м");
                    cbFrom.Items.Add("км");
                    cbFrom.Items.Add("мили");
                    cbFrom.Text = "мм";
                    cbTo.Items.Clear();
                    cbTo.Items.Add("мм");
                    cbTo.Items.Add("см");
                    cbTo.Items.Add("дм");
                    cbTo.Items.Add("м");
                    cbTo.Items.Add("км");
                    cbTo.Items.Add("мили");
                    cbTo.Text = "мм";
                    break;
                case "вес":
                    metrica.Clear();
                    metrica.Add("гр", 1);
                    metrica.Add("oz", 283);
                    metrica.Add("фунт", 453.6);
                    metrica.Add("кг", 1000);
                    metrica.Add("т", 1000000);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("фунт");
                    cbFrom.Items.Add("oz");
                    cbFrom.Items.Add("гр");
                    cbFrom.Items.Add("кг");
                    cbFrom.Items.Add("т");
                    cbFrom.Text = "гр";
                    cbTo.Items.Clear();
                    cbTo.Items.Add("гр");
                    cbTo.Items.Add("фунт");
                    cbTo.Items.Add("oz");
                    cbTo.Items.Add("кг");
                    cbTo.Items.Add("т");
                    cbTo.Text = "гр";
                    break;
                default:
                    break;
            }
        }
    }
}
