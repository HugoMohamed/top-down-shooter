using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Movement speed of the player")]
    public float movementSpeed = 5;
    [Tooltip("Sensitivity applied to inputs")]
    public float sensitivity = 10.0f;

    private float h;
    private float v;
    private bool isMoving;
    private float horizontalMove;
    private float verticalMove;
    private new Rigidbody2D rigidbody2D;
    private float controllY;
    private float mouseY;
    private float inputY;
    private float rot;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        rigidbody2D = GetComponent<Rigidbody2D>();
        rot = 0f;
    }

    private void FixedUpdate()
    {
        // Rotation
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(transform.position - mousePos, Vector3.forward);

        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        rigidbody2D.angularVelocity = 0;

        // Movement
        Move();       
    }

    private void Move()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        isMoving = h != 0f || v != 0f;

        horizontalMove = h * movementSpeed;
        verticalMove = v * movementSpeed;
        Vector3 newMove = new Vector3(horizontalMove, verticalMove);

        transform.position += newMove * Time.deltaTime;
    }
}
