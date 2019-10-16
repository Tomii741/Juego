using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private int x;
    private bool reset = false;
    GameManager gm = new GameManager();
    // Start is called before the first frame update
    void Start()
    {
        

        gameObject.transform.position = new Vector3(4, 0, 0);
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBall()
    {
        gameObject.transform.position = new Vector3(x, 0, 0);
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "GroundIzq")
        {
            gm.Reset();
            //Debug.Log("Pelota toca el piso izquierdo");
            x = 4;
        }
        if (collision.transform.tag == "GroundDer")
        {
            gm.Reset();
            //Debug.Log("Pelota toca el piso derecho");
            x = -4;
        }
    }
    
}
