using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace лаб9
{
    public class ListRecord
    {

        public record first;
        public record current;
        public record last;
        public int size;
    
        public ListRecord()
        {
           
             size = 0;
            first = current = last = null;
            for (int i = 0; i < 9; i++)
            {
                Push_Back(i);
            }
            first.name = "MFT";
            first.useRecord = 1; //используется ли запись
            first.numberMFT=0; //адрес в МФТ
            first.dopmft=1; //есть ли доп запись
            first.bigindex = 1;//индекс, который показывает, основная запись или добавочная
            first.DateCreate=DateTime.Now;//дата создания 
            first.DateChange=first.DateCreate;//дата последнего изменения
            first.bigindex = 1;//индекс, который показывает, основная запись или добавочная
            first.onlyread = 1;
            first.datarez = 0;
            // first.prev = last.next = null;
        }

        public bool IsEmpty //проверка на пустоту
        {
            get
            {
                return size == 0;
            }
        }


        public void Push_Back(int num)//добавление в конец
        {
            record newNode = new record(num);

            if (first == null)
            {
                first = last = newNode;
            }
            else
            {
                last.next = newNode;
                newNode.prev = last;
                last = newNode;
                last.next = null;
            }
            size++;
        }
   
        public record findName(string Name)
        {
            if (first != null)
            {
                current = first;
                while (current != null && current.name != Name)
                    current = current.next;
                return current;
            }
            else return null;
        }

        public record findMFTnum(int num)
        {
            if (first != null)
            {
                current = first;
                while (current != null && current.numberMFT != num)
                    current = current.next;
                return current;
            }
            else return null;
        }
        public record findEmptyElement()
        {
            if (first != null)
            {
                current = first;
                while (current != null && current.useRecord != 0)
                    current = current.next;
                return current;
            }
            else return null;
        }

    }
}
