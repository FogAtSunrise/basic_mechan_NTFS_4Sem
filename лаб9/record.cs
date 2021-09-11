using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace лаб9
{
    public class record
    {
        
        public int useRecord = 0; //используется ли запись
        public int numberMFT;//адрес в МФТ
        public string name = "";//имя файла
        public int datarez;//резидентность данных
        public string data;//резидентные данные
        public int dopmft=0;//есть ли доп запись
        public int bigindex = 1;//индекс, который показывает, основная запись или добавочная
        public DateTime DateCreate;//дата создания 
        public DateTime DateChange;//дата последнего изменения

        //DateTime curDate = DateTime.Now;
        public int onlyread = 0;
        public record next;
        public record prev;
        public ArrayList Ser = new ArrayList(); //серии хранятся
        public int Rec ;//мфт
        public ArrayList help=new ArrayList();//для моральной поддержки
   
        public record(int num)
        {
         numberMFT = num;
         useRecord = 0;
         name = "";
         onlyread = 0;
                }

        public void initrecord(int a)
        {
            useRecord = 1;
            name = "";
            onlyread = 0;
        }
    }
}
