using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    Image image;
    public float speed = 4;

    void Start()
    {
        image = GetComponent<Image>();
        image.color = new Color(image.color.r, image.color.g,
            image.color.b, 0);
    }

    void Update()
    {
        image.color = new Color(image.color.r, image.color.g,
        image.color.b, image.color.a + speed * Time.deltaTime);
        if (image.color.a >= 255)
            enabled = false;
    }
}
