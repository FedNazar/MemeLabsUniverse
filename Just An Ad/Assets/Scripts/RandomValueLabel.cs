using UnityEngine;
using UnityEngine.UI;

public class RandomValueLabel : MonoBehaviour
{
    Text text;
    float timeValue = 0f;
    public float changeSpeed = 2f;

    void Start()
    {
        text = GetComponent<Text>();
        text.text = Random.Range(0, 10000000).ToString();
    }

    void Update()
    {
        timeValue += changeSpeed * Time.deltaTime;
        if (timeValue >= 5)
        {
            timeValue = 0f;
            text.text = Random.Range(0, 10000000).ToString();
        }
    }
}
