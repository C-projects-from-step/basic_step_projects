using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DoubleList<T> : IEnumerable<T>
    {
        public class InnerNode<T>
        {
            public InnerNode<T> Previous { get; set; }
            public InnerNode<T> Next { get; set; }
            public T Data { get; set; }

            public InnerNode(T data)
            {
                Data = data;
            }
        }

        InnerNode<T> head;
        InnerNode<T> tail;

        public int Count { get; private set; }

        public void Add_Last(T data)
        {
            InnerNode<T> node = new InnerNode<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;                
            }
            tail = node;
            Count++;
        }

        public void Add_First(T data)
        {
            InnerNode<T> node = new InnerNode<T>(data);
            if (Count == 0)
            {
                head =tail= node;
            }
            else
            {
                head.Previous = node;
                node.Next = head;
                head = node;
            }
            Count++;
        }
        
        public void Add_Pos(T data, int pos)
        {
            if (pos >= Count || pos < 0)
                return;

            if (pos == Count-1)
                Add_Last(data);
            else if (pos == 0)
                Add_First(data);
            else
            {
                var node = new InnerNode<T>(data);
                InnerNode<T> tmp=head, cur = head; ;
                int m = 0;
                if (Count / 2 > pos)
                {
                    while (cur != null)
                    {
                        if (m++ == pos)
                            break;
                        cur = cur.Next;
                    }
                }
                else
                {
                    cur = tail;
                    while (cur != head)
                    {
                        if (m++ == Count-pos-1)
                            break;
                         cur = cur.Previous;
                    }
                    
                }
                tmp = cur.Previous;
                node.Next = cur;
                node.Previous = tmp;
                tmp.Next = node;
                cur.Previous = node;
                Count++;
            }
        }

        public void Add_Range(int pos,params T[] args )
        {
            for (int i = 0; i < args.Length; i++)
            {
                Add_Pos( (dynamic)args[i],pos);
                pos++;
            }
        }

        public void Del_First()
        { if (Count != 0)
            {
                head = head.Next;
                head.Previous = null;
                Count--;
            }
        }

        public void Del_Last()
        {
            if (Count != 0)
            {
               tail = tail.Previous;
                tail.Next = null;
                Count--;
            }
        }

        public void Del_Range(int pos, int num)
        {
            if (pos >= Count || pos < 0)
                return;

            if (pos + num >= Count)
                return;

            for (int i = 0; i < num; i++)
            {
                Del_Pos(pos);
            }
        }

        public void Del_Pos(int pos)
        {
            if (pos >= Count || pos < 0)
                return;

            if (pos == Count-1)
                Del_Last();
            else if (pos == 0)
                Del_First();
            else
            {
                InnerNode<T> cur = head;
                InnerNode<T> tmp = head;
                if (Count / 2 > pos)
                {
                    for (int i = 0; i < pos; i++)
                    {
                        tmp = cur;
                        cur = cur.Next;
                    }
                }
                else
                {
                    cur = tail;
                    for (int i = Count-1; i > pos; i--)
                    {                       
                        cur = cur.Previous;
                    }
                    tmp = cur.Previous;
                }
                cur = cur.Next;
                cur.Previous = tmp;
                tmp.Next = cur;
                Count--;
            }
            }

        public bool Del_Data(T data)
        {
            InnerNode<T> cur = head;
            bool f = false;
            int m = 0;
            while (cur!=tail)
            {
                if (cur.Data.Equals(data))
                {
                    f = true;
                    break; }
                cur = cur.Next;
                 m++;
            }

            if (f)
            { Del_Pos(m);
                return true;
            }
            else return false;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            InnerNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            InnerNode<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}
