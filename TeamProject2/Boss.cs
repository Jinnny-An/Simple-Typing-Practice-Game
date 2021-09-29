using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject2
{
    class Boss:BadBoy
    {
        public override string WhoAttack()
        {
            return "Boss가 공격했습니다.";
        }
        public int Aggression()
        {
            return 3;
        }
    }
}
