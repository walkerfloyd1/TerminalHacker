using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu ()
    {

        Terminal.ClearScreen();
        Terminal.WriteLine("Choose!");
        Terminal.WriteLine("1 - Blockbusters (easy)");
        Terminal.WriteLine("2 - Oscar Films (medium)");
        Terminal.WriteLine("3 - Indie Films (hard)");
        Terminal.WriteLine("Enter your selection:");
    }

    int level;

    void OnUserInput (string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please make a selection, Mr. Bond");
        }
        else if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
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
    }
}
