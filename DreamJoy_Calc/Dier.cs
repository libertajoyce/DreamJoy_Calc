using System;
using System.Collections.Generic;
using System.Text;

namespace DreamJoy_Calc
{
    abstract class Dier
    {
        private string _naam;

        public  string Naam
        {
            get { return _naam; }
           
           
        }

        public Dier(string naam)
        {
            _naam = naam;
        }

        public virtual string Eten()
        {
            return "Lekker";
        }

        public virtual string Praten(string input)
        {
            string output = "";
            switch (input)
            {   case "Goedemorgen":
                    output = "Ook een goedemorgen"; 
                break;

                case "F off":
                    output = "Jij ook";
                    break;

                case "How are you?":
                    output = "Ook een goedemorgen";
                    break;

                case "Hey Felicia":
                    output = "Bye Felicia";
                    break;

                case "Yeet":
                    output = "Yooo";
                    break;

                case "Laat mij slapen":
                    output = "Groot gelijk";
                    break;

                case "Today is gonna be the day":
                    output = "that they're all gonna .. ";
                    break;

                case "ik wil naar huis":
                    output = "Vertrek dan";
                    break;

                case "Be zen":
                    output = "Zen life";
                    break;

                case "Hello V":
                    output = "Hey Panam";
                    break;


                default:  output = "Wrong Input";
                    break;
            }
            return "";
            
        }
        
        public virtual string Strelen()
        {
            return "jaja";
        }



    }

    class Mens : Dier
    {
        public Mens(string naam) //constructor
            :base(naam)   //wordt enkel aangeroepen in de base constructor Dier
        {
          
        }
        public override string Eten()
        {
            return "haha";
        }

        public override string Praten()
        {

            return "lol";
        }

        public override string Strelen()
        {
            return "jaja";
        }
    }

    class Papegaai : Dier
    {
        public Papegaai(string naam)
         : base(naam)   
        {

        }
        public override string Praten()
        {

            return "lol";
        }
        public override string Strelen()
        {
            return "jaja";
        }
    }

    class Kat : Dier
    {
        private int _teller;

        public Kat(string naam)
         : base(naam)
        {

        }
        public override string Praten()
        {

            return "lol";
        }

        public override string Strelen()
        {
            return "jaja";
        }



    }
}

