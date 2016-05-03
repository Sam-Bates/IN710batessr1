using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class MovieDatabase
    {

        Dictionary<int, Movie> movieTable = new Dictionary<int, Movie>();

        public bool addMovie(int year, String title, String director)
        {
            Movie movie = new Movie(year, title, director);

            if (movieTable.ContainsKey(year))
            {
                return false;
            }
            else
            {
                movieTable.Add(movie.Year, movie);
                return true;
            }

        }
        public bool delMovie(int key)
        {
            if (movieTable.ContainsKey(key))
            {
                movieTable.Remove(key);
                return true;
            }
            return false;

        }
        public String search(int key)
        {
            foreach (KeyValuePair<int, Movie> currentMovie in movieTable)
            {
                if (currentMovie.Key == key)
                {
                    return currentMovie.ToString();
                }
            }
            return key + " not found.";
        }
        public String printAll()
        {
            if (movieTable.Count() != 0)
            {
                List<int> keys = new List<int>(movieTable.Keys);
                keys.Sort();

                foreach (int currKey in keys)
                {
                    Movie currMovie = movieTable[currKey];
                    finalString.Append("----------\n");
                    finalString.Append(currMovie.Year.ToString() + "\n");
                    finalString.Append(currMovie.ToString() + "\n");
                }

            }
            else
            {
                finalString.Append("Error: database is empty");
            }
            //return stringbuilder as string
            return finalString.ToString();
        }
    }
}
