//========================== INTERFACE ===============================
//Author:                   Thomas Tran
//Author's email:           trangiadat86@gmail.com
//Course:                   CPSC223N
//Assignment number:        Assignment 3
//Due date:                 Mar 16, 2015
//========================== INTERFACE ===============================
namespace tictactoe
{
     partial class Form1
     {
          /// Required designer variable.
          private System.ComponentModel.IContainer components = null;
          /// Clean up any resources being used.
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          private void InitializeComponent()
          {
               this.Title = new System.Windows.Forms.Label();
               this.a1 = new System.Windows.Forms.Button();
               this.a4 = new System.Windows.Forms.Button();
               this.a3 = new System.Windows.Forms.Button();
               this.a2 = new System.Windows.Forms.Button();
               this.b1 = new System.Windows.Forms.Button();
               this.b4 = new System.Windows.Forms.Button();
               this.b3 = new System.Windows.Forms.Button();
               this.b2 = new System.Windows.Forms.Button();
               this.a5 = new System.Windows.Forms.Button();
               this.b5 = new System.Windows.Forms.Button();
               this.c1 = new System.Windows.Forms.Button();
               this.c2 = new System.Windows.Forms.Button();
               this.c3 = new System.Windows.Forms.Button();
               this.c4 = new System.Windows.Forms.Button();
               this.c5 = new System.Windows.Forms.Button();
               this.d3 = new System.Windows.Forms.Button();
               this.d2 = new System.Windows.Forms.Button();
               this.d1 = new System.Windows.Forms.Button();
               this.d5 = new System.Windows.Forms.Button();
               this.d4 = new System.Windows.Forms.Button();
               this.e3 = new System.Windows.Forms.Button();
               this.e2 = new System.Windows.Forms.Button();
               this.e1 = new System.Windows.Forms.Button();
               this.e5 = new System.Windows.Forms.Button();
               this.e4 = new System.Windows.Forms.Button();
               this.outputStarter = new System.Windows.Forms.Label();
               this.save = new System.Windows.Forms.Button();
               this.person = new System.Windows.Forms.RadioButton();
               this.computer = new System.Windows.Forms.RadioButton();
               this.resume = new System.Windows.Forms.Button();
               this.winner = new System.Windows.Forms.Label();
               this.outputWinner = new System.Windows.Forms.Label();
               this.newGame = new System.Windows.Forms.Button();
               this.exit = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // Title
               // 
               this.Title.AutoSize = true;
               this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Title.Location = new System.Drawing.Point(145, 9);
               this.Title.Name = "Title";
               this.Title.Size = new System.Drawing.Size(123, 24);
               this.Title.TabIndex = 0;
               this.Title.Text = "Tic Tac Toe";
               // 
               // a1
               // 
               this.a1.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.a1.Location = new System.Drawing.Point(80, 50);
               this.a1.Name = "a1";
               this.a1.Size = new System.Drawing.Size(50, 50);
               this.a1.Click += new System.EventHandler(this.Square_Click);
               // 
               // a4
               // 
               this.a4.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.a4.Location = new System.Drawing.Point(230, 50);
               this.a4.Name = "a4";
               this.a4.Size = new System.Drawing.Size(50, 50);
               this.a4.Click += new System.EventHandler(this.Square_Click);
               // 
               // a3
               // 
               this.a3.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.a3.Location = new System.Drawing.Point(180, 50);
               this.a3.Name = "a3";
               this.a3.Size = new System.Drawing.Size(50, 50);
               this.a3.Click += new System.EventHandler(this.Square_Click);
               // 
               // a2
               // 
               this.a2.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.a2.Location = new System.Drawing.Point(130, 50);
               this.a2.Name = "a2";
               this.a2.Size = new System.Drawing.Size(50, 50);
               this.a2.Click += new System.EventHandler(this.Square_Click);
               // 
               // b1
               // 
               this.b1.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.b1.Location = new System.Drawing.Point(80, 100);
               this.b1.Name = "b1";
               this.b1.Size = new System.Drawing.Size(50, 50);
               this.b1.Click += new System.EventHandler(this.Square_Click);
               // 
               // b4
               // 
               this.b4.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.b4.Location = new System.Drawing.Point(230, 100);
               this.b4.Name = "b4";
               this.b4.Size = new System.Drawing.Size(50, 50);
               this.b4.Click += new System.EventHandler(this.Square_Click);
               // 
               // b3
               // 
               this.b3.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.b3.Location = new System.Drawing.Point(180, 100);
               this.b3.Name = "b3";
               this.b3.Size = new System.Drawing.Size(50, 50);
               this.b3.Click += new System.EventHandler(this.Square_Click);
               // 
               // b2
               // 
               this.b2.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.b2.Location = new System.Drawing.Point(130, 100);
               this.b2.Name = "b2";
               this.b2.Size = new System.Drawing.Size(50, 50);
               this.b2.Click += new System.EventHandler(this.Square_Click);
               // 
               // a5
               // 
               this.a5.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.a5.Location = new System.Drawing.Point(280, 50);
               this.a5.Name = "a5";
               this.a5.Size = new System.Drawing.Size(50, 50);
               this.a5.Click += new System.EventHandler(this.Square_Click);
               // 
               // b5
               // 
               this.b5.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.b5.Location = new System.Drawing.Point(280, 100);
               this.b5.Name = "b5";
               this.b5.Size = new System.Drawing.Size(50, 50);
               this.b5.Click += new System.EventHandler(this.Square_Click);
               // 
               // c1
               // 
               this.c1.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.c1.Location = new System.Drawing.Point(80, 150);
               this.c1.Name = "c1";
               this.c1.Size = new System.Drawing.Size(50, 50);
               this.c1.Click += new System.EventHandler(this.Square_Click);
               // 
               // c2
               // 
               this.c2.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.c2.Location = new System.Drawing.Point(130, 150);
               this.c2.Name = "c2";
               this.c2.Size = new System.Drawing.Size(50, 50);
               this.c2.Click += new System.EventHandler(this.Square_Click);
               // 
               // c3
               // 
               this.c3.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.c3.Location = new System.Drawing.Point(180, 150);
               this.c3.Name = "c3";
               this.c3.Size = new System.Drawing.Size(50, 50);
               this.c3.Click += new System.EventHandler(this.Square_Click);
               // 
               // c4
               // 
               this.c4.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.c4.Location = new System.Drawing.Point(230, 150);
               this.c4.Name = "c4";
               this.c4.Size = new System.Drawing.Size(50, 50);
               this.c4.Click += new System.EventHandler(this.Square_Click);
               // 
               // c5
               // 
               this.c5.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.c5.Location = new System.Drawing.Point(280, 150);
               this.c5.Name = "c5";
               this.c5.Size = new System.Drawing.Size(50, 50);
               this.c5.Click += new System.EventHandler(this.Square_Click);
               // 
               // d3
               // 
               this.d3.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.d3.Location = new System.Drawing.Point(180, 200);
               this.d3.Name = "d3";
               this.d3.Size = new System.Drawing.Size(50, 50);
               this.d3.Click += new System.EventHandler(this.Square_Click);
               // 
               // d2
               // 
               this.d2.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.d2.Location = new System.Drawing.Point(130, 200);
               this.d2.Name = "d2";
               this.d2.Size = new System.Drawing.Size(50, 50);
               this.d2.Click += new System.EventHandler(this.Square_Click);
               // 
               // d1
               // 
               this.d1.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.d1.Location = new System.Drawing.Point(80, 200);
               this.d1.Name = "d1";
               this.d1.Size = new System.Drawing.Size(50, 50);
               this.d1.Click += new System.EventHandler(this.Square_Click);
               // 
               // d5
               // 
               this.d5.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.d5.Location = new System.Drawing.Point(280, 200);
               this.d5.Name = "d5";
               this.d5.Size = new System.Drawing.Size(50, 50);
               this.d5.Click += new System.EventHandler(this.Square_Click);
               // 
               // d4
               // 
               this.d4.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.d4.Location = new System.Drawing.Point(230, 200);
               this.d4.Name = "d4";
               this.d4.Size = new System.Drawing.Size(50, 50);
               this.d4.Click += new System.EventHandler(this.Square_Click);
               // 
               // e3
               // 
               this.e3.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.e3.Location = new System.Drawing.Point(180, 250);
               this.e3.Name = "e3";
               this.e3.Size = new System.Drawing.Size(50, 50);
               this.e3.Click += new System.EventHandler(this.Square_Click);
               // 
               // e2
               // 
               this.e2.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.e2.Location = new System.Drawing.Point(130, 250);
               this.e2.Name = "e2";
               this.e2.Size = new System.Drawing.Size(50, 50);
               this.e2.Click += new System.EventHandler(this.Square_Click);
               // 
               // e1
               // 
               this.e1.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.e1.Location = new System.Drawing.Point(80, 250);
               this.e1.Name = "e1";
               this.e1.Size = new System.Drawing.Size(50, 50);
               this.e1.Click += new System.EventHandler(this.Square_Click);
               // 
               // e5
               // 
               this.e5.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.e5.Location = new System.Drawing.Point(280, 250);
               this.e5.Name = "e5";
               this.e5.Size = new System.Drawing.Size(50, 50);
               this.e5.Click += new System.EventHandler(this.Square_Click);
               // 
               // e4
               // 
               this.e4.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.e4.Location = new System.Drawing.Point(230, 250);
               this.e4.Name = "e4";
               this.e4.Size = new System.Drawing.Size(50, 50);
               this.e4.Click += new System.EventHandler(this.Square_Click);
               // 
               // outputStarter
               // 
               this.outputStarter.Location = new System.Drawing.Point(155, 303);
               this.outputStarter.Name = "outputStarter";
               this.outputStarter.Size = new System.Drawing.Size(100, 20);
               this.outputStarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // save
               // 
               this.save.Location = new System.Drawing.Point(30, 330);
               this.save.Name = "save";
               this.save.Size = new System.Drawing.Size(75, 23);
               this.save.Text = "Save";
               this.save.UseVisualStyleBackColor = true;
               this.save.Click += new System.EventHandler(this.save_Click);
               // 
               // person
               // 
               this.person.Location = new System.Drawing.Point(130, 330);
               this.person.Name = "person";
               this.person.Size = new System.Drawing.Size(75, 23);
               this.person.TabStop = true;
               this.person.Text = "Person";
               this.person.UseVisualStyleBackColor = true;
               this.person.CheckedChanged += new System.EventHandler(this.person_CheckedChanged);
               // 
               // computer
               // 
               this.computer.Location = new System.Drawing.Point(210, 330);
               this.computer.Name = "computer";
               this.computer.Size = new System.Drawing.Size(75, 23);
               this.computer.TabStop = true;
               this.computer.Text = "Computer";
               this.computer.UseVisualStyleBackColor = true;
               this.computer.CheckedChanged += new System.EventHandler(this.computer_CheckedChanged);
               // 
               // resume
               // 
               this.resume.Location = new System.Drawing.Point(300, 330);
               this.resume.Name = "resume";
               this.resume.Size = new System.Drawing.Size(75, 23);
               this.resume.Text = "Resume";
               this.resume.UseVisualStyleBackColor = true;
               this.resume.Click += new System.EventHandler(this.resume_Click);
               // 
               // winner
               // 
               this.winner.Location = new System.Drawing.Point(40, 365);
               this.winner.Name = "winner";
               this.winner.Size = new System.Drawing.Size(50, 20);
               this.winner.Text = "Winner";
               // 
               // outputWinner
               // 
               this.outputWinner.Location = new System.Drawing.Point(95, 365);
               this.outputWinner.Name = "outputWinner";
               this.outputWinner.Size = new System.Drawing.Size(70, 20);
               // 
               // newGame
               // 
               this.newGame.Location = new System.Drawing.Point(210, 365);
               this.newGame.Name = "newGame";
               this.newGame.Size = new System.Drawing.Size(75, 23);
               this.newGame.Text = "New Game";
               this.newGame.UseVisualStyleBackColor = true;
               this.newGame.Click += new System.EventHandler(this.newGame_Click);
               // 
               // exit
               // 
               this.exit.Location = new System.Drawing.Point(300, 365);
               this.exit.Name = "exit";
               this.exit.Size = new System.Drawing.Size(75, 23);
               this.exit.Text = "Exit";
               this.exit.UseVisualStyleBackColor = true;
               this.exit.Click += new System.EventHandler(this.exit_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(434, 412);
               this.Controls.Add(this.exit);
               this.Controls.Add(this.newGame);
               this.Controls.Add(this.outputWinner);
               this.Controls.Add(this.winner);
               this.Controls.Add(this.resume);
               this.Controls.Add(this.computer);
               this.Controls.Add(this.person);
               this.Controls.Add(this.save);
               this.Controls.Add(this.outputStarter);
               this.Controls.Add(this.e4);
               this.Controls.Add(this.e5);
               this.Controls.Add(this.e1);
               this.Controls.Add(this.e2);
               this.Controls.Add(this.e3);
               this.Controls.Add(this.d4);
               this.Controls.Add(this.d5);
               this.Controls.Add(this.d1);
               this.Controls.Add(this.d2);
               this.Controls.Add(this.d3);
               this.Controls.Add(this.c5);
               this.Controls.Add(this.c4);
               this.Controls.Add(this.c3);
               this.Controls.Add(this.c2);
               this.Controls.Add(this.c1);
               this.Controls.Add(this.b5);
               this.Controls.Add(this.a5);
               this.Controls.Add(this.b2);
               this.Controls.Add(this.b3);
               this.Controls.Add(this.b4);
               this.Controls.Add(this.b1);
               this.Controls.Add(this.a2);
               this.Controls.Add(this.a3);
               this.Controls.Add(this.a4);
               this.Controls.Add(this.a1);
               this.Controls.Add(this.Title);
               this.Name = "Form1";
               this.Text = "Form1";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label Title;
          private System.Windows.Forms.Button a1;
          private System.Windows.Forms.Button a4;
          private System.Windows.Forms.Button a3;
          private System.Windows.Forms.Button a2;
          private System.Windows.Forms.Button b1;
          private System.Windows.Forms.Button b4;
          private System.Windows.Forms.Button b3;
          private System.Windows.Forms.Button b2;
          private System.Windows.Forms.Button a5;
          private System.Windows.Forms.Button b5;
          private System.Windows.Forms.Button c1;
          private System.Windows.Forms.Button c2;
          private System.Windows.Forms.Button c3;
          private System.Windows.Forms.Button c4;
          private System.Windows.Forms.Button c5;
          private System.Windows.Forms.Button d3;
          private System.Windows.Forms.Button d2;
          private System.Windows.Forms.Button d1;
          private System.Windows.Forms.Button d5;
          private System.Windows.Forms.Button d4;
          private System.Windows.Forms.Button e3;
          private System.Windows.Forms.Button e2;
          private System.Windows.Forms.Button e1;
          private System.Windows.Forms.Button e5;
          private System.Windows.Forms.Button e4;
          private System.Windows.Forms.Label outputStarter;
          private System.Windows.Forms.Button save;
          private System.Windows.Forms.RadioButton person;
          private System.Windows.Forms.RadioButton computer;
          private System.Windows.Forms.Button resume;
          private System.Windows.Forms.Label winner;
          private System.Windows.Forms.Label outputWinner;
          private System.Windows.Forms.Button newGame;
          private System.Windows.Forms.Button exit;
     }
}

