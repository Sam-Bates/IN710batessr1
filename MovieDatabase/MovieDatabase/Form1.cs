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
            int year = Convert.ToInt16(txtAddYear.Text);
            String title = Convert.ToString(txtAddTitle.Text);
            String director = Convert.ToString(txtAddDirector.Text);
            movieDatabase.addMovie(year, title, director);
            txtAddYear.Clear();
            txtAddTitle.Clear();
            txtAddDirector.Clear();
        }
        private void deleteMovie_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt16(txtDelYear.Text);
            movieDatabase.delMovie(key);
        }

        private void search_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt16(txtSearchYear.Text);
            String str = movieDatabase.search(key);
            richTextBox1.Clear();
            richTextBox1.AppendText(str);
        }

        private void printAll_Click(object sender, EventArgs e)
        {
            String a = movieDatabase.printAll();
            richTextBox1.Clear();
            richTextBox1.AppendText(a);
        }

    }
}
