using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Movement speed of the player")]
    public float movementSpeed = 5;
    [Tooltip("Sensitivity applied to inputs")]
    public float sensitivity = 10.0f;

    private new Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float h;
        float v;

        // Rotation
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(transform.position - mousePos, Vector3.forward);

        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        rigidbody2D.angularVelocity = 0;

        // Movement
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        if (h != 0f || v != 0f)
        {
            Move(h, v);
        }
    }

    // Player movement
    private void Move(float horizontal, float vertical)
    {
        Vector3 mousePos = transform.position;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        mousePos += new Vector3(horizontal * movementSpeed * Time.deltaTime, 0, 0);
        transform.position = Vector3.MoveTowards(transform.position, mousePos, vertical * movementSpeed * Time.deltaTime);

    }
}
