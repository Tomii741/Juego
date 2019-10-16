using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerL : MonoBehaviour
{

    bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-5, -4, 0);
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-600f * Time.deltaTime, 0));
        }
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(600f * Time.deltaTime, 0));
        }
        if (Input.GetKey("w") && canJump)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 290f));
            canJump = false;
        }
    }

    public void ResetPlayerL()
    {
        gameObject.transform.position = new Vector3(-5, -4, 0);
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "GroundIzq")
        {
            canJump = true;
        }
    }
}
