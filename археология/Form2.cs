using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arheo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queriesTableAdapter.AddLink(richTextBox1.Text) > 0)
                errorProvider1.SetError(label1, "Данная ссылка уже существует в базе");
            else if (richTextBox1.Text == "")
                errorProvider1.SetError(label1, "Отсутствуют данные");
            else if (!checkBox11.Checked && !checkBox12.Checked && !checkBox13.Checked && !checkBox14.Checked && !checkBox15.Checked
                && !checkBox16.Checked && !checkBox17.Checked)
                    errorProvider1.SetError(groupBox2, "Не выбран период");
            else if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked &&
                !checkBox6.Checked && !checkBox7.Checked && !checkBox8.Checked && !checkBox9.Checked && !checkBox10.Checked
                && !checkBox16.Checked && !checkBox17.Checked)
                    errorProvider1.SetError(groupBox1, "Не выбрана территория");
            else
            {
                errorProvider1.Clear();
                int Id = 1;
                while (queriesTableAdapter.AddId(Id) > 0) Id++;
                string tags = "";

                if (checkBox11.Checked) tags += checkBox11.Text + "; ";
                if (checkBox12.Checked) tags += checkBox12.Text + "; ";
                if (checkBox13.Checked) tags += checkBox13.Text + "; ";
                if (checkBox14.Checked) tags += checkBox14.Text + "; ";
                if (checkBox15.Checked) tags += checkBox15.Text + "; ";

                if (checkBox1.Checked) tags += checkBox1.Text + "; ";
                if (checkBox2.Checked) tags += checkBox2.Text + "; ";
                if (checkBox3.Checked) tags += checkBox3.Text + "; ";
                if (checkBox4.Checked) tags += checkBox4.Text + "; ";
                if (checkBox5.Checked) tags += checkBox5.Text + "; ";
                if (checkBox6.Checked) tags += checkBox6.Text + "; ";
                if (checkBox7.Checked) tags += checkBox7.Text + "; ";
                if (checkBox8.Checked) tags += checkBox8.Text + "; ";
                if (checkBox9.Checked) tags += checkBox9.Text + "; ";
                if (checkBox10.Checked) tags += checkBox10.Text + "; ";

                if (checkBox16.Checked) tags += checkBox16.Text + "; ";
                if (checkBox17.Checked) tags += checkBox17.Text + "; ";

                queriesTableAdapter.InputCat(Id, richTextBox1.Text, tags, richTextBox2.Text);

                if (checkBox1.Checked) queriesTableAdapter.InputArea(Id, Convert.ToInt32(checkBox1.Tag));
                if (checkBox2.Checked) queriesTableAdapter.InputArea(Id, Convert.ToInt32(checkBox2.Tag));
                if (checkBox3.Checked) queriesTableAdapter.InputArea(Id, Convert.ToInt32(checkBox3.Tag));
                if (checkBox4.Checked) queriesTableAdapter.InputArea(Id, Convert.ToInt32(checkBox4.Tag));
                if (checkBox5.Checked) queriesTableAdapter.InputArea(Id, Convert.ToInt32(checkBox5.Tag));
                if (checkBox6.Checked) queriesTableAdapter.InputArea(Id, Convert.ToInt32(checkBox6.Tag));
                if (checkBox7.Checked) queriesTableAdapter.InputArea(Id, Convert.ToInt32(checkBox7.Tag));
                if (checkBox8.Checked) queriesTableAdapter.InputArea(Id, Convert.ToInt32(checkBox8.Tag));
                if (checkBox9.Checked) queriesTableAdapter.InputArea(Id, Convert.ToInt32(checkBox9.Tag));
                if (checkBox10.Checked) queriesTableAdapter.InputArea(Id, Convert.ToInt32(checkBox10.Tag));

                if (checkBox11.Checked) queriesTableAdapter.InputPeriod(Id, Convert.ToInt32(checkBox11.Tag));
                if (checkBox12.Checked) queriesTableAdapter.InputPeriod(Id, Convert.ToInt32(checkBox12.Tag));
                if (checkBox13.Checked) queriesTableAdapter.InputPeriod(Id, Convert.ToInt32(checkBox13.Tag));
                if (checkBox14.Checked) queriesTableAdapter.InputPeriod(Id, Convert.ToInt32(checkBox14.Tag));
                if (checkBox15.Checked) queriesTableAdapter.InputPeriod(Id, Convert.ToInt32(checkBox15.Tag));

                if (checkBox16.Checked) queriesTableAdapter.InputOther(Id, Convert.ToInt32(checkBox16.Tag));
                if (checkBox17.Checked) queriesTableAdapter.InputOther(Id, Convert.ToInt32(checkBox17.Tag));

                MessageBox.Show("Строка успешно добавлена в базу данных",
                    "Добавление", MessageBoxButtons.OK, MessageBoxIcon.None);

                Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 7;
        }

        private void PastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
                contextMenuStrip1.Show(Control.MousePosition);
                richTextBox1.ContextMenuStrip = null;
            }
        }

        private void richTextBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip2;  
                contextMenuStrip2.Show(Control.MousePosition);
                richTextBox1.ContextMenuStrip = null;
            }
        }

        private void contextMenuStrip2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += Clipboard.GetText();
        }

 
    }
}
