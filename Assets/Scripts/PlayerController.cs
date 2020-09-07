using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnimator;

    Rigidbody2D playerRigidbody;

    public Transform raycast1;

    public Transform raycast2;

    public Transform raycast3;

    public float speed = 1;

    public float jump = 1;

    float playerMovement = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            GoLeft();
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            GoRight();
        }

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Jump();
        }
    }

    private void LateUpdate()
    {
        playerRigidbody.velocity = new Vector2(playerMovement, playerRigidbody.velocity.y);

        playerMovement = 0;

        playerAnimator.SetBool("isRunning", false);
    }

    public void Jump()
    {
        RaycastHit2D hit1 = Physics2D.Raycast(raycast1.position, -Vector2.up, 0.2f);

        RaycastHit2D hit2 = Physics2D.Raycast(raycast2.position, -Vector2.up, 0.2f);

        RaycastHit2D hit3 = Physics2D.Raycast(raycast3.position, -Vector2.up, 0.2f);

        if (hit1.collider != null || hit2.collider != null || hit3.collider != null)
        {
            playerRigidbody.AddForce(Vector2.up * jump);
        }
    }

    public void GoLeft()
    {
        playerMovement = -speed;

        transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);

        playerAnimator.SetBool("isRunning", true);
    }

    public void GoRight()
    {
        playerMovement = speed;

        playerRigidbody.velocity = new Vector2(playerMovement, playerRigidbody.velocity.y);

        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);

        playerAnimator.SetBool("isRunning", true);
    }
}
