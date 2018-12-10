using UnityEngine;
using System.Collections;

public class Score: MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ScorePoint")
        {
            PlayerManager.instance.BirdScored();
        }
    }
}
