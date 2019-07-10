using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
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
        if (input == "007")
        {
            Terminal.WriteLine("Please make a selection, Mr. Bond");
        }
        else if (input == "1")
        {
            level = 1;
            password = "a";
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = "b";
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = "c";
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password");
        currentScreen = Screen.Password;
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Good Job!");
        }
        else
        {
            Terminal.WriteLine("Wrong Password!");
        }
    }
}
