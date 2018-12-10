using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float moveSpeed = 10f;

    private Rigidbody2D theRigidbody;

    void Start () {
        theRigidbody = GetComponent<Rigidbody2D>();
    }
	

	void Update () {
        transform.Translate(new Vector2(1, 0) * moveSpeed * Time.deltaTime);
    }

    void Colorchange()
    {
        if (Input.GetKeyDown("r"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
            

    }
}

