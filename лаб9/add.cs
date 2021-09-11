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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            //пустое поле
         if (textBoxName.Text == String.Empty )
                label3.Visible = true;
            else

          if (Form1.mftlist.findName(textBoxName.Text) != null)//если имя уже существует
                label6.Visible = true;
            else
            {
                                             
                record node = Form1.mftlist.findEmptyElement(); //пустая запись
                node.useRecord = 1; //используется ли запись
                record node1 = Form1.mftlist.findEmptyElement(); //пустая запись
                node.help.Clear();
                node.Ser.Clear();
               
                if (textBoxPrior.Text == String.Empty || textBoxPrior.Text.Length < 3) //если данных файла нет или они помещаются в запись
                {
                    node.datarez = 1;
                    node.data = textBoxPrior.Text;
                    node.dopmft = 0;
                    node.bigindex = 1;
                }
                else
                {
                    node.bigindex = 1;
                    node.datarez = 0;
                    string str = textBoxPrior.Text;
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
                    {
                        k = Form1.findEmptyBlock();
                        if (k > -1)
                        {
                            Form1.countblock++;
                            node.help.Add(k);
                            Form1.Tom.Rows[k].Cells[2].Value = "1";
                            Form1.Tom.Rows[k].Cells[3].Value = node.numberMFT + 15;
                            Form1.Tom.Rows[k].Cells[1].Value = res[i];
                        }
                        else
                        {
                            MessageBox.Show("ых, места мало, но сохраню, сколько смогу", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                    int index = Convert.ToInt32(node.help[0]);
                    node.Ser.Add(index);
                    index -= 1;
                    int sum = 0;
                    countser = node.help.Count;
                    for (int i = 0; i < countser; i++)
                    {
                        if (index + 1 == Convert.ToInt32(node.help[i]))
                        {
                            sum++;
                            index++;
                            if (i + 1 == countser)
                                node.Ser.Add(sum);
                        }
                        else
                        {
                            node.Ser.Add(sum);
                            sum = 1;
                            index = Convert.ToInt32(node.help[i]);
                            node.Ser.Add(index);
                            if (i + 1 == countser)
                                node.Ser.Add(sum);
                        }
                    }

                    int countse = node.Ser.Count / 2;
                    if (countse <= 6)
                        node.dopmft = 0;
                    else
                    {
                        if (node1 == null)
                        {
                            node.Ser.RemoveRange(6, node.Ser.Count - 6);
                            MessageBox.Show("не удалось все сохранить");
                        }
                        else
                        {
                            node.dopmft = 1;

                            node1.help.Clear();
                            node1.Ser.Clear();
                            for (int i = 6; i < node.Ser.Count; i++)
                            {
                                node1.Ser.Add(node.Ser[i]);
                                //   node.Ser.RemoveAt(6);
                            }

                            node1.useRecord = 1; //используется ли запись
                            node1.bigindex = 0;
                            node.Rec = node1.numberMFT;
                            node1.Rec = node.numberMFT;
                        }
                    }

                }



               Form1.lastadd = node.numberMFT;


              node.name = textBoxName.Text;//имя файла
               node.DateCreate = DateTime.Now;//дата создания 
                node.DateChange = node.DateCreate;
                if(checkBox1.Checked==true)
                    node.onlyread = 1;
                else node.onlyread = 0;
                Form1.countrecord++;
                if (node.dopmft == 1)
                {
                    Form1.countrecord++;
                    node1.name = textBoxName.Text;//имя файла
                    node1.DateCreate = DateTime.Now;//дата создания 
                    node1.DateChange = node.DateCreate;
                    if (checkBox1.Checked == true)
                        node1.onlyread = 1;
                    else node1.onlyread = 0;

                }


                this.Close();
            }
        }

      private void add_Load(object sender, EventArgs e)
        {
            if (16 == Form1.countblock)
            {
                textBoxPrior.MaxLength = 2;
            }
            else
                 textBoxPrior.MaxLength = (16 - Form1.countblock) * 5;
        }
    }
}
