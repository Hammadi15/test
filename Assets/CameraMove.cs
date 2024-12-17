using UnityEngine;
public class CameraMove : MonoBehaviour
{
    public Transform target;       // The target for the camera to follow
    public float smoothSpeed = 0.125f;  // Controls the smoothness of the camera movement
    private Vector3 offset;
    void Start()
    {
        if (target != null)
        {
            // Calculate the initial offset between the camera and the target
            offset = transform.position - target.position;
        }
    }
    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired position with offset
            Vector3 desiredPosition = target.position + offset;
            // Smoothly interpolate to the desired position for smooth following
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            // Set the camera's position to the smoothed position
            transform.position = smoothedPosition;
            // Make the camera look at the target
            transform.LookAt(target);
        }
    }
}