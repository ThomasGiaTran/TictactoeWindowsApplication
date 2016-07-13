//========================== LOGIC ===============================
//Author:                   Thomas Tran
//Author's email:           trangiadat86@gmail.com
//Course:                   CPSC223N
//Assignment number:        Assignment 3
//Due date:                 Mar 16, 2015
//========================== LOGIC ===============================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace tictactoe
{

     public partial class Form1 : Form
     {
          //declaring variables
          int turn_count = 0;
          bool turn = true;
          bool againstComputer = true;

          public Form1()
          {
               InitializeComponent();
          }

          private void exit_Click(object sender, EventArgs e)
          {   //exit aplication when click exit
               Application.Exit();
          }

          private void computerPlay()
          {
               Button move = null;
               move = look_for_win_or_block("P"); //look for win
               if (move == null)
               {
                    move = look_for_win_or_block("C"); //look for block
                    if (move == null)
                         move = look_for_open_space();
               }//end if
               if (turn_count == 25)
                    return;
               move.PerformClick();
          }//end computerPlay

          private Button look_for_open_space()
          {
               Button b = null;
               foreach (Control c in Controls)
               {
                    b = c as Button;
                    if (b != null)
                    {
                         if (b.Text == "")
                              return b;
                    }//end if
               }//end foreach
               return null;
          }//end look_for_open_space

          private Button look_for_win_or_block(string mark)
          {
               //HORIZONTAL CHECKS
               //1st row
               if ((a1.Text == mark) && (a2.Text == mark) && (a3.Text == mark) && (a4.Text == mark) && (a5.Text == ""))
                    return a5;
               if ((a1.Text == mark) && (a2.Text == mark) && (a3.Text == mark) && (a5.Text == mark) && (a4.Text == ""))
                    return a4;
               if ((a1.Text == mark) && (a2.Text == mark) && (a4.Text == mark) && (a5.Text == mark) && (a3.Text == ""))
                    return a3;
               if ((a1.Text == mark) && (a3.Text == mark) && (a4.Text == mark) && (a5.Text == mark) && (a2.Text == ""))
                    return a2;
               if ((a2.Text == mark) && (a3.Text == mark) && (a4.Text == mark) && (a5.Text == mark) && (a1.Text == ""))
                    return a1;
               //2nd row
               if ((b1.Text == mark) && (b2.Text == mark) && (b3.Text == mark) && (b4.Text == mark) && (b5.Text == ""))
                    return b5;
               if ((b1.Text == mark) && (b2.Text == mark) && (b3.Text == mark) && (b5.Text == mark) && (b4.Text == ""))
                    return b4;
               if ((b1.Text == mark) && (b2.Text == mark) && (b4.Text == mark) && (b5.Text == mark) && (b3.Text == ""))
                    return b3;
               if ((b1.Text == mark) && (b3.Text == mark) && (b4.Text == mark) && (b5.Text == mark) && (b2.Text == ""))
                    return b2;
               if ((b2.Text == mark) && (b3.Text == mark) && (b4.Text == mark) && (b5.Text == mark) && (b1.Text == ""))
                    return b1;
               //3rd row
               if ((c1.Text == mark) && (c2.Text == mark) && (c3.Text == mark) && (c4.Text == mark) && (c5.Text == ""))
                    return c5;
               if ((c1.Text == mark) && (c2.Text == mark) && (c3.Text == mark) && (c5.Text == mark) && (c4.Text == ""))
                    return c4;
               if ((c1.Text == mark) && (c2.Text == mark) && (c4.Text == mark) && (c5.Text == mark) && (c3.Text == ""))
                    return c3;
               if ((c1.Text == mark) && (c3.Text == mark) && (c4.Text == mark) && (c5.Text == mark) && (c2.Text == ""))
                    return c2;
               if ((c2.Text == mark) && (c3.Text == mark) && (c4.Text == mark) && (c5.Text == mark) && (c1.Text == ""))
                    return c1;
               //4th row
               if ((d1.Text == mark) && (d2.Text == mark) && (d3.Text == mark) && (d4.Text == mark) && (d5.Text == ""))
                    return d5;
               if ((d1.Text == mark) && (d2.Text == mark) && (d3.Text == mark) && (d5.Text == mark) && (d4.Text == ""))
                    return d4;
               if ((d1.Text == mark) && (d2.Text == mark) && (d4.Text == mark) && (d5.Text == mark) && (d3.Text == ""))
                    return d3;
               if ((d1.Text == mark) && (d3.Text == mark) && (d4.Text == mark) && (d5.Text == mark) && (d2.Text == ""))
                    return d2;
               if ((d2.Text == mark) && (d3.Text == mark) && (d4.Text == mark) && (d5.Text == mark) && (d1.Text == ""))
                    return d1;
               //5th row
               if ((e1.Text == mark) && (e2.Text == mark) && (e3.Text == mark) && (e4.Text == mark) && (e5.Text == ""))
                    return e5;
               if ((e1.Text == mark) && (e2.Text == mark) && (e3.Text == mark) && (e5.Text == mark) && (e4.Text == ""))
                    return e4;
               if ((e1.Text == mark) && (e2.Text == mark) && (e4.Text == mark) && (e5.Text == mark) && (e3.Text == ""))
                    return e3;
               if ((e1.Text == mark) && (e3.Text == mark) && (e4.Text == mark) && (e5.Text == mark) && (e2.Text == ""))
                    return e2;
               if ((e2.Text == mark) && (e3.Text == mark) && (e4.Text == mark) && (e5.Text == mark) && (e1.Text == ""))
                    return e1;
               //VERTICAL TESTS
               //1st collumn
               if ((b1.Text == mark) && (c1.Text == mark) && (d1.Text == mark) && (e1.Text == mark) && (a1.Text == ""))
                    return a1;
               if ((a1.Text == mark) && (c1.Text == mark) && (d1.Text == mark) && (e1.Text == mark) && (b1.Text == ""))
                    return b1;
               if ((a1.Text == mark) && (b1.Text == mark) && (d1.Text == mark) && (e1.Text == mark) && (c1.Text == ""))
                    return c1;
               if ((a1.Text == mark) && (b1.Text == mark) && (c1.Text == mark) && (e1.Text == mark) && (d1.Text == ""))
                    return d1;
               if ((a1.Text == mark) && (b1.Text == mark) && (c1.Text == mark) && (d1.Text == mark) && (e1.Text == ""))
                    return e1;
               //2nd collumn
               if ((b2.Text == mark) && (c2.Text == mark) && (d2.Text == mark) && (e2.Text == mark) && (a2.Text == ""))
                    return a2;
               if ((a2.Text == mark) && (c2.Text == mark) && (d2.Text == mark) && (e2.Text == mark) && (b2.Text == ""))
                    return b2;
               if ((a2.Text == mark) && (b2.Text == mark) && (d2.Text == mark) && (e2.Text == mark) && (c2.Text == ""))
                    return c2;
               if ((a2.Text == mark) && (b2.Text == mark) && (c2.Text == mark) && (e2.Text == mark) && (d2.Text == ""))
                    return d2;
               if ((a2.Text == mark) && (b2.Text == mark) && (c2.Text == mark) && (d2.Text == mark) && (e2.Text == ""))
                    return e2;
               //3rd collumn
               if ((b3.Text == mark) && (c3.Text == mark) && (d3.Text == mark) && (e3.Text == mark) && (a3.Text == ""))
                    return a3;
               if ((a3.Text == mark) && (c3.Text == mark) && (d3.Text == mark) && (e3.Text == mark) && (b3.Text == ""))
                    return b3;
               if ((a3.Text == mark) && (b3.Text == mark) && (d3.Text == mark) && (e3.Text == mark) && (c3.Text == ""))
                    return c3;
               if ((a3.Text == mark) && (b3.Text == mark) && (c3.Text == mark) && (e3.Text == mark) && (d3.Text == ""))
                    return d3;
               if ((a3.Text == mark) && (b3.Text == mark) && (c3.Text == mark) && (d3.Text == mark) && (e3.Text == ""))
                    return e3;
               //4th collumn
               if ((b4.Text == mark) && (c4.Text == mark) && (d4.Text == mark) && (e4.Text == mark) && (a4.Text == ""))
                    return a4;
               if ((a4.Text == mark) && (c4.Text == mark) && (d4.Text == mark) && (e4.Text == mark) && (b4.Text == ""))
                    return b4;
               if ((a4.Text == mark) && (b4.Text == mark) && (d4.Text == mark) && (e4.Text == mark) && (c4.Text == ""))
                    return c4;
               if ((a4.Text == mark) && (b4.Text == mark) && (c4.Text == mark) && (e4.Text == mark) && (d4.Text == ""))
                    return d4;
               if ((a4.Text == mark) && (b4.Text == mark) && (c4.Text == mark) && (d4.Text == mark) && (e4.Text == ""))
                    return e4;
               //5th collumn
               if ((b5.Text == mark) && (c5.Text == mark) && (d5.Text == mark) && (e5.Text == mark) && (a5.Text == ""))
                    return a5;
               if ((a5.Text == mark) && (c5.Text == mark) && (d5.Text == mark) && (e5.Text == mark) && (b5.Text == ""))
                    return b5;
               if ((a5.Text == mark) && (b5.Text == mark) && (d5.Text == mark) && (e5.Text == mark) && (c5.Text == ""))
                    return c5;
               if ((a5.Text == mark) && (b5.Text == mark) && (c5.Text == mark) && (e5.Text == mark) && (d5.Text == ""))
                    return d5;
               if ((a5.Text == mark) && (b5.Text == mark) && (c5.Text == mark) && (d5.Text == mark) && (e5.Text == ""))
                    return e5;
               //DIAGONAL TESTS
               //top right to bottom left check
               if ((a1.Text == mark) && (b2.Text == mark) && (c3.Text == "") && (d4.Text == mark) && (e5.Text == ""))
                    return e5;
               if ((a1.Text == mark) && (b2.Text == mark) && (c3.Text == "") && (e5.Text == mark) && (d4.Text == ""))
                    return d4;
               if ((a1.Text == mark) && (b2.Text == mark) && (d4.Text == "") && (e5.Text == mark) && (c3.Text == ""))
                    return c3;
               if ((a1.Text == mark) && (c3.Text == mark) && (d4.Text == "") && (e5.Text == mark) && (b2.Text == ""))
                    return b2;
               if ((b2.Text == mark) && (c3.Text == mark) && (d4.Text == "") && (e5.Text == mark) && (a1.Text == ""))
                    return a1;
               //bottom left to top right check
               if ((e1.Text == mark) && (d2.Text == mark) && (c3.Text == "") && (b4.Text == mark) && (a5.Text == ""))
                    return a5;
               if ((e1.Text == mark) && (d2.Text == mark) && (c3.Text == "") && (a5.Text == mark) && (b4.Text == ""))
                    return b4;
               if ((e1.Text == mark) && (d2.Text == mark) && (b4.Text == "") && (a5.Text == mark) && (c3.Text == ""))
                    return c3;
               if ((e1.Text == mark) && (c3.Text == mark) && (b4.Text == "") && (a5.Text == mark) && (d2.Text == ""))
                    return d2;
               if ((d2.Text == mark) && (c3.Text == mark) && (b4.Text == "") && (a5.Text == mark) && (e1.Text == ""))
                    return e1;
               return null;
          }// end look_for_win_or_block

          private void Square_Click(object sender, EventArgs e)
          {
               Button b = (Button)sender;
               if (turn)
               {
                    b.Text = "P";
               }
               else
                    b.Text = "C";
               turn = !turn;
               b.Enabled = false; //to prevent overwriting on same box
               turn_count++;
               checkForWinner();
               if ((!turn) && (againstComputer))
                    computerPlay();
          }//end Square_Click

          private void checkForWinner()
          {
               bool there_is_a_winner = false;
               //horizontal checks
               if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (a3.Text == a4.Text) && (a4.Text == a5.Text) && (!a1.Enabled))
                    there_is_a_winner = true;
               if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (b3.Text == b4.Text) && (b4.Text == b5.Text) && (!b1.Enabled))
                    there_is_a_winner = true;
               if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (c3.Text == c4.Text) && (c4.Text == c5.Text) && (!c1.Enabled))
                    there_is_a_winner = true;
               if ((d1.Text == d2.Text) && (d2.Text == d3.Text) && (d3.Text == d4.Text) && (d4.Text == d5.Text) && (!d1.Enabled))
                    there_is_a_winner = true;
               if ((e1.Text == e2.Text) && (e2.Text == e3.Text) && (e3.Text == e4.Text) && (e4.Text == e5.Text) && (!e1.Enabled))
                    there_is_a_winner = true;
               //vertical checks
               if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (c1.Text == d1.Text) && (d1.Text == e1.Text) && (!a1.Enabled))
                    there_is_a_winner = true;
               if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (c2.Text == d2.Text) && (d2.Text == e2.Text) && (!a2.Enabled))
                    there_is_a_winner = true;
               if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (c3.Text == d3.Text) && (d3.Text == e3.Text) && (!a3.Enabled))
                    there_is_a_winner = true;
               if ((a4.Text == b4.Text) && (b4.Text == c4.Text) && (c4.Text == d4.Text) && (d4.Text == e4.Text) && (!a4.Enabled))
                    there_is_a_winner = true;
               if ((a5.Text == b5.Text) && (b5.Text == c5.Text) && (c5.Text == d5.Text) && (d5.Text == e5.Text) && (!a5.Enabled))
                    there_is_a_winner = true;
               //diagonal checks
               if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (c3.Text == d4.Text) && (d4.Text == e5.Text) && (!a1.Enabled))
                    there_is_a_winner = true;
               if ((a5.Text == b4.Text) && (b4.Text == c3.Text) && (c3.Text == d2.Text) && (d2.Text == e1.Text) && (!a5.Enabled))
                    there_is_a_winner = true;

               if (there_is_a_winner) //there is winner
               {
                    disable_25buttons();
                    if (turn)
                         outputWinner.Text = "Computer";
                    else
                         outputWinner.Text = "Person";
               }
               else //no winner
                    outputWinner.Text = "No Winner";
          }//end checkForWinner

          private void disable_25buttons()
          {
               foreach (Control c in Controls)
               {
                    if (c is Button)
                    {
                         c.Enabled = false;
                         exit.Enabled = true;
                         save.Enabled = true;
                         resume.Enabled = true;
                         newGame.Enabled = true;
                    }//end if
               }//end foreach
          }//end disable_25buttons

          private void newGame_Click(object sender, EventArgs e)
          {
               turn = true;
               turn_count = 0;
               person.Checked = false;
               computer.Checked = false;
               foreach (Control c in Controls)
               {
                    if (c is Button)
                    {
                         c.Enabled = true;
                         c.Text = "";
                         exit.Text = "Exit";
                         save.Text = "Save";
                         resume.Text = "Resume";
                         newGame.Text = "New Game";
                         outputWinner.Text = "";
                         outputStarter.Text = "";
                    }//end if
               }//end foreach
          }//end newGame_Click

          private void person_CheckedChanged(object sender, EventArgs e)
          {
               outputStarter.Text = "Starting Person";
               turn_count = 0;
               foreach (Control c in Controls)
               {
                    if (c is Button)
                    {
                         c.Enabled = true;
                         c.Text = "";
                         exit.Text = "Exit";
                         save.Text = "Save";
                         resume.Text = "Resume";
                         newGame.Text = "New Game";
                    }//end if
               }//end foreach
          }//end person_CheckedChanged

          private void computer_CheckedChanged(object sender, EventArgs e)
          {
               outputStarter.Text = "Starting Computer";
               turn_count = 0;
               turn = false;
               computerPlay();
          }//end computer_CheckedChanged

          private void save_Click(object sender, EventArgs e)
          {
               StreamWriter sw = new StreamWriter("savedGame.txt");
               disable_25buttons();
               foreach (Control c in Controls)
               {
                    if (c is Button && !c.Enabled)
                         sw.WriteLine(c.Text);
               }//end foreach
               sw.Close();//close file
          }//end save_Click

          private void resume_Click(object sender, EventArgs e)
          {
               StreamReader sr = new StreamReader("savedGame.txt");
               string line = sr.ReadLine();
               disable_25buttons();
               foreach (Control c in Controls)
               {
                    if (c is Button && !c.Enabled)
                    {
                         c.Text = line;
                         line = sr.ReadLine();
                         if (c.Text == "")
                              c.Enabled = true;
                    }//end if
               }//end foreach
               sr.Close();//close file
          }//end resume_Click
     }//end public partial class Form1
}//end logic
