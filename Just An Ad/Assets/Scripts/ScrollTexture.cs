using UnityEngine;

public class ScrollTexture : MonoBehaviour
{
    public Material material;
    public float speed = 1f;
    public float startPos = 0.77f;
    Vector2 offset;

    void Update()
    {
        offset = new Vector2(0, startPos + Time.timeSinceLevelLoad * speed);
        material.SetTextureOffset("_BaseMap", offset);
    }
}
