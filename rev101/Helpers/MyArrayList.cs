using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using rev101.Models.entites;

namespace rev101.Helpers
{
    public delegate int HowToExpand(int length);
    
    public  class MyArrayList<T> :IEnumerator<T>,IEnumerable<T> ,IMyArrayList<T>where T :class,IHasId
    {

        private  T[] _data;
        public int Count { get; private set; }

        public  HowToExpand HowToExpand { set; private get; }

        private int _endFill=-1;//0 based index

        private int _pos=-1 ;//for Enumerating 

        private static readonly int DataLength =200;//length of array
        public MyArrayList(int initialLength, HowToExpand howToExpand=null)
        {
            _data=new T[initialLength];
            HowToExpand = howToExpand ?? DefaultHowToExpand;
        }

        public MyArrayList(HowToExpand howToExpand=null):this(DataLength,howToExpand)
        {
        }
        
        public MyArrayList(T[] initialData,HowToExpand howToExpand=null)
        {
            _data = new T[initialData.Length > DataLength ? initialData.Length : DataLength];
            
            foreach (var e in initialData)
            {
                _data[e.GetId()] = e;
            }

            HowToExpand = howToExpand ?? DefaultHowToExpand;
        }
        
        public T this [int id]
        {
            get
            {
                if (id<1||id>_data.Length)
                {
                    throw new Exception("id is invalid ");
                }

                return _data[id-1];
            }
            set => Insert(value);
        }

        public  void Insert(T element)
        {
            if (element.GetId() > _data.Length  && _data[element.GetId()] == null) return;
            
            if (element.GetId() > _data.Length)
            {
                Expand();
            }

            _data[element.GetId()-1] = element;
            Count++;
            ++_endFill;
        }
        private void Expand()
        {
            var newLength = HowToExpand(Count);
            var newData = new T [newLength];
            for (var i = 0; i < Count; i++)
            {
                newData[i] = _data[i];
            }
            _data = newData;
        }
        private static int DefaultHowToExpand(int length) => length < 300 ? length *3 : length<900? length*2:470;
        

        public void Delete(int id)
        {
            if (id<1||id>_data.Length)
            {
                throw new Exception("Invalid Id Parameter");
            }

            _data[id-1] = null;
            Count--;
            if (id-1 == _endFill )
                --_endFill;
        }


        public bool MoveNext()
        {
            _pos++;
            var state = _pos <= _endFill;
            if (!state)
            {
                Reset();
            }
            return state;
        }

        public void Reset()
        {
            _pos = -1;
        }

        public T Current
        {
            get
            {
                while (_data[_pos]==null)
                {
                    _pos++;
                }
                return _data[_pos];
            }
        }

        object IEnumerator.Current => Current;
        public void Dispose()
        {
           Reset();
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}