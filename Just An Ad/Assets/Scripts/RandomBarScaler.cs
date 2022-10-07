using UnityEngine;

public class RandomBarScaler : MonoBehaviour
{
    public float speed = 2f;
    float maxValue, curValue = 0;
    int dir = 1;

    void Start()
    {
        maxValue = Random.Range(0, 5);
    }
    
    void Update()
    {
        curValue += speed * Time.deltaTime;
        transform.localScale = new Vector3
        (
            Mathf.Clamp(transform.localScale.x + speed * dir * Time.deltaTime, 0, 2),
            transform.localScale.y, transform.localScale.z
        );

        if (transform.localScale.x == 0)
        {
            dir = 1;
        }
        else if (transform.localScale.x == 2)
        {
            dir = -1;
        }

        if (maxValue <= curValue)
        {
            curValue = 0;
            maxValue = Random.Range(0, 5);
            if (dir == 1)
            {
                dir = -1;
            }
            else
            {
                dir = 1;
            }
        }
    }
}
