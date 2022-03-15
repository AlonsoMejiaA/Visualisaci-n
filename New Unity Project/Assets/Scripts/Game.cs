using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

       public float timesPlayed, likes;
       public int GameType;
       
    public void isaac()
    {
        timesPlayed = 25f;
        likes = 8f;
        GameType = 5;
    }
    public void STS()
    {
        timesPlayed = 7;
        likes = 2;
        GameType = 5;
    }
}
