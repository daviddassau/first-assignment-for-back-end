using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Movie
    {
        protected string _starWars;
        public string StarWars
        {
            get
            {
                return _starWars;
            }
            set
            {
                _starWars = value;
            }
        } 

        protected string _starTrek;
        public string StarTrek
        {
            get
            {
                return _starTrek;
            }
            set
            {
                _starTrek = value;
            }
        }

        public Movie()
        {
            this._starWars = "5 stars";
            this._starTrek = "4 stars";
        }

        public string GetStarWarsCharacter(bool hanSoloIsDead)
        {
            if (hanSoloIsDead == true)
                return "Han Solo died in The Force Awakens";
            else
                return "Han Solo is definitely still alive. Kylo Ren definitely didn't kill him.";
        }
    }

    class Book
    {
        protected string _fightClub;
        public string FightClub
        {
            get
            {
                return _fightClub;
            }
            set
            {
                _fightClub = value;
            }
        }

        protected string _theGreatGatsby;
        public string TheGreatGatsby
        {
            get
            {
                return _theGreatGatsby;
            }
            set
            {
                _theGreatGatsby = value;
            }
        }

        public Book()
        {
            this._fightClub = "Release date: 1999";
            this._theGreatGatsby = "Release date: 1925";
        }

        public string BookReleaseDate(bool fightClubCameAfterGatsby)
        {
            if (fightClubCameAfterGatsby == true)
                return "The book Fight Club was published after The Great Gatsby";
            else
                return "You must be dyslexic, because The Great Gatsby came out like 100 years ago, bro.";
        }
    }

    class Game
    {
        protected string _cardsAgainstHumanity;
        public string CardsAgainstHumanity
        {
            get
            {
                return _cardsAgainstHumanity;
            }
            set
            {
                _cardsAgainstHumanity = value;
            }
        }

        protected string _uno;
        public string Uno
        {
            get
            {
                return _uno;
            }
            set
            {
                _uno = value;
            }
        }

        public Game()
        {
            this._cardsAgainstHumanity = "This game is for terrible people";
            this._uno = "This game is for everyone";
        }

        public string CardGamesThatAreOffensive(bool cardsAgainstHumanityIsOffensive)
        {
            if (cardsAgainstHumanityIsOffensive == true)
                return "This game is offensive and should only be played by terrible people";
            else
                return "As long as you are a terrible person, and not easily offended, go ahead and play Cards Against Humanity. You'll love it.";
        }
    }
}
