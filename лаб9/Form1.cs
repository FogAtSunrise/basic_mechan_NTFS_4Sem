using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб9
{
    public partial class Form1 : Form
    {
        public Button[] mftrec = new Button[9];
        public static ListRecord mftlist = new ListRecord();
        public static int rec = 0;//выбранная запись
        public static int countblock=0;//количество заполненных блоков
        public static int countrecord = 1;//количество заполненных записей
        public static int SizeBlock = 5;//размер блока, ну т.е. количество символов
        public static int lastadd = 0; //последний добавленный
        public Form1()
        {
            InitializeComponent();
        }
        //видимость кнопок для файла
        private void active()
        {
            read.Enabled = true;
            delete.Enabled = true;
            change.Enabled = true;
            write.Enabled = true;
        }
        private void unactive()
        {
            read.Enabled = false;
            delete.Enabled = false;
            change.Enabled = false;
            write.Enabled = false;
            live.Enabled = false;
        }

        //раскраска записей
        private void recordclick()
        {
            for (int i = 0; i < 9; i++)
            {
                if (rec != i)
                    mftrec[i].BackColor = Color.Khaki;
                else mftrec[i].BackColor = Color.LightGreen;
            }
            recordshow();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            unactive();
            mftrec[0] = button1;
            mftrec[1] = button2;
            mftrec[2] = button3;
            mftrec[3] = button4;
            mftrec[4] = button5;
            mftrec[5] = button6;
            mftrec[6] = button7;
            mftrec[7] = button8;
            mftrec[8] = button9;
            //add.Enabled = false;
            for (int i = 0; i < 9; i++)
            {
                mftrec[i].BackColor = Color.Khaki;
                if (i != 0)
                    mftrec[i].Text = "empty";
            }

            for (int i = 0; i < 16; i++)
            {
                //зарание заполняю таблицы строками
                Tom.Rows.Add();
                Tom.Rows[i].Cells[0].Value = i;
                Tom.Rows[i].Cells[2].Value = 0;
                //    Task.Delay(1000).GetAwaiter().GetResult();
            }
            Tom.ClearSelection();
            //заполняю таблицу записи
            for (int i = 0; i < 8; i++)
            {
                //зарание заполняю таблицы строками
                record.Rows.Add();
            }
            record.ClearSelection();
            record.Rows[0].Cells[0].Value = "флаг использования";
            record.Rows[1].Cells[0].Value = "номер записи";
            record.Rows[2].Cells[0].Value = "имя файла";
            record.Rows[3].Cells[0].Value = "дата создания";
            record.Rows[4].Cells[0].Value = "дата изменения";
            record.Rows[5].Cells[0].Value = "только чтение";

        }

        private void blockAll()
        {

        }
        //выбор записи
        private void button1_Click(object sender, EventArgs e)
        {
            rec = 0;
            recordclick();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            rec = 1;
            recordclick();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            rec = 2;
            recordclick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rec = 3;
            recordclick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rec = 4;
            recordclick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rec = 5;
            recordclick();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rec = 6;
            recordclick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rec = 7;
            recordclick();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            rec = 8;
            recordclick();
        }

        private add z = new add(); //для окна добавления
        private write y = new write(); //для окна добавления
        //добавление нового файла
        private void add_Click(object sender, EventArgs e)
        {
            if (9 != countrecord)
            {
                if (countblock != 16)
                {
                    lastadd = 0;
                    if (z.IsDisposed)
                        z = new add();
                    z.Show();
                }
                else
                    MessageBox.Show("Том заполнен =(", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
                MessageBox.Show("Максимальное количество записей достигнуто =(", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        public static int findEmptyBlock()
        {
            int find = -1;
            for (int i = 0; i <  16; i++)
            {
                if (Tom.Rows[i].Cells[2].Value.ToString() == "0")
                { find = i;
                    return find;}
                }
            return find;
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                {
                    record.Rows[i].Cells[1].Value = "";
                    if (i > 5)
                        record.Rows[i].Cells[0].Value = "";
                }
            if (lastadd!=0)
            {//очистка таблицы
            rec = lastadd;
           
                for (int i = 0; i < 9; i++)
                {
                    if (rec != i)
                        mftrec[i].BackColor = Color.Khaki;
                    else mftrec[i].BackColor = Color.LightGreen;
                }
                recordshow();
                record node = mftlist.findMFTnum(rec);
                mftrec[node.numberMFT].Text = node.name;
                if(node.dopmft==1)
                    mftrec[node.Rec].Text = node.name+" (dop)";
                node.DateChange = DateTime.Now;
            }
          
        }
        //вывод записи файла
        public void recordshow()
        {
            for (int i = 0; i < 8; i++)
            {
                record.Rows[i].Cells[1].Value = "";
                if (i > 5)
                    record.Rows[i].Cells[0].Value = "";
            }
            record node = mftlist.findMFTnum(rec);
            unactive();
           
            if (node.name != "")
            {
                
                if (node.useRecord == 0) live.Enabled = true;
                else
                if (node.onlyread == 1)
                {
                    read.Enabled = true;
                    delete.Enabled = true;
                }
                else
              active();

                record.Rows[0].Cells[1].Value = node.useRecord;
               if (node.bigindex==1)
                record.Rows[2].Cells[1].Value = node.name+" (осн.)";
               else
                    record.Rows[2].Cells[1].Value = node.name + " (доп.)";
                record.Rows[3].Cells[1].Value = node.DateCreate;
                record.Rows[4].Cells[1].Value = node.DateChange;
                record.Rows[5].Cells[1].Value = node.onlyread;

                if (rec == 0)
                {
                    record.Rows[1].Cells[1].Value = 0;
                    record.Rows[6].Cells[0].Value = "данные";
                    record.Rows[6].Cells[1].Value = "где-то в начале";
                    unactive();
                }
                else
                {
                    record.Rows[1].Cells[1].Value = node.numberMFT + 15;
                    int countser = node.Ser.Count;
                    int inl;
                    if (node.dopmft == 1)
                    {
                        record.Rows[6].Cells[0].Value = "dop MFT";
                        record.Rows[6].Cells[1].Value = node.Rec+15;
                        countser = 6;
                        inl = 7;
                    }
                    else inl = 6;
                    string ser = "";
                    for (int i = 0; i < countser; i+=2)
                    {
                        if (i!=0 && i % 3 == 0)
                        {
                            record.Rows[inl].Cells[0].Value = "данные";
                            record.Rows[inl++].Cells[1].Value = ser;
                            ser = "";
                        }
                        ser += node.Ser[i];
                        ser += " ";
                        ser += node.Ser[i + 1];
                        ser += ";";
                    }
                    if (inl < 8)
                    {
                        record.Rows[inl].Cells[0].Value = "данные";
                        record.Rows[inl].Cells[1].Value = ser;
                    }
                    if (node.datarez == 1)
                    {
                        for (int i = 0; i < node.data.Length; i++)
                        {     record.Rows[6 + i].Cells[0].Value = "данные";
                        record.Rows[6 + i].Cells[1].Value = node.data[i];
                    }
                    }
                }
            }
          
                    
        }

        private void delete_Click(object sender, EventArgs e)
        {
            record node = mftlist.findMFTnum(rec);
            //если это доп запись, переходим с основную
            if (node.bigindex == 0)
            {
                rec = node.Rec;
                node = mftlist.findMFTnum(rec);
            }
            record.Rows[0].Cells[1].Value = 0;
            //обнуляем флаг использования
            node.useRecord = 0;
            countrecord--;
            if (node.dopmft == 1)//если есть дополнительные записи, обнуляем для них флаги использования
            {
                rec = node.Rec;
                node = mftlist.findMFTnum(rec);
                node.useRecord = 0;
                countrecord--;
                rec = node.Rec;
                node = mftlist.findMFTnum(rec);
            }

            int count = node.help.Count;
            for (int i = 0; i < count; i++)
            {
                Tom.Rows[Convert.ToInt32(node.help[i])].Cells[2].Value = 0;
                countblock--;
            }
            unactive();
            live.Enabled = true;

        }

        private void live_Click(object sender, EventArgs e)
        {
            record node = mftlist.findMFTnum(rec);
            string name1 = node.name;
            //если это доп запись, переходим с основную
            if (node.bigindex == 0)
            {
                rec = node.Rec;
               node = mftlist.findMFTnum(rec);
                if (node.name != name1)
                {
                    MessageBox.Show("Восстанволение не возможно, так как основная запись файла была удалена =(", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            record.Rows[0].Cells[1].Value = 1;
            //обнуляем флаг использования
            node.useRecord = 1;
            countrecord++;
            if (node.dopmft == 1)//если есть дополнительные записи, обнуляем для них флаги использования
            {
                rec = node.Rec;
                node = mftlist.findMFTnum(rec);
                if (node.name != name1)
                {
                    MessageBox.Show("Восстанволение допрлнительной страницы не возможно, так как запись файла была удалена =(", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                node.useRecord = 1;
                countrecord++;
                rec = node.Rec;
                node = mftlist.findMFTnum(rec);
            }

            int count = node.help.Count;
            for (int i = 0; i < count; i++)
            {
                if (Convert.ToInt32(Tom.Rows[Convert.ToInt32(node.help[i])].Cells[3].Value) == node.numberMFT + 15)
                {
                    Tom.Rows[Convert.ToInt32(node.help[i])].Cells[2].Value = 1;
                    countblock++;
                }
                else { node.help.RemoveAt(i--); count--; }
            }
            active();
            live.Enabled = false;
            liveHelp();
            recordshow();
        }
        public static void liveHelp()
        {
            record node = mftlist.findMFTnum(rec);
            record node1 = Form1.mftlist.findEmptyElement();
            if (node.dopmft == 1)//если есть дополнительные записи, обнуляем для них флаги использования
            {
                int urec = node.Rec;
                node1 = mftlist.findMFTnum(urec);
    
            }
            node.Ser.Clear();
            node1.Ser.Clear();

            if (node.help.Count==0||node.datarez == 1) //если данных файла нет или они помещаются в запись
            {
                node.datarez = 1;
             //   node.data = "";
                node.dopmft = 0;
                node.bigindex = 1;
            }
            else
            if (node.help.Count == 1 && Tom.Rows[Convert.ToInt32(node.help[0])].Cells[1].Value.ToString().Length<3) //если данных файла нет или они помещаются в запись
            {
                node.datarez = 1;
                node.data = Tom.Rows[Convert.ToInt32(node.help[0])].Cells[1].Value.ToString();
                Tom.Rows[Convert.ToInt32(node.help[0])].Cells[1].Value = 0;
                node.help.Clear();
                node.dopmft = 0;
                node.bigindex = 1;
            }
            else
            {
                node.bigindex = 1;
                node.datarez = 0;
               
                int countser = node.help.Count;
                int index = Convert.ToInt32(node.help[0]);
                node.Ser.Add(index);
                index -= 1;
                int sum = 0;
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
                        if (node.dopmft == 0)
                        {

                            node1.useRecord = 1; //используется ли запись
                            countrecord++;
                            node1.name = node.name;//имя файла
                            node1.DateCreate = DateTime.Now;//дата создания 
                            node1.DateChange = node.DateCreate;
                            node1.onlyread = node.onlyread;
                            node.dopmft = 1;
                            node1.bigindex = 0;
                        }
                        

                    for (int i = 6; i < node.Ser.Count; i++)
                    {
                        node1.Ser.Add(node.Ser[i]);
                        //   node.Ser.RemoveAt(6);
                    }

                    node.Rec = node1.numberMFT;
                    node1.Rec = node.numberMFT;
                }
                }
               
            }


        }
        private void read_Click(object sender, EventArgs e)
        {
record node = mftlist.findMFTnum(rec);
            int h = node.help.Count;
            string str = "";
            if (node.datarez == 1)
                str = node.data;
            else for (int i = 0; i < h; i++)
                    str += Tom.Rows[Convert.ToInt32(node.help[i])].Cells[1].Value.ToString();

   MessageBox.Show(str);

        }
        private void write_Click(object sender, EventArgs e)
        {
            record node = mftlist.findMFTnum(rec);
            if (node.bigindex == 0)
            {
                rec = node.Rec;
                node = mftlist.findMFTnum(rec);
                
            }
            lastadd = rec;
            if (9 != countrecord || node.Ser.Count != 12)
            {
                if (countblock != 16)
                {
                    if (y.IsDisposed)
                        y = new write();
                    y.Show();
                }
                else
                    MessageBox.Show("Том заполнен =(", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Максимальное количество записей достигнуто, а здесь явно понадобится запись =(", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private change df = new change(); //для окна добавления
        private void change_Click(object sender, EventArgs e)
        {
            record node = mftlist.findMFTnum(rec);
          if (node.bigindex == 0)
                rec = node.Rec;
            lastadd = rec;

            if (df.IsDisposed)
                        df = new change();
                    df.Show();
 
        }
    }
}
