using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_lesson_app
{
    class Apple : Tree 
    {
        public Apple(string lame, double fame): base(lame, fame)
        {

        }
        public override void Grow()
        {
            Age += 1;
        }
    }
}
