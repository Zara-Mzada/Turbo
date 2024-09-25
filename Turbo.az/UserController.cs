using System.Collections;

namespace Turbo.az;

public class UserController
{
    public ArrayList Users { get; set; }

    public UserController()
    {
        Users = new ArrayList();
    }

    public bool SignIn(string email, string password)
    {
        foreach (User user in Users)
        {
            if (email == user.email && password == user.password)
            {
                return true;
            }
        }
        return false;
    }

    public void ShowUser()
    {
        int id = 1;
        foreach (User user in Users)
        {
            Console.WriteLine("============================\n" +
                              $"User id: {id}" +
                              $"Name: {user.name}\n" +
                              $"Surname: {user.surname}\n" +
                              $"Email: {user.email}\n" +
                              $"Password: {user.password}\n" +
                              $"============================");
            id++;
        }
    }

    public void SignUp(User user)
    {
        Users.Add(user);
    }
}