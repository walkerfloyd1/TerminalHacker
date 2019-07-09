using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("What's Up Bitch");
    }

    void ShowMainMenu (string greeting)
    {

        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Choose!");
        Terminal.WriteLine("1 - Blockbusters (easy)");
        Terminal.WriteLine("2 - Oscar Films (medium)");
        Terminal.WriteLine("3 - Indie Films (hard)");
        Terminal.WriteLine("Enter your selection:");
    }
    void OnUserInput (string input)
    {
        print(input);
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
