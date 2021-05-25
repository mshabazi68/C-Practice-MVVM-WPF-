using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {

        public  int Id { get; set; }
        public String  JokeQestion { get; set; }
        public String JokeAmswer { get;   set; }


        public Joke() 
        { 

        }
    }
}
