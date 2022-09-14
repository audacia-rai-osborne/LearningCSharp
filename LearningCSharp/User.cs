using System;

public interface iUser
{
    int id
    {
        get;
        set;
    }

    string firstName
    {
        get;
        set;
    }

    string lastName
    {
        get;
        set;
    }

    string username
    {
        get;
        set;
    }

    int eyeColor
    {
        get;
        set;
}

string birthDay
    {
        get;
        set;
    }

    int height
    {
        get;
        set;
    }
    string createString();

}
