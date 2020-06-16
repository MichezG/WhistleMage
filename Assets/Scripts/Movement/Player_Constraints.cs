using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Player_Constraints : MonoBehaviour
{

    public Rigidbody2D _RGB;
 
    // Start is called before the first frame update
    void Awake()
    {
        _RGB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
             _RGB.constraints = RigidbodyConstraints2D.FreezeAll;
            //Debug.Log("Player Cant Move!");
        }

        else
        {
            _RGB.constraints = RigidbodyConstraints2D.None;
            //Debug.Log("Player Can Move!");
        }
    }
}
