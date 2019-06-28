using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace arheo
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form2();
            ifrm.Show(); 
            ifrm.Location = new Point(Location.X + 20, Location.Y + 40);
            Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить строчку с идентификатором равным " +
                    dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString() + "?",
                    "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    queriesTableAdapter1.DeleteLine(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
                    checkBox_CheckedChanged(sender, e);
                }
            }
            else
                MessageBox.Show("Не выделено ни одной строчки. :(",
                    "Удаление", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(Size.Width - 45, Size.Height - 230);
            dataGridView1.Columns[0].Width = 26;
            for (int i=1; i < dataGridView1.ColumnCount; i++)
                dataGridView1.Columns[i].Width = dataGridView1.Size.Width / (dataGridView1.ColumnCount - 1) - 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Height = 400;
            button1_Click(sender, e);
            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[1].HeaderText = "Ссылка";
            dataGridView1.Columns[2].HeaderText = "Тэги";
            dataGridView1.Columns[3].HeaderText = "Описание";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = true;
            checkBox12.Checked = true;
            checkBox13.Checked = true;
            checkBox14.Checked = true;
            checkBox15.Checked = true;
            checkBox16.Checked = true;
            checkBox17.Checked = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            outputTableAdapter.Fill(baseDataSet.Output,
                Convert.ToInt32(checkBox1.Tag) * Convert.ToInt32(checkBox1.Checked),
                Convert.ToInt32(checkBox2.Tag) * Convert.ToInt32(checkBox2.Checked),
                Convert.ToInt32(checkBox3.Tag) * Convert.ToInt32(checkBox3.Checked),
                Convert.ToInt32(checkBox4.Tag) * Convert.ToInt32(checkBox4.Checked),
                Convert.ToInt32(checkBox5.Tag) * Convert.ToInt32(checkBox5.Checked),
                Convert.ToInt32(checkBox6.Tag) * Convert.ToInt32(checkBox6.Checked),
                Convert.ToInt32(checkBox7.Tag) * Convert.ToInt32(checkBox7.Checked),
                Convert.ToInt32(checkBox8.Tag) * Convert.ToInt32(checkBox8.Checked),
                Convert.ToInt32(checkBox9.Tag) * Convert.ToInt32(checkBox9.Checked),
                Convert.ToInt32(checkBox10.Tag) * Convert.ToInt32(checkBox10.Checked),
                Convert.ToInt32(checkBox11.Tag) * Convert.ToInt32(checkBox11.Checked),
                Convert.ToInt32(checkBox12.Tag) * Convert.ToInt32(checkBox12.Checked),
                Convert.ToInt32(checkBox13.Tag) * Convert.ToInt32(checkBox13.Checked),
                Convert.ToInt32(checkBox14.Tag) * Convert.ToInt32(checkBox14.Checked),
                Convert.ToInt32(checkBox15.Tag) * Convert.ToInt32(checkBox15.Checked),
                Convert.ToInt32(checkBox16.Tag) * Convert.ToInt32(checkBox16.Checked),
                Convert.ToInt32(checkBox17.Tag) * Convert.ToInt32(checkBox17.Checked)
                );
            int k = dataGridView1.RowCount,
                t = dataGridView1.ColumnCount;
            for (int i = 0; i < k; i++)
            {
                dataGridView1.Rows[i].Cells[1].Style.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Underline);
                dataGridView1.Rows[i].Cells[1].Style.ForeColor = SystemColors.HotTrack;
                for(int j = 0; j < t; j++)
                {
                    dataGridView1.Rows[i].Cells[j].ToolTipText = (dataGridView1.Rows[i].Cells[j].Value.ToString()).Wrap(70);
                }
            }
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            checkBox_CheckedChanged(sender, e);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(dataGridView1.CurrentCell.Value.ToString());
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            int k = dataGridView1.RowCount,
               t = dataGridView1.ColumnCount;
            for (int i = 0; i < k; i++)
            {
                dataGridView1.Rows[i].Cells[1].Style.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Underline);
                dataGridView1.Rows[i].Cells[1].Style.ForeColor = SystemColors.HotTrack;
                for (int j = 0; j < t; j++)
                {
                    dataGridView1.Rows[i].Cells[j].ToolTipText = (dataGridView1.Rows[i].Cells[j].Value.ToString()).Wrap(70);
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dataGridView1.CurrentCell.Value.ToString());
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.ClearSelection();
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                if (e.ColumnIndex == 1)
                {
                    dataGridView1.ContextMenuStrip = contextMenuStrip1;
                    contextMenuStrip1.Show(Control.MousePosition);
                    dataGridView1.ContextMenuStrip = null;
                }
            }
        }
    }
}
