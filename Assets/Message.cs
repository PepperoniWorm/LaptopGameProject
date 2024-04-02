using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStatus
{
    none,
    inText,
}

public class Message : MonoBehaviour
{
    GameStatus status;

    void Update()
    {
        if((status == GameStatus.inText))
        {
            if (GetMouseButtonDown(0))
            {
                status = GameStatus.none;
            }
        }
    }

    public void Message(Text text, string message)
    {

        text.text = message;
        status = GameStatus.inText;
    }

    public void 
    

    
}
