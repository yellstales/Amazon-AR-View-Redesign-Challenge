using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDMovement : MonoBehaviour
{
    private Vector2 initialTouchPosition;
    private Vector2 currentTouchPosition;
    private bool isTouching = false;
    public float speed = 5f;
    public GameObject icon;

    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                isTouching = true;
                initialTouchPosition = touch.position;
            }

            if (touch.phase == TouchPhase.Moved && isTouching)
            {
                currentTouchPosition = touch.position;

                float touchDeltaY = currentTouchPosition.y - initialTouchPosition.y;

                transform.Translate(0, touchDeltaY*speed*Time.deltaTime, 0);
                icon.transform.Translate(0, touchDeltaY * speed * Time.deltaTime, 0);


                initialTouchPosition = currentTouchPosition;
            }

            if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                isTouching = false;
            }
        }
    }
}
