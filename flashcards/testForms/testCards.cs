using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flashcards.testForms
{
    public partial class testCards : Form
    {
        public testCards()
        {
            InitializeComponent();
            initArrayList();
            updateCardList();
            clearView();
        }

        //array for cards
        ArrayList cardArrayList = new ArrayList();
        

        private void initArrayList()
        {
            Card card1 = new Card("uropygium", "the hump at the rear extremity of a bird's body, from which tail feathers grow.", "birds", "noun");
            Card card2 = new Card("savant", "1. a learned person; a scholar. 2. an idiot savant.");
            Card card3 = new Card("paladin", "1. a heroic champion. 2. a strong supporter or defender of a cause. 3. any of the twelve peers of Charlemagne's court.", "Young Luke Skywalker");
            Card card4 = new Card("liminal", "1. at an intermediate state. 2. at the threshold of consciousness.");
            Card card5 = new Card("nosocomial", "1. pertaining to a hospital. 2. of or being a secondary disorder associated with being treated in a hospital but unrelated to the patient's primary condition.");

            cardArrayList.Add(card1);
            cardArrayList.Add(card2);
            cardArrayList.Add(card3);
            cardArrayList.Add(card4);
            cardArrayList.Add(card5);
        }

        private void clearMake()
        {
            tbColor.Clear();
            tbDef.Clear();
            tbEx.Clear();
            tbType.Clear();
            tbWord.Clear();
        }

        private void clearView()
        {
            lbViewShowWord.Text = string.Empty;
            lbViewShowType.Text = string.Empty;
            lbViewShowEx.Text = string.Empty;
            lbViewShowDef.Text = string.Empty;
            lbViewShowColor.Text = string.Empty;
        }

        private void clearListBox()
        {
            cardListBox.Items.Clear();
        }

        //add show arraylist in the listbox
        private void updateCardList()
        {
            clearListBox();

            foreach (Card card in cardArrayList)
            {
                cardListBox.Items.Add(card.Word);
            }
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            string wrd = tbWord.Text;
            string def = tbDef.Text;
            string example = tbEx.Text;
            string typ = tbType.Text;
            string colr = tbColor.Text;

            Card new_card = new Card(wrd, def, example, typ);
            cardArrayList.Add(new_card);

            //update listbox
            updateCardList();

            clearMake();

        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            int index = cardListBox.SelectedIndex;
            Card viewingCard = new Card();
            viewingCard = (Card)cardArrayList[index];

            lbViewShowWord.Text = viewingCard.Word;
            lbViewShowDef.Text = viewingCard.Definition;
            lbViewShowEx.Text = viewingCard.Example;
            lbViewShowType.Text = viewingCard.Type;
            //lbViewShowColor.Text = viewingCard.Color;
        }

        private void btnListDelete_Click(object sender, EventArgs e)
        {
            int index = cardListBox.SelectedIndex;
            cardArrayList.RemoveAt(index);

            updateCardList();
        }

        private void populateMake()
        {
            int index = cardListBox.SelectedIndex;
            Card editCard = new Card();
            editCard = (Card)cardArrayList[index];

            tbWord.Text = editCard.Word;
            tbDef.Text = editCard.Definition;
            tbEx.Text = editCard.Example;
            tbType.Text = editCard.Type;
            //tbColor.Text = editCard.Color;
        }

        private void btnListEdit_Click(object sender, EventArgs e)
        {
            populateMake();
        }

        private void updateCard()
        {
            //if there isn't a word don't update
            if (string.IsNullOrEmpty(tbWord.Text))
                return;

            int index = cardListBox.SelectedIndex;
            Card tempCard = new Card();
            tempCard = (Card)cardArrayList[index];

            tempCard.Word = tbWord.Text;
            tempCard.Definition = tbDef.Text;
            tempCard.Example = tbEx.Text;
            tempCard.Type = tbType.Text;
            //tempCard.Color = (Color) tbColor.Text;

            cardArrayList[index] = tempCard;
        }

        private void btnUpdateCard_Click(object sender, EventArgs e)
        {
            updateCard();
            clearMake();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
