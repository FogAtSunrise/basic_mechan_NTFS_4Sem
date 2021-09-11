using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace лаб9
{
    public partial class change : Form
    {
        public change()
        {
            InitializeComponent();
        }

        private void change_Load(object sender, EventArgs e)
        {
            record node = Form1.mftlist.findMFTnum(Form1.rec);
            textBoxName.Text = node.name;
            if (node.onlyread == 1)
                checkBox1.Checked = true;
            else checkBox1.Checked = false;
            if (node.datarez == 1)
            {
                textBoxPrior1.Text = node.data;
                textBoxPrior1.MaxLength = 2;
            }
            else {
                int h = node.help.Count;
                string str = "";
                    for (int i = 0; i < h; i++)
                    str += Form1.Tom.Rows[Convert.ToInt32(node.help[i])].Cells[1].Value.ToString();
                textBoxPrior1.Text = str;
                textBoxPrior1.MaxLength = str.Length;
            }
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            record node = Form1.mftlist.findMFTnum(Form1.rec);
            //пустое поле
            if (textBoxName.Text == String.Empty)
                label3.Visible = true;
            else

             if (textBoxName.Text!= node.name && Form1.mftlist.findName(textBoxName.Text) != null)//если имя уже существует
                label6.Visible = true;
            else
            {

                if (textBoxPrior1.Text == String.Empty || textBoxPrior1.Text.Length < 3) //если данных файла нет или они помещаются в запись
                {
                    node.datarez = 1;
                    node.data = textBoxPrior1.Text;
                    node.dopmft = 0;
                }
                else
                {
                    node.datarez = 0;
                    string str = textBoxPrior1.Text;
                    ArrayList res = new ArrayList();
                    int k = 0;
                    while (str.Length > 0)
                    {
                        if (str.Length > 4)
                        {
                            res.Add(str.Substring(0, 5));
                            str = str.Remove(0, 5);
                        }
                        else
                        {
                            res.Add(str);
                            str = "";
                        }
                    }
                    //   str.Length;

                    int countser = res.Count;

                    for (int i = 0; i < countser; i++)
                Form1.Tom.Rows[Convert.ToInt32(node.help[i])].Cells[1].Value = res[i];
                //    Form1.Tom.Rows[i].Cells[1].Value = res[i];
                    if (countser < node.help.Count)
                    {
                        for (int i = countser; i < node.help.Count; i++)
                            Form1.Tom.Rows[Convert.ToInt32(node.help[i])].Cells[2].Value = 0;
                        node.help.RemoveRange(countser, node.help.Count - countser);
                        Form1.countblock = Form1.countblock - node.help.Count - countser;
                    }
                    
                    }

                }

                node.name = textBoxName.Text;//имя файла
                node.DateChange = DateTime.Now;
            if (checkBox1.Checked == true)
                    node.onlyread = 1;
                else node.onlyread = 0;

            Form1.liveHelp();
            this.Close();
            }
        }
    }

