using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    Rigidbody obj;

    public float speed = 5;

    void Start()
    {
        obj = GetComponent<Rigidbody>();
        obj.AddForce(transform.right * speed, ForceMode.Acceleration);
    }
}
