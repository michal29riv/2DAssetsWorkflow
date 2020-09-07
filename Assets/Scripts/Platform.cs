using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject platformSprite;

    public bool active = false;

    public float speed = 1;

    public Transform startPosition;

    public Transform targetPosition;

    private bool forwardDirection;

    private float currentPosition = 0;

    void Update()
    {
        if (active == true)
        {
            if (forwardDirection == true)
            {
                currentPosition += speed * Time.deltaTime;

                if (currentPosition > 1)
                {
                    currentPosition = 1;
                    forwardDirection = false;
                }
            }
            else
            {
                currentPosition -= speed * Time.deltaTime;

                if (currentPosition < 0)
                {
                    currentPosition = 0;
                    forwardDirection = true;
                }
            }

            platformSprite.transform.position = Vector3.Lerp(startPosition.position, targetPosition.position, currentPosition);
        }
    }

    public void SetPlatformState(bool state)
    {
        active = state;
    }
}
