using System;

namespace YoutubeVideo{

    public class Score{

    private int points;

    public int Points { get => points; set => points = value; }

        public override string ToString()
        {
            return " "+points;
        }
    }
    
    }