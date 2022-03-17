using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroeType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroeType = HeroeType;

        }
        public override string Attack()
        {
        return this.Name + " lançou a sua magia";   
        }
        
        public string Attack( int Bonus){

            if (Bonus>6)
            {
             return this.Name + " lançou uma magia super efetiva com um bônus de ataque " + Bonus; 
              } else 
        {
            return this.Name + " lançou uma magia fraca com bônus de " + Bonus;
        }
    }
}
} 