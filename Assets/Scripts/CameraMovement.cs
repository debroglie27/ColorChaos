using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public void ChangePosition(Transform newRoomTransform)
    {
        // Changing the X and Y values of Main Camera
        Vector3 temp = transform.position;

        temp.x = newRoomTransform.position.x;
        temp.y = newRoomTransform.position.y;

        transform.position = temp;
    }
}
