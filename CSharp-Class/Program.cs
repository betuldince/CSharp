using System;

namespace YoutubeVideo{

    public class Program{

        public static void Main(string[] args){

            Human human = new Human("bet", "din",21);
            Human human1 = new ();
            Console.WriteLine(human.isValid());

            Player player = new Player("b","d",1,"64750");
            Console.WriteLine(player.PlayerID);

            player.IncreaseScore(100);
            Console.WriteLine(player.GetScore().Points);
            
            Score score=new Score();    
            Console.WriteLine(score.ToString());

            Monster monster=new Monster();
            
            Human HfromM=(Human) monster;

            Console.WriteLine(monster);

            // böyle olmuyor
           // Player HtoP = (Player) human;
            //HtoP.SetPlayerID(human.Firstname[0]+human.Lastname+"17");
            //Console.WriteLine(HtoP.PlayerID);

            Player HtoP = new Player(human1.Firstname,human1.Lastname,17,human.Firstname[0]+human.Lastname+"17");
            Console.WriteLine(HtoP.PlayerID);
        }

    }
}