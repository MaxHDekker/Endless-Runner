using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour
{
    public bool playerRed = false;
    public bool playerBlue = false;
    public bool playerGreen = false;
    public bool playerYellow = false;

    void Update()   
    {
        Renderer rend = GetComponent<Renderer>();

        //red
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            rend.material.color = Color.red;
            playerRed = true;
            playerBlue = false;
            playerGreen = false;
            playerYellow = false;
        }
        //green
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            rend.material.color = Color.green;
            playerRed = false;
            playerBlue = false;
            playerGreen = true;
            playerYellow = false;
        }
        //yellow
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            rend.material.color = Color.yellow;
            playerRed = false;
            playerBlue = false;
            playerGreen = false;
            playerYellow = true;
        }
        //blue
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            rend.material.color = Color.blue;
            playerRed = false;
            playerBlue = true;
            playerGreen = false;
            playerYellow = false;
        }
    }

   
}
