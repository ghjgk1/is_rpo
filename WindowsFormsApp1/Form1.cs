using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using Telegram.Bot;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int i1 = 0, i2 = 0, i3 = 0, i4 = 0, i5 = 0;
        List<string> name = new List<string>();
        List<string> sname = new List<string>();
        List<string> login = new List<string>();
        List<string> pass = new List<string>();
        List<string> email = new List<string>();

        string api = "7807553130:AAFxO9VmK4VBHHxI4j7qC2DNxH7BmnEk9Ig";
        string chatId = "1424710372";
        void close()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            i1 = i2 = i3 = i4 = i5 = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i1 % 2== 0)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                i1++;
                i2 = i3 = i4 = i5 = 0;
            }
            else close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < name.Count; i++)
            {
                comboBox1.Items.Add($"{sname[i]} {name[i]}");
            }
            if (i2 % 2 == 0)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                i2++;
                i1 = i3 = i4 = i5 = 0;
            }
            else close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i3 % 2 == 0)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                i3++;
                i2 = i1 = i4 = i5 = 0;

            }
            else close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i4 % 2 == 0)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = true;
                panel5.Visible = false;
                i4++;
                i2 = i3 = i1 = i5 = 0;

            }
            else close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                if (textBox4.Text.Length > 7)
                {
                    sname.Add(textBox1.Text);
                    name.Add(textBox2.Text);
                    login.Add(textBox3.Text);
                    pass.Add(textBox4.Text);
                    email.Add(textBox5.Text);
                    MessageBox.Show("Данные успешно добавлены");
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
                }
                else MessageBox.Show("Пароль не меньше 8 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Сначала заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != null)
            {
                var bot = new TelegramBotClient(api);
                await bot.SendTextMessageAsync(chatId, $"{sname[comboBox1.SelectedIndex]} {name[comboBox1.SelectedIndex]} вам необходимо {textBox6.Text} до {dateTimePicker1.Text}");
            }
            else MessageBox.Show("Сначала заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (i5 % 2 == 0)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;
                i5++;
                i2 = i3 = i4 = i1 = 0;
            }
            else close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Aqua;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.White;
        }
    }
}
