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

    static void Main(string[] args)
    {
        User Rai = new User(1, "Rai", "Osborne", "RaiO", "07/02/01", 167);

        Console.WriteLine(Rai.firstName, Rai.lastName, Rai.username, Rai.birthDay);
    }


}