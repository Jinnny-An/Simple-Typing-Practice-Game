using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject2
{
    abstract class Guy
    {
        private int life;

        public int Life
        {
            get { return life; }
            set { life = value; }
            
        }

        public int CountLife(int attack)
        {
            Life -= attack;

            return Life;
        }

        public abstract string WhoAttack();

    }
}
