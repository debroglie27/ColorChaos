using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public CameraMovement mainCamera;

    void OnTriggerExit2D(Collider2D collisionInfo)
    {
        string doorName = this.name;

        if(collisionInfo.tag == "Player")
        {
            // Orientation of Door ('H' / 'V')
            char doorOrientation = doorName[0];

            // The Door Connects Room 'i' and Room 'j'
            string Ri = "Room" + doorName.Remove(0, 5)[1];
            string Rj = "Room" + doorName.Remove(0, 5)[3];

            if(doorOrientation.CompareTo('H') == 0)
            {
                if(collisionInfo.transform.position.x > transform.position.x)
                {
                    mainCamera.ChangePosition(GameObject.Find(Rj).transform);
                }
                else
                {
                    mainCamera.ChangePosition(GameObject.Find(Ri).transform);
                }
            }

            if(doorOrientation.CompareTo('V') == 0)
            {
                if(collisionInfo.transform.position.y > transform.position.y)
                {
                    mainCamera.ChangePosition(GameObject.Find(Rj).transform);
                }
                else
                {
                    mainCamera.ChangePosition(GameObject.Find(Ri).transform);
                }
            }
        }
    }
}
