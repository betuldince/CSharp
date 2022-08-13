using System;

namespace YoutubeVideo{

    public class Player:Human{
    //To set properties which are only avaiable with getter

    Score score = new Score();
    private string playerID;
    public string PlayerID{
        get{
        return playerID;
        }
    }
    public void SetPlayerID(string playerID){
        this.playerID=playerID;
    }
    public Player(string firstName, string lastname, int age,string playerID):base(firstName,lastname,age){
        this.playerID=playerID;
    }

    public Score GetScore(){
        return score;
    }

    public void IncreaseScore(int points){
        score.Points+=points;
    }

    
    }
}