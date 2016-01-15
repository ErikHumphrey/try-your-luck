/* _____           __   __                 _                _    
  |_   _|          \ \ / /                | |              | |   
    | |_ __ _   _   \ V /___  _   _ _ __  | |    _   _  ___| | __
    | | '__| | | |   \ // _ \| | | | '__| | |   | | | |/ __| |/ /
    | | |  | |_| |   | | (_) | |_| | |    | |___| |_| | (__|   < 
    \_/_|   \__, |   \_/\___/ \__,_|_|    \_____/\__,_|\___|_|\_\
             __/ |                                               
            |___/                                                 */

/* Author: Erik Humphrey
 * Project title: Project 17 - Try Your Luck
 * Date started: December 3rd
 * Executable name: HumphreyErik17TryYourLuck.exe
 * Description: Single-button dice-rolling simulation 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumphreyErik17TryYourLuck
{
    public partial class frmTryYourLuck : Form
    {
        // Global declarations
        int dice1, dice2, diceTotal, gamesPlayed, wins, losses;
        Random rnd = new Random();

        public frmTryYourLuck()
        {
            InitializeComponent();
        }

        // Method to clear the game log

        void ClearLog()
        {
            lstGameLog.Items.Clear();
        }

        // User clicks roll dice button

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            btnResetGame.Enabled = true; // Enable `Reset winrate` button
            bool lost = false; 
            ClearLog(); // Clear the game log ListBox

            do
            {
                // Give the dice variables random values from 1-6
                dice1 = rnd.Next(1, 7);
                dice2 = rnd.Next(1, 7);
                // Total the values of the dice
                diceTotal = dice1 + dice2;
                lstGameLog.Items.Add("You roll a " + dice1 + " and a " + dice2 + "."); // Print values rolled to game log
                // If dice values are equal, set that the user has lost
                if (dice1 == dice2)
                {
                    lost = true;
                }
            }
            while (diceTotal != 7 && lost == false); // repeat the above as long as the user has not lost or rolled a total of 7 (a win)
             
            float winPercent = 0;

            // If the user lost
            if (lost == true)
            {
                lstGameLog.Items.Add("You lost."); // Print result to game log
                losses++; // Increase loss amount
                gamesPlayed = losses + wins;
                lblCounterLosses.Text = "Losses: " + losses; // Update the label counting losses 
                // Calculate win percentage 
                if (gamesPlayed > 0)
                    winPercent = ((float)wins / (float)gamesPlayed) * 100;
                lblWinLossPercentage.Text = "W / L: " + (int)winPercent + "%"; // Update W/L label

            }
            // If the user won
            else
            {
                lstGameLog.Items.Add("You win!");
                wins++;
                gamesPlayed = losses + wins;
                lblCounterWins.Text = "Wins: " + wins;
                if (gamesPlayed > 0)
                    winPercent = ((float)wins / (float)gamesPlayed * 100);
                lblWinLossPercentage.Text = "W / L: " + (int)winPercent + "%";
            }

            // Bonus message in game log for milestones in games played
            if ( gamesPlayed == 10  ||
                 gamesPlayed == 25  ||
                 gamesPlayed == 50  ||
                 gamesPlayed == 100 ||
                 gamesPlayed == 1000 )
            {
                lstGameLog.Items.Add("*** You've tried your luck " + gamesPlayed + " times! ***");
            }
        }

        // Reset game button

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            DialogResult wantsToReset = MessageBox.Show(
                "Are you sure you want to reset the game?\r\nYour win/loss history will be lost!",
                "Confirm reset",
                MessageBoxButtons.OKCancel);
            if (wantsToReset == DialogResult.OK) {
            ClearLog();
            // Reset wins and losses values
            wins = losses = 0;
            // Revert label text
            lblCounterWins.Text = "Wins: 0";
            lblCounterLosses.Text = "Losses: 0";
            lblWinLossPercentage.Text = "W / L: 0%";
            }
        }
    }
}
