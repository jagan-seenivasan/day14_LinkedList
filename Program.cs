using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            uc1_createALinkedList num = new uc1_createALinkedList();
            num.Add(56);
            num.Add(30);
            numb.Add(70);

            uc2_LinkedListByAdding num1 = new uc2_LinkedListByAdding();
            num1.AddFirst(56);
            num1.AddFirst(30);
            num1.AddFirst(70);

            uc3_LinkedListByAppending num2 = new uc3_LinkedListByAppending();
            num2.AddLast(56);
            num2.AddLast(30);
            num2.AddLast(70);

            uc4_insertionInLinkedList num3 = new uc4_insertionInLinkedList();
            day14_LinkedList<int> list = new day14_LinkedList<int>();
            list.AddFirst(1);
            list.AddAfter(0,20);

            num3.AddLast(56);
            num3.AddLast(30);
            num3.AddLast(70);
            num3.AddAfter(2, 40);
            int a = num3.Length();
            Console.WriteLine(a);

            uc5_deleteFirstElement num4 = new uc5_deleteFirstElement();
            num4.AddLast(56);
            num4.AddLast(30);
            num4.AddLast(70);
            num4.AddAfter(2, 40);
            int a = num4.Length();
            Console.WriteLine(a);
            num4.Pop();

            uc6_Delete_Last_elem num5 = new uc6_Delete_Last_elem();
            num5.AddLast(56);
            num5.AddLast(30);
            num5.AddLast(70);
            num5.AddAfter(2, 40);
            int a = num5.Length();
            Console.WriteLine(a);
            num5.Pop();
            num5.PopLast();

            uc7_SearchToFindNode num6 = new uc7_SearchToFindNode();
            num6.AddLast(56);
            num6.AddLast(30);
            num6.AddLast(70);
            num6.AddAfter(2, 40);
            num6.Find(30);

            uc8_Insert_Sequemce num7 = new uc8_Insert_Sequemce();
            num7.AddLast(56);
            num7.AddLast(30);
            num7.AddLast(70);
            num7.InsertAfter(30, 40);

            uc9_DeleteInSequence num8 = new uc9_DeleteInSequence();
            num8.AddLast(56);
            num8.AddLast(30);
            num8.AddLast(70);
            num8.InsertAfter(30, 40);
            num8.remove(70);
            
            uc10_OrderedListInSequemce num9 = new uc10_OrderedListInSequemce();
            num9.AddLast(56);
            num9.AddLast(30);
            num9.AddLast(70);
            num9.InsertAfter(30, 40);
            num9.order()

        }
    }
}
