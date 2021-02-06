using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist.net
{
    class ArrayList
    {
        object[] Value;
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public object this[int i]
        {
            get
            {
                return Value[i];
            }
            set
            {
                if (i < Count)
                    Value[i] = value;
            }
        }

        public void Add(object val)
        {
            Value[Count] = val;
            Count++;
        }

        public void Clear()
        {
            Value = new object[1000];
            Count = 0;
            Capacity = 1000;
        }

        public ArrayList Clone()
        {
            ArrayList b = new ArrayList();
            for (int i = 0; i < Count; i++)
                b.Add(Value[i]);
            return b;
        }

        public void Insert(object val, int ind)
        {
            if (ind > Count - 1)
                return;
            for (int i = Count; i > ind; i--)
                Value[i] = Value[i - 1];
            Value[ind] = val;
            Count++;
        }

        public void Remove(int ind)
        {
            if (Count == 0)
                return;
            for (int i = ind; i < Count - 1; i++)
                Value[i] = Value[i + 1];
            Value[Count - 1] = null;
            Count--;
        }

        public bool Contains(object val)
        {
            for (int i = 0; i < Count; i++)
                if (Value[i].Equals(val))
                    return true;
            return false;
        }

        public int IndexOf(object val)
        {
            for (int i = 0; i < Count; i++)
                if (Value[i].Equals(val))
                    return i;
            return -1;
        }

        public object[] ToArray(int ind, int cou)
        {
            if (cou + ind > Count || cou == 0)
                throw new Exception("F");
            object[] b = new object[cou];
            for (int i = ind; i < ind + cou; i++)
                b[i - ind] = Value[i];
            return b;
        }

        public ArrayList()
        {
            Value = new object[1000];
            Capacity = 1000;
        }
    }
}
