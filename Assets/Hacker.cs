using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game configuration data

    string[] level1Passwords = {"avatar", "aladdin", "hook", "frozen", "rambo"};
    string[] level2Passwords = { "push", "crash", "roma", "casablanca", "whiplash"};
    string[] level3Passwords = { "primer", "brick", "gummo", "eraserhead", "cronos" };

    // Start is called before the first frame update
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;

    void Start()
    {
        ShowMainMenu();
    }
    void ShowMainMenu ()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Choose!");
        Terminal.WriteLine("1 - Blockbusters (easy)");
        Terminal.WriteLine("2 - Oscar Films (medium)");
        Terminal.WriteLine("3 - Indie Films (hard)");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput (string input)
    {
        if (input == "menu") // can always go direct to main menu
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }


    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }

        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame()
    {
        print(level1Passwords.Length);
        print(level2Passwords.Length);
        print(level3Passwords.Length);

        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch(level)
        {
            case 1:
                
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                print(password);
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level1Passwords.Length)];
                print(password);
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level1Passwords.Length)];
                print(password);
                break;
            default:
                Debug.LogError("Invalid Level Number");
                break;
        }
        Terminal.WriteLine("Please enter your password");
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.WriteLine("Wrong Password!");
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Grab Some Popcorn!");
                break;
            case 2:
                Terminal.WriteLine("Grab Some Awards!");
                break;
            case 3:
                Terminal.WriteLine("Grab Some Artisanal Beer!");
                break;
        }
        
    }
}
