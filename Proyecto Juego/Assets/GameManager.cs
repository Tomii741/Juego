using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Ball ball;
    public PlayerL playerL;
    public PlayerR playerR;

    public bool resetGM;

    // Start is called before the first frame update
    void Start()
    {
        //Crear pelota
        Instantiate (ball);
        //Crear dos jugadores
        Instantiate (playerL);
        Instantiate (playerR);
    }

    public void Reset()
    {
        resetGM = true;
    }
    private void Update()
    {
        Debug.Log(resetGM);
        if(resetGM == true)
        {
            Debug.Log("La pelota toca el piso");
            ball.ResetBall();
            playerL.ResetPlayerL();
            playerR.ResetPlayerR();
        }
    }

}
