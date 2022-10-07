using UnityEngine;

public class HiddenPartCamera : MonoBehaviour
{
    float angle = 0f;
    public float aSpeed = 20f, pSpeed = 2f;

    void Update()
    {
        angle += aSpeed * Time.deltaTime;
        transform.Rotate(transform.up * pSpeed * Mathf.Cos(angle) * Time.deltaTime);
    }
}
