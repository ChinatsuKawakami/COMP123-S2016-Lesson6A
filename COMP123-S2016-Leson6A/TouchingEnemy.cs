using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public class TouchingEnemy : Enemy, Itouchable
    {
        protected string name { get; set; }
        public TouchingEnemy(string name):base(name)
        {
           // this.Name = name;
        }
    
        public void Shoot()
        {
            Console.WriteLine("{0} Shoot!",this.Name);
        }

        public void Fight()
        {
            Console.WriteLine("{0} Fight!", this.Name);
        }
    }
}
