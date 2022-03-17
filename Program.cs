using System;
using src.Entities;

namespace Mentoria;
        class Program
        {
            static void Main(string[] args)
            {
               Knight knight = new Knight ("Arus", 23 ,"Knight ");
               Wizard wizard = new Wizard ("Jennica", 23 ,"White Wizard ");
               BlackWizard BlackWizard = new BlackWizard ("Topapa", 42 ,"Black Wizard ");
               Ninja ninja = new Ninja ("Wedge", 42 , "Ninja" );

               
               Console.WriteLine(wizard.Attack(1));
               Console.WriteLine(BlackWizard.Attack(7));
               Console.WriteLine(knight.Attack());
               Console.WriteLine(ninja.Attack());
        }
        } 