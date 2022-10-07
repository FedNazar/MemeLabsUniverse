using UnityEngine;

public class InteractiveTextScroller : MonoBehaviour
{
    public float speed, minY, maxY;

    void Update()
    {
        transform.Translate(transform.up * speed * Input.GetAxis("Vertical"));
        transform.position = new Vector3 (transform.position.x,
            Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
    }
}
