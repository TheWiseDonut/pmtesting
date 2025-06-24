using UnityEngine;

public class Interaction : MonoBehaviour
{
    public float interactionDistance = 3f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInteract();
        }
    }

    void TryInteract()
    {
        // Raycast from camera
        Camera cam = Camera.main;
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            Door door = hit.collider.GetComponent<Door>(); // Check if it's a door
            if (door != null)
            {
                door.Toggle();
            }
        }
    }
}