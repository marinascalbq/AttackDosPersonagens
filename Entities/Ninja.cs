using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroeType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroeType = HeroeType;

        }
        public override string Attack()
        {
        return this.Name + " atingiu com sua lança!";   
        }
        
    }
}