using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class Koreanfood : IKoreanfood
    {
        public virtual int Eat(int a)
        {
            return 0;
        }

        public virtual int Noteat(int a)
        {
            return 0;
        }
    }
}
