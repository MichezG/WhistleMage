using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ParticleLauncher : MonoBehaviour
{
    public ParticleSystem particleLauncher;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Cursor.visible)
        {
            particleLauncher.Emit(5);
        }

    } 
}
