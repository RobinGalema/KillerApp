using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp
{
    class Genre
    {
        // Fields
        private string name;
        private List<Game> games = new List<Game>();

        //  Constructor
        public Genre(string name, List<Game> games)
        {
            this.name = name;
            this.games = games;
        }

        // Properties
        public string Name { get => name; private set => name = value; }
        public List<Game> Games { get => games; private set => games = value; }
    }
}
