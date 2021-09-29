using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject2
{
    class GoodBoy:Guy
    {
        public override string WhoAttack()
        {
            return "Good Boy이가 공격했습니다.";
        }

        public void AddLife(int add)
        {
            Life += add;
        }
    }
}
