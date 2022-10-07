using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    public float speedX = 4f, speedY = 4f, speedZ = 4f;

    void Update()
    {
        transform.localScale = new Vector3
        (
            transform.localScale.x + speedX * Time.deltaTime,
            transform.localScale.y + speedY * Time.deltaTime,
            transform.localScale.z + speedZ * Time.deltaTime
        );
    }
}
