using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace flashcards.cards
{
    public enum partOfSpeech
    {
        noun,
        pronoun,
        verb,
        adj,
        naAdj,
        iAdj,
        adv,
        particle,
        interjection,
        conjuction,
        preposition,
        articles,
        coupla,
        onomatopoeia
    }

    class POS
    {
        /*
         *  Part of Speech is the part of the speech of the word
         *  color depends on POS
         *  A card can only have one POS
         *  
         */
        partOfSpeech pos;
    }

    class PartOfSpeech
    {
        /*
         * the color changes depending on type 
         * e.g. verbs, nouns, adjs, advs.
         * the color will primarily be used for vocabs or different types of words
         */
        private Color posColor;

        public Color PosColor
        {
            get { return posColor; }
            set { posColor = value; }
        }

        public string getInfo()
        {
            return "";
        }
    }

    class noun : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class pronoun : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class verb : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class adj : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class naAdj : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class iAdj : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class adv : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class particle : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class interjection : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class conjuction : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class preposition : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class articles : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }

    class coupla : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }
    class onomatopoeia : PartOfSpeech
    {

        public override string getInfo()
        {
            return "";
        }
    }


}
