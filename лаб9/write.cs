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
    public partial class write : Form
    {
        public write()
        {
            InitializeComponent();
        }

        private void write_Load(object sender, EventArgs e)
        {
            if (16 == Form1.countblock)
            {
                textBoxPrior.MaxLength = 2;
            }
            else
                textBoxPrior.MaxLength = (16 - Form1.countblock) * 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            record node = Form1.mftlist.findMFTnum(Form1.rec);
            string str = textBoxPrior.Text;
            if(node.datarez == 1)
                str= node.data+str;

            if (str == String.Empty || str.Length < 3) //если данных файла нет или они помещаются в запись
            {
                node.datarez = 1;
                node.data = str;
                node.dopmft = 0;
                node.bigindex = 1;
            }
            else
            {
                node.datarez = 0;
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
                Form1.liveHelp();
            }
            node.DateChange = DateTime.Now;
            this.Close();
        }
    }
}
