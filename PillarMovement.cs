using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMovement : MonoBehaviour {

    public float pillarSpeed;

    private void Update()
    {
        transform.Translate(new Vector2(1, 0) * pillarSpeed * Time.deltaTime);
    }
}
