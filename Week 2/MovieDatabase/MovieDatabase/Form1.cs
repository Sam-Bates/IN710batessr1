using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase
{
    public partial class Form1 : Form
    {
        MovieDatabase movieDatabase;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            movieDatabase = new MovieDatabase();

            movieDatabase.addMovie(Convert.ToInt16("1961"), "West SideStory", "Jerome Robbins");
            movieDatabase.addMovie(Convert.ToInt16("1972"), "The Godfather", "Francis Ford Coppola");
            movieDatabase.addMovie(Convert.ToInt16("1984"), "Amadeus", "Milos Forman");
            movieDatabase.addMovie(Convert.ToInt16("2007"), "No Country for Old Men", "Ethan & Joel Coen");
        }
        private void addMovie_Click(object sender, EventArgs e)
        {
            int year = 0;
            String title = "";
            String director = "";
            try
            {
                year = Convert.ToInt16(txtAddYear.Text);
                title = Convert.ToString(txtAddTitle.Text);
                director = Convert.ToString(txtAddDirector.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error in formatting");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid number");
            }

            if (year >= 0)
            {
                if ( title == "" || director == "")
                {
                    MessageBox.Show("Please fill out all of the text boxes");
                }
                else
                {
                    
                    if (movieDatabase.addMovie(year, title, director) == true)
                    {
                        MessageBox.Show(title + " has been added to the database");
                    }
                    else
                    {
                        MessageBox.Show(year + " already has an entry");
                    }

                    txtAddYear.Clear();
                    txtAddTitle.Clear();
                    txtAddDirector.Clear();
                }

            }
            else
            {
                MessageBox.Show("Positive numbers only");
            }

        }
        private void deleteMovie_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt16(txtDelYear.Text);
                if (movieDatabase.delMovie(key))
                {
                    MessageBox.Show(key + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Error can't find value");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error can't find value");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid entry");
            }
            txtDelYear.Clear();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt16(txtSearchYear.Text);
                String str = movieDatabase.search(key);
                richTextBox1.Clear();
                richTextBox1.AppendText(str);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error Can't find value");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Invalid number");
            }
            
            
        }

        private void printAll_Click(object sender, EventArgs e)
        {
            String a = movieDatabase.printAll();
            richTextBox1.Clear();
            richTextBox1.AppendText(a);
        }

    }
}
