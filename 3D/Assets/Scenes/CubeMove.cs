using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    int counter = 0;
    float move = 0.04f;

    // Update is called once per frame
    void Update()
    {
        Vector3 p = new Vector3(0, 0, move);
        transform.Translate(p);
        counter++;

        if(counter == 150)
        {
            counter = 0;
            move *= -1;
        }
    }
}
