using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Entities
{
    public abstract class Hero
    {
        public Hero (string Name, int Level, string HeroeType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroeType = HeroeType;

        }

        public Hero()
        {
            
        }


        public string Name ;
        public int Level;
        public string HeroeType;


        public override string ToString(){
            return this.Name + ", " + this.Level +", " + this.HeroeType;
            
        }

        public virtual string Attack(){

            return this.Name + " atacou com sua espada";
        }
    }
}