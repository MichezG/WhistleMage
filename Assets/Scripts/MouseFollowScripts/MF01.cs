using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MF01 : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 1f;
    
    // Start is called before the first frame update
    private void Start()
    {

    }

    void OnMouseDrag()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }
}
