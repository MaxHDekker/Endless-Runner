using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    //public float moveSpeed = 10f;
    public float jumpSpeed;

    private Rigidbody2D theRigidbody;

    void Start()
    {
        theRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.D))
          //  transform.Translate(new Vector2(1, 0) * moveSpeed * Time.deltaTime);

       // if (Input.GetKey(KeyCode.A))
        //    transform.Translate(new Vector2(-1, 0) * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            theRigidbody.velocity = new Vector2(theRigidbody.velocity.x, jumpSpeed);

        }
    }
}