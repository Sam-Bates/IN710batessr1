using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNight
{
    public class Scorer
    {
        public static int AdultScore(int correct, int incorrect)
        {
            int score = 0;
            score = (correct * 10) - (incorrect * 1);
            return score;
        }
        public static int ChildScore(int correct, int incorrect)
        {
            int score = 0;
            score = (correct * 15);
            return score;
        }
    }
}
