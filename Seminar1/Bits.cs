using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1
{
    internal class Bits : IBits
    {
        public Bits(byte b) 
        {
            Value = b;
            SizeOfValue = sizeof(byte) * 8;
        }

        public Bits(long b)
        {
            Value = b;
            SizeOfValue = sizeof(long) * 8;

        }

        public Bits(short b)
        {
            Value = b;
            SizeOfValue = sizeof(short) * 8;

        }

        public Bits(int b)
        {
            Value = b;
            SizeOfValue = sizeof(int) * 8;

        }


        public long Value { get; private set; } = 0;
        public int SizeOfValue { get; set; }

        //public bool this[int index]
        //{
        //    get
        //    {
        //        if (index > 7 || index < 0)
        //            return false;
        //        return ((Value >> index) & 1) == 1;
        //    }
        //    set
        //    {
        //        if (index > 7 || index < 0)
        //            if (value == true)
        //                Value = (byte)(Value | (1 << index));
        //            else
        //            {
        //                var mask = (byte)(1 << index);
        //                mask = (byte)(0xff ^ mask);
        //                Value &= (byte)(Value & mask);
        //            }
        //    }
        //}

        //public static implicit operator long(Bits b) => b.Value;
        //public static implicit operator long(long l) => new Bits(l);

        public static implicit operator Bits(byte b) => new Bits(b);
        public static implicit operator Bits(long b) => new Bits(b);
        public static implicit operator Bits(int b) => new Bits(b);


        public bool GetBit(int i)
        {
            if (i > SizeOfValue || i < 0)
                return false;
            return ((Value >> i) & 1) == 1;
        }

        public void SetBit(int i, bool val)
        {
            if (i > SizeOfValue || i < 0)
                if (val)
                    Value = (byte)(Value | (1 << i));
                else
                {
                    var mask = (byte)(1 << i);
                    mask = (byte)(0xff ^ mask);
                    Value &= (byte)(Value & mask);
                }
        }
    }
}
