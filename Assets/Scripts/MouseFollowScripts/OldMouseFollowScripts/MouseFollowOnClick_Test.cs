using UnityEngine;
using System.Collections;

public class MouseFollowOnClick_Test : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
            GetComponent<Rigidbody2D>().gravityScale = 0;
        }

        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }

    }

}


