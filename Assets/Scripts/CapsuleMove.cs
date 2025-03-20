using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class CapsuleMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float seed = 10;
    void Start()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * seed * Time.deltaTime);
;       }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * seed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * seed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * seed * Time.deltaTime);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
