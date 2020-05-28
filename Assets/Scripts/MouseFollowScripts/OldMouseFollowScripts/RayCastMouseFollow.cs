using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastMouseFollow : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            Collider2D hitCollider = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(pos));
            if (hitCollider != null && hitCollider.CompareTag("clickable"))
            {
                // Debug.Log("This is a clickable object");
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
}