using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public KeyCode switchKey;
    public Camera mainCamera;
    public Camera secondCamera;

    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled; // Toggle main camera
            secondCamera.enabled = !secondCamera.enabled; // Toggle second camera
        }
    }
}