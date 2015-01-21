using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace flashcards
{
    /*
     *  this is the base for all cards
     */
    class Card
    {
        //static const int id = 1;  //maybe not...? idk
        string type = "";
        string word = "";
        string definition = "";
        string example = "";
        cards.POS pos;

        /*
        public int ID
        {
            get { return id; }
        }
        */
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        public string Definition
        {
            get { return definition; }
            set { definition = value; }
        }

        public string Example
        {
            get { return example; }
            set { example = value; }
        }

        internal cards.POS Pos
        {
            get { return pos; }
            set { pos = value; }
        }

        public Card(string newWord, string newDefinition, string newExample, string newType)
        {
            //getID();

            Word = newWord;
            Definition = newDefinition;
            Example = newExample;
            Type = newType;
        }
        /*
         * make type an enum
        public Card(string newWord, string newDefinition, string newType)
        {
            //getID();

            Word = newWord;
            Definition = newDefinition;
            Type = newType;
        }
         */

        public Card(string newWord, string newDefinition, string newExample)
        {
            //getID();

            Word = newWord;
            Definition = newDefinition;
            Example = newExample;
        }

        public Card(string newWord, string newDefinition)
        {
            //getID();

            Word = newWord;
            Definition = newDefinition;
        }

        public Card()
        {

        }
    }
}
