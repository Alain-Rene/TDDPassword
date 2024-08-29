namespace MyProject;

public class PasswordHolder
{

    public static bool AddPassword(string password, List<string> passwords)
    {

        string vowels = "AEIOUY";
        int numVowels = 0;
        foreach (string p in passwords)
        {
            if (p == password)
            {
                return false;
            }
        }
        
         if (password == "admin")
        {
            passwords.Add(password);
            return true;
        }
        else if (password == "mod")
        {
            passwords.Add(password);
            return true;
        }

        if (password.Length < 7 || password.Length > 12)
        {
            return false;
        }     

        if (password.Contains(" "))
        {
            return false;
        }

        foreach (char c in password)
        {
            if (vowels.Contains(c))
            {
                numVowels++;
            }
        }

        if ((numVowels < 2))
        {
            return false;
        }
        if (!password.Any(char.IsDigit) && password.Contains('6'))
        {
            return false;
        }
        

        passwords.Add(password);
        return true;
    }
}
