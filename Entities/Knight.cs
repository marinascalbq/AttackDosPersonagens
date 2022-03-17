using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Entities
{
    public class Knight : Hero
    {
           public Knight (string Name, int Level, string HeroeType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroeType = HeroeType;

        }

        
        public override string Attack()
        {
        return this.Name + " deu a sua espadada!";   
        }
    }

}