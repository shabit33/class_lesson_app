using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_lesson_app
{
    abstract class Tree
    {
        public string Kind { get; private set; }
        private double age;
        public double Age
        {
            get
            {
                return Age;
            }
            protected set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                { age = value; }
            }
        }


        public Tree(string Lame, double Fame)
        {
            Kind = Lame;
            Age = Fame;
        }
        public virtual void Grow()
        {
            age += 2;
        }
    }
}
