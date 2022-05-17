using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V3 : MonoBehaviour
{
    public Vector3 MyVector3;
    public GameObject MyObject;

    // Start is called before the first frame update
    void Start()
    {
        //MyObject.transform.position = MyVector3; (para posición)
        //MyObject.transform.localScale = MyVector3; (para escala)
        MyObject.transform.eulerAngles = MyVector3; // (para rotar)

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
