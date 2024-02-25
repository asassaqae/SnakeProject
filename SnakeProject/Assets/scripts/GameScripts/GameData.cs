using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    static int score;
    public static int applesRemaning;
    public static float secondsSinceLastSpawn;
    public static int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }


    public static void ShowScore()
    {
        Debug.Log("Score: " + Score);
    }
}
