using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float speed, minZoom, maxZoom;
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();   
    }

    void Update()
    {
        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView +
            speed * Input.GetAxis("Mouse ScrollWheel"), minZoom, maxZoom);
    }
}
