using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public class ShootingEnemy : Enemy, IShootable, Itouchable
    {
        public ShootingEnemy(string name):base(name)
        {
            
        }
    
        public void Shoot()
        {
            throw new System.NotImplementedException();
        }

        public void Fight()
        {
            throw new System.NotImplementedException();
        }
    }
}
