using UnityEngine;
using System.Collections;

public class PillarColorChange : MonoBehaviour
{
    public bool red = true;
    public bool blue = false;
    public bool green = false;
    public bool yellow = false;

    public float timeLeft;

    enum AllColors { red, green, blue, yellow, };

    void Start()
    {

        AllColors myColors = (AllColors)Random.Range(0, 4);
        Renderer rend = GetComponent<Renderer>();
        switch (myColors)
        {
            case AllColors.red:
                print("color: " + myColors);
                rend.material.color = Color.red;
                red = true;
                blue = false;
                green = false;
                yellow = false;
                break;
            case AllColors.green:
                print("color: " + myColors);
                rend.material.color = Color.green;
                red = false;
                blue = false;
                green = true;
                yellow = false;
                break;
            case AllColors.blue:
                print("color: " + myColors);
                rend.material.color = Color.blue;
                red = false;
                blue = true;
                green = false;
                yellow = false;
                break;
            case AllColors.yellow:
                print("color: " + myColors);
                rend.material.color = Color.yellow;
                red = false;
                blue = false;
                green = false;
                yellow = true;
                break;
            default:
                print("color: " + myColors);
                rend.material.color = Color.red;
                red = true;
                blue = false;
                green = false;
                yellow = false;
                break;
        }

    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "Player")
        {

            //TRUE
            if (red == true && GameObject.Find("Player").GetComponent<ColorChange>().playerRed)
            {
                Destroy(gameObject);
            }

            if (green == true && GameObject.Find("Player").GetComponent<ColorChange>().playerGreen)
            {
                Destroy(gameObject);
            }

            if (yellow == true && GameObject.Find("Player").GetComponent<ColorChange>().playerYellow)
            {
                Destroy(gameObject);
            }

            if (blue == true && GameObject.Find("Player").GetComponent<ColorChange>().playerBlue)
            {
                Destroy(gameObject);
            }

            //NOT TRUE
            if (red == false && GameObject.Find("Player").GetComponent<ColorChange>().playerRed)
            {
                Application.LoadLevel(0);
            }

            if (green == false && GameObject.Find("Player").GetComponent<ColorChange>().playerGreen)
            {
                Application.LoadLevel(0);
            }

            if (yellow == false && GameObject.Find("Player").GetComponent<ColorChange>().playerYellow)
            {
                Application.LoadLevel(0);
            }

            if (blue == false && GameObject.Find("Player").GetComponent<ColorChange>().playerBlue)
            {
                Application.LoadLevel(0);
            }


        }
    }
}
