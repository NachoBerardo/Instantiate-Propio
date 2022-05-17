using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Vector3 Movement;

    void Update()
    {
        //transform.position += Movement;   sube
        //transform.localScale += Movement;  se escala
        //transform.eulerAngles += Movement;  rota

        //transform.position += Movement;
        //transform.eulerAngles += Movement * 10; (rota y sube)

        if (transform.position.y < 5.5)
        {
            transform.position += Movement;
        }

        //if (transform.eulerAngles.y < 160)
        //{
        //    transform.position += Movement;
        //} (gira hasta 160)
        
    }
}
