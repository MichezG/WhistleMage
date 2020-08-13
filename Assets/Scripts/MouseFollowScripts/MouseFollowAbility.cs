using System.Collections;
using UnityEngine;

public class MouseFollowAbility : MonoBehaviour
{
    Vector2 difference = Vector2.zero;

    public float controlTime = 10f;
    private IEnumerator coroutine;
    public bool coroutineRunning;


    void Start()
    {
        coroutineRunning = false;
    }

     void OnMouseDown()
    {
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;

        if (!coroutineRunning)
        {
            coroutine = DropObjectAfter(controlTime);
            StartCoroutine(coroutine);
            Debug.Log("Start coroutine object under control");
        }
    }

    IEnumerator DropObjectAfter(float controlTime)
    {
        coroutineRunning = true;
        yield return new WaitForSeconds(controlTime);
        Debug.Log("Object is not under control anymore" + Time.time);
    }

    private void OnMouseUp() 
    {
        //Cursor.visible = (false);
    }
}
