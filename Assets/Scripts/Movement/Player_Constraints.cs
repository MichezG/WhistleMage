using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Player_Constraints : MonoBehaviour
{

    public Rigidbody2D _RGB;
    bool onOff;
 
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
            if(onOff == false)
            {
                _RGB.constraints = RigidbodyConstraints2D.FreezeAll;
                onOff = true;

            //Debug.Log("Player Cant Move!");
            }
        }

        else if (onOff == true)
        {
            _RGB.constraints = RigidbodyConstraints2D.None;
            onOff = false;
            //Debug.Log("Player Can Move!");
        }
    }
}
