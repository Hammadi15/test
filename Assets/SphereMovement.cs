using UnityEngine;
public class SphereMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;
    // Initialize the Rigidbody component
    void Start()
    {
        // Get the Rigidbody component attached to the sphere
        rb = GetComponent<Rigidbody>();
        // Ensure the Rigidbody is not kinematic, allowing physics forces to affect it
        rb.isKinematic = false;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = Vector3.zero;
        // Determine the movement direction based on input
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDirection = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDirection = Vector3.back;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection = Vector3.right;
        }
        // Apply force to the Rigidbody to move and roll the sphere
        if (moveDirection != Vector3.zero)
        {
            rb.AddForce(moveDirection * speed, ForceMode.Force);
        }
    }
}