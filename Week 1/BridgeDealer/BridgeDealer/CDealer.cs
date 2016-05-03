using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BridgeDealer
{
    public class CDealer
    {
        private const int playerCount = 4;
        private CDeck cards;
        private CHand[] players;

        String Spades = "S:\t";
        String Hearts = "H:\t";
        String Diamonds = "D:\t";
        String Clubs = "C:\t";

        public CDealer()
        {
            cards = new CDeck();
            players = new CHand[playerCount]; //initialize the players array.

            for (int i = 0; i < playerCount; i++) //create a new CHand object for all the players in the players array.
                players[i] = new CHand();
        }

        public void Deal(ListBox lb)
        {
            cards.ShuffledHands(players); //shuffles all the players cards.

            lb.Items.Clear();

            for (int i = 0; i < players.Length; i++)
            {
                lb.Items.Add(((Player)(i)).ToString()); //adds the player position on the table (based on the enumerator)
                lb.Items.Add("");

                for (int j = 0; j < players[i].Hand.Length; j++)
                {
                    if (players[i].Hand[j].Suit == SuitValue.SPADES)
                    {
                        switch ((int)players[i].Hand[j].Number)
                        {
                            case 0:
                                Spades += "A ";
                                break;
                            case 9:
                                Spades += "T ";
                                break;
                            case 10:
                                Spades += "J ";
                                break;
                            case 11: 
                                Spades += "Q ";
                                break;
                            case 12:
                                Spades += "K ";
                                break;
                            default:
                                Spades += (int)players[i].Hand[j].Number + " ";
                                break;
                        }
                    }
                    else if(players[i].Hand[j].Suit == SuitValue.HEARTS)
                    {
                        
                        switch ((int)players[i].Hand[j].Number)
                        {
                            case 0:
                                Hearts += "A ";
                                break;
                            case 9:
                                Hearts += "T ";
                                break;
                            case 10:
                                Hearts += "J ";
                                break;
                            case 11:
                                Hearts += "Q ";
                                break;
                            case 12:
                                Hearts += "K ";
                                break;
                            default:
                                Hearts += (int)players[i].Hand[j].Number + " ";
                                break;
                        }
                    }
                    else if (players[i].Hand[j].Suit == SuitValue.DIAMONDS)
                    {
                        switch ((int)players[i].Hand[j].Number)
                        {
                            case 0:
                                Diamonds += "A ";
                                break;
                            case 9:
                                Diamonds += "T ";
                                break;
                            case 10:
                                Diamonds += "J ";
                                break;
                            case 11:
                                Diamonds += "Q ";
                                break;
                            case 12:
                                Diamonds += "K ";
                                break;
                            default:
                                Diamonds += (int)players[i].Hand[j].Number + " ";
                                break;
                        }

                    }
                    else if(players[i].Hand[j].Suit == SuitValue.CLUBS)
                    {
                        switch ((int)players[i].Hand[j].Number)
                        {
                            case 0:
                                Clubs += "A ";
                                break;
                            case 9:
                                Clubs += "T ";
                                break;
                            case 10:
                                Clubs += "J ";
                                break;
                            case 11:
                                Clubs += "Q ";
                                break;
                            case 12:
                                Clubs += "K ";
                                break;
                            default:
                                Clubs += (int)players[i].Hand[j].Number + " ";
                                break;
                        }
                    }
                }
                //print out strings
                lb.Items.Add(Spades);
                lb.Items.Add(Hearts);
                lb.Items.Add(Diamonds);
                lb.Items.Add(Clubs);

                //for (int j = 0; j < players[i].Hand.Length; j++)
                //    lb.Items.Add(players[i].Hand[j].ToString()); //adds each of the players cards to the list box.

                lb.Items.Add("");
                lb.Items.Add("HCP: " + players[i].TotalPoints().ToString()); //outputs the players high card point score.
                lb.Items.Add("-----------");
            }
        }
    }
}
