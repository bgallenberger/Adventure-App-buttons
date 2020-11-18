using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Adventure_App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int magePoints = 0;
        int roguePoints = 0;
        int warriorPoints = 0;

        int scene = 0;

        void Description()
        {
            if (scene == 0)
            {
                continueButton.Text = "Continue";
                output.Text = "You are walking down a path on your way to the town when you see a small pull cart." +
                    " The cart is off to the side of the road and has a broken wheel. You could FIX the cart OR LOOT THE CART.";
                leftButton.Text = "Fix";
                rightButton.Text = "Loot The Cart";
            }
            else if (scene == 2)
            {
                output.Text = "After the cart is fixed he asks you if you would like a ride. You could help him and PULL THE " +
                    "CART with him OR you could get on the cart and he would give you a RIDE to the town.";
                leftButton.Text = "Pull The Cart";
                rightButton.Text = "Ride";
            }
            else if (scene == 4)
            {
                output.Text = "You reach the town. You are asked by the guards to pay the entrance fee. You could CONVINCE the guards " +
                    "to let you in for free Or just PAY the entrance fee.";
                leftButton.Text = "Convince";
                rightButton.Text = "Pay";
            }
            else if (scene == 6)
            {
                output.Text = "You head to the tavern and sit at the bar. You could LISTEN around for rumours OR you " +
                    "could relax and DRINK.";
                leftButton.Text = "Listen";
                rightButton.Text = "Drink";
            }
            else if (scene == 8)
            {
                output.Text = "You head to the market to get some supplies. A merchant has everything you need, but the cost is high." +
                    "You could STEAL the goods OR try to BARTER for a better deal.";
                leftButton.Text = "Steal";
                rightButton.Text = "Barter";
            }
            else if (scene == 10)
            {
                output.Text = "You find tracks on the ground. FOLLOW them OR INVESTIGATE.";
                leftButton.Text = "Follow";
                rightButton.Text = "Investigate";
            }
            else if (scene == 12)
            {
                output.Text = "Suddenly wolves rush out of the woods. You could CHARGE them OR RUN.";
                leftButton.Text = "Charge";
                rightButton.Text = "Run";
            }
            else if (scene == 14)
            {
                output.Text = "You Encounter an injured dragon that is sleeping in it's nest. FIGHT OR LOOT DEN";
                leftButton.Text = "Fight";
                rightButton.Text = "Loot Den";
            }
            else if (scene == 16)
            {
                string characterClass = "Adventure";
                if (magePoints > warriorPoints && magePoints > roguePoints)
                {
                    characterClass = "Mage";
                }
                else if (warriorPoints > magePoints && warriorPoints > roguePoints)
                {
                    characterClass = "Warrior";
                }
                else if (roguePoints > warriorPoints && roguePoints > magePoints)
                {
                    characterClass = "Rogue";
                }
                else if (magePoints == warriorPoints && magePoints > roguePoints)
                {
                    characterClass = "Battle Mage";
                }
                else if (magePoints == roguePoints && magePoints > warriorPoints)
                {
                    characterClass = "Alchemist";
                }
                else if (warriorPoints > magePoints && warriorPoints == roguePoints)
                {
                    characterClass = "Assassin";
                }
                else if (magePoints == warriorPoints && magePoints == roguePoints)
                {
                    characterClass = "Bard";
                }

                output.Text = $"You are a {characterClass}!\nMage:{magePoints} Warrior:{warriorPoints} Rogue:{roguePoints}";
                scene = -1;
                magePoints = 0;
                roguePoints = 0;
                warriorPoints = 0;
                continueButton.Text = "Try Again";
                ToggleButtons();
            }

            scene++;

        }

        void OnLeftClicked(object sender, System.EventArgs e)
        {
            ToggleButtons();

            if (scene == 1)
            {
                continueButton.Text = "Continue";
                output.Text = "You decide to fix the cart. While you are fixing the cart a man comes out of the woods, " +
                    "and looks at you suprised. He relizes that you are fixing the cart and quickly thanks you.";
                magePoints++;
            }
            else if (scene == 3)
            {
                output.Text = "You decide to pull the cart with him. He thanks you again and the two of you start making your way to town.";
                warriorPoints++;
            }
            else if (scene == 5)
            {
                output.Text = "You Convince the guard to let you in for free.";
                magePoints++;
                roguePoints++;
            }
            else if (scene == 7)
            {
                output.Text = "You decide to listen to the other customers for valuble information. You hear a rumor of an injured dragon.";
                magePoints++;
                roguePoints++;
            }
            else if (scene == 9)
            {
                output.Text = "You decide to steal the goods while the merchant tends to another customer. " +
                    "You quickly leave the town and head on your way to contunue your adventure.";
                roguePoints++;
            }
            else if (scene == 11)
            {
                output.Text = "You decide to follow the tracks until you hear a rustling in the bushes.";
                warriorPoints++;
            }
            else if (scene == 13)
            {
                output.Text = "You decide to charge the wolves. After a long battle you are exuasted, but most of the " +
                    "wolves are dead. The remander flee and you continue on you way.";
                warriorPoints++;
            }
            else if (scene == 15)
            {
                output.Text = "You decide to strike while the injured dragon is still sleeping. A stike a fatal blow " +
                    "before the dragon even wakes up. All the glory and loot is yours now.";
                warriorPoints++;
                magePoints++;
            }

            Description();
        }
        void OnRightClicked(object sender, System.EventArgs e)
        {
            ToggleButtons();

            if (scene == 1)
            {
                continueButton.Text = "Continue";
                output.Text = "You decide to steal from the cart. While you are looting the cart a man comes out of the woods, " +
                    "and looks at you suprised. You quikly hide the few coins that you grabed and tell him that you are " +
                    "fixing the cart. He smiles and thanks you.";
                roguePoints++;
                warriorPoints++;
            }
            else if (scene == 3)
            {
                output.Text = "You decide to take the free ride. You get on and the man begins heading in the direction of the town.";
                roguePoints++;
                magePoints++;
            }
            else if (scene == 5)
            {
                output.Text = "You decide to simply pay the entrance fee and head inside.";
                warriorPoints++;
            }
            else if (scene == 7)
            {
                output.Text = "You are tired so you decide to relax and drink for a while.";
                warriorPoints++;
            }
            else if (scene == 9)
            {
                output.Text = "You decide to barter with the merchant and end up getting a good deal on the goods.";
                warriorPoints++;
                magePoints++;
            }
            else if (scene == 11)
            {
                output.Text = "You decide to investigate the tracks and realize they were left from an injured beast. Then you hear a noise.";
                roguePoints++;
                magePoints++;
            }
            else if (scene == 13)
            {
                output.Text = "You decide to run from the wolves, and eventually you lose them when you climb up a tree.";
                roguePoints++;
                magePoints++;
            }
            else if (scene == 15)
            {
                output.Text = "You decide to sneakaliy loot the dragons den. You make a getaway with bags full of gold. You are rich!";
                roguePoints++;
            }

            Description();
        }
        void Continue(object sender, System.EventArgs e)
        {
            ToggleButtons();
            Description();

        }

        void ToggleButtons()
        {
            leftButton.IsVisible = !leftButton.IsVisible;
            rightButton.IsVisible = !rightButton.IsVisible;
            continueButton.IsVisible = !continueButton.IsVisible;
        }
    }
}
