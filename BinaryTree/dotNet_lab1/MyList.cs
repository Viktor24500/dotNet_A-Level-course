using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_lab1
{
    public class MyList<T> : IEnumerable<T>
    {
        public T[] myList;
        public int counter;
        public MyList()
        {
            myList = new T[5];
            counter = 0;
        }
        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item can't be null");
            }
            if (counter == myList.Length)
            {
                Array.Resize(ref myList, myList.Length * 2);
            }
            myList[counter] = item;
            counter++;
        }

        public void AddItems(IEnumerable<T> collect)
        {
            if (collect == null)
            {
                throw new ArgumentNullException("item can't be null");
            }
            foreach (var item in collect)
            {
                Add(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class MyListEnumerator : IEnumerator<T>
        {
            private MyList<T> _list;
            private int _index;

            public MyListEnumerator(MyList<T> _list)
            {
                this._list = _list;
                _index = -1;
            }

            public T Current => _list.myList[_index];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                _index++;
                return _index < _list.counter;
            }

            public void Reset()
            {
                _index = -1;
            }

            public void Dispose()
            {
            }
        }
    }
}
