using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp
{
    class Game
    {
        // Fields
        private string name;
        private decimal price;
        private Developper developper;
        private Genre genre;
        private List<players> players = new List<players>();

        //Constructor
        public Game(string name, decimal price, Developper developper, Genre genre, List<players> players)
        {
            this.name = name;
            this.price = price;
            this.developper = developper;
            this.genre = genre;
            this.players = players;
        }

        // Properties
        public string Name { get => name; private set => name = value; }
        public decimal Price { get => price; private set => price = value; }
        public Developper Developper { get => developper; private set => developper = value; }
        public Genre Genre { get => genre; private set => genre = value; }
        public List<players> Players { get => players; private set => players = value; }
    }
}
