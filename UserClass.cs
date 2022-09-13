using System;

public class User
{
    //field
    public int id;
    public string firstName;
    public string lastName;
    public string username;
    public enum EyeColor;
    public string birthDay;
    public int height;

    public User(int idNumber, string firstNameString, string lastNameString, string usernameString, string birthDayString, int heightNumber)
    {
        id = idNumber;
        firstName = firstNameString;
        lastName = lastNameString;
        username = usernameString;
        // eyeColor = "Hazel";
        birthDay = birthDayString;
        height = heightNumber;

    }

    
}
