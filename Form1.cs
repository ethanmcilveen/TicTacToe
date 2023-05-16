//Author: Ethan McIlven
//Date: May 2023
//Purpose: Tic Tac Toe game made in C#

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class GameForm : Form
	{
		private int XScore = 0;//game variables
		private int OScore = 0;
		private string Char = "X";
		private int moves = 0;
		private Label[] tiles = new Label[9];
		private bool Win = false;
		public GameForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// Display the score, set all labels to an array, set all labels to a value other than X or O
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GameForm_Load(object sender, EventArgs e)
		{
			LblXScore.Text = $"X Score:{XScore}";
			LblOScore.Text = $"O Score:{OScore}";

			tiles[0] = label1;
			tiles[1] = label2;
			tiles[2] = label3;
			tiles[3] = label4;
			tiles[4] = label5;
			tiles[5] = label6;
			tiles[6] = label7;
			tiles[7] = label8;
			tiles[8] = label9;

			for (int i = 0; i < tiles.Length; i++)
			{
				tiles[i].Text = "A";
				tiles[i].ForeColor = Color.Black;
				tiles[i].BackColor = Color.Black;
			}
		}
		/// <summary>
		/// Show information on how to play the game
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ShowInfo(object sender, EventArgs e)
		{
			MessageBox.Show("Try to get 3 characters in a row. X starts first, goodluck!", "Instructions", MessageBoxButtons.OK);
		}

		/// <summary>
		/// Logic for anytime a tile (label) is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TileClicked(object sender, EventArgs e)
		{
			Label clickedTile = sender as Label;

			if (clickedTile.Text != "X" && clickedTile.Text != "O")
			{
				moves += 1;
				clickedTile.Text = Char;
				clickedTile.ForeColor = Color.White;
				CheckWin();

				if (Win == false)
				{
					if (Char == "O")
					{
						Char = "X";
					}
					else
					{
						Char = "O";
					}
				}
				else
				{
					DisplayWin();
				}
			}
		}

		/// <summary>
		/// Exits the application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Clears the score display above the game
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnClear_Click(object sender, EventArgs e)
		{
			XScore = 0;
			OScore = 0;
			UpdateScore();
		}
		/// <summary>
		/// Resets the game board
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnReset_Click(object sender, EventArgs e)
		{
			ResetGame();
		}

		/// <summary>
		/// Checks if the game conditions are a won state
		/// </summary>
		private void CheckWin()
		{
			string checkChar = Char;

			//123 456 789 147 258 369 159 357

			//horizontal
			if (tiles[0].Text == checkChar && tiles[1].Text == checkChar && tiles[2].Text == checkChar) { Win = true; }
			if (tiles[3].Text == checkChar && tiles[4].Text == checkChar && tiles[5].Text == checkChar) { Win = true; }
			if (tiles[6].Text == checkChar && tiles[7].Text == checkChar && tiles[8].Text == checkChar) { Win = true; }

			//vertical
			if (tiles[0].Text == checkChar && tiles[3].Text == checkChar && tiles[6].Text == checkChar) { Win = true; }
			if (tiles[1].Text == checkChar && tiles[4].Text == checkChar && tiles[7].Text == checkChar) { Win = true; }
			if (tiles[2].Text == checkChar && tiles[5].Text == checkChar && tiles[8].Text == checkChar) { Win = true; }

			//diagonal
			if (tiles[0].Text == checkChar && tiles[4].Text == checkChar && tiles[8].Text == checkChar) { Win = true; }
			if (tiles[2].Text == checkChar && tiles[4].Text == checkChar && tiles[6].Text == checkChar) { Win = true; }

			//if there is no winner
			if (moves == 9)
			{
				MessageBox.Show("Cats Game, No Winner!", "Draw");
				ResetGame();
			}
		}

		/// <summary>
		/// Update score, reset game, congratulate winner
		/// </summary>
		private void DisplayWin()
		{
			MessageBox.Show(Char + " Wins! ", "Winner");
			if (Char == "X")
			{
				XScore += 1;
			}
			else
			{
				OScore += 1;
			}
			ResetGame();
			UpdateScore();
		}

		/// <summary>
		/// Resets the game state
		/// </summary>
		private void ResetGame()
		{
			for (int i = 0; i < tiles.Length; i++)
			{
				tiles[i].Text = "A";
				tiles[i].ForeColor = Color.Black;
				tiles[i].BackColor = Color.Black;
			}
			Char = "X";
			moves = 0;
			Win = false;
		}

		/// <summary>
		/// Updates the score set above the game
		/// </summary>
		private void UpdateScore()
		{
			LblXScore.Text = $"X Score:{XScore}";
			LblOScore.Text = $"O Score:{OScore}";
		}
	}
}
