using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteper
{
    class Program
    {
        static void Main(string[] args)
        {
            #region list
            Card inCard = new Card();
            List<Card> deck = new List<Card>();
            List<Card> shuffledDeck = new List<Card>();

            Card hare = new Card("Hare");
            Card haj = new Card("Haj");
            Card kylling = new Card("Kylling");
            Card sortePer = new Card("Sorte Per");
            Card ugle = new Card("Ugle");
            Card kat = new Card("Kat");
            Card hund = new Card("Hund");
            Card elephant = new Card("Elephant");
            Card slange = new Card("Slange");
            Card loppe = new Card("Loppe");
            Card fisk = new Card("Fisk");
            deck.Add(hare);
            deck.Add(hare);
            deck.Add(haj);
            deck.Add(haj);
            deck.Add(kylling);
            deck.Add(kylling);
            deck.Add(sortePer);
            deck.Add(ugle);
            deck.Add(ugle);
            deck.Add(kat);
            deck.Add(kat);
            deck.Add(hund);
            deck.Add(hund);
            deck.Add(elephant);
            deck.Add(elephant);
            deck.Add(slange);
            deck.Add(slange);
            deck.Add(loppe);
            deck.Add(loppe);
            deck.Add(fisk);
            deck.Add(fisk);
            #endregion
            foreach (Card item in deck)
            {
                Random r = new Random();
                //deck<Card>(item);
                //inCard.CardsShuffle[item]();
                



                //deck<string>.
                //deck[item].CardsShuffle(item.Cards);



            }
            //foreach (Card itemtest in deck)
            //{
            //    inCard.CardsShuffle(itemtest.Cards);
            //    Console.WriteLine(itemtest.Cards);
            //}
            
            Console.ReadKey();
        }
    }
}
