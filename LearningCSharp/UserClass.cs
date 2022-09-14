using System;

public class User : iUser
{
    //field
    public int id
    {
        get;
        set;
    }
    public string firstName
    {
        get;
        set;
    }
    public string lastName
    {
        get;
        set;
    }
    public string username
    {
        get;
        set;
    }
    public int eyeColor
    {
        get;
        set;
}
public string birthDay
    {
        get;
        set;
    }
    public int height
    {
        get;
        set;
    }

    public User(int idNumber, string firstNameString, string lastNameString, string usernameString, string birthDayString, int heightNumber)
    {
        id = idNumber;
        firstName = firstNameString;
        lastName = lastNameString;
        username = usernameString;
        // eyeColor = eyeColorEnum;
        birthDay = birthDayString;
        height = heightNumber;

    }


        public string createString(){
            return this.id + " " + this.firstName + " " + this.lastName + " " + this.username + " " + this.birthDay + " " + this.eyeColor + " " + this.height;
        }
    


}