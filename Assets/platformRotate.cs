using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward, 40 * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(-Vector3.forward, 20 * Time.deltaTime);
            } 
        }
    }
}

