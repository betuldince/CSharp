using System;

namespace YoutubeVideo{

    public class Human{
    
    #region Fields
    private string firstName;
    private string lastname;
    private int age;
    protected bool hands=true;
    #endregion
    #region Properties
    public string Firstname{
        get{
            return firstName;
        }
    }

    public string Lastname{
        get{
            return lastname;
        }
    }

    public string FullName{
        get{
            return firstName + " " + lastname;
        }
    }

#endregion
    #region constructors
    public Human(){}

    public Human(string firstName, string lastname, int age){

        this.firstName=firstName;
        this.lastname=lastname;
        this.age=age;
    }
    #endregion

        public override string ToString()
        {
            return firstName+" "+lastname+" "+age+" "+hands;
        }

        public bool isValid(){
        if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastname))
            return false;
        return true;
        }

        public bool isAdult(){
            return age>=18;
        }


    }

}
