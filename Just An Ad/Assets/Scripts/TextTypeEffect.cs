using UnityEngine;
using UnityEngine.UI;

public class TextTypeEffect : MonoBehaviour
{
    public string text;
    public char cursor = '_';
    Text textField;

    string curText = "";
    int curChar = 0;

    float timeValue = 0f;
    public float delay = 0.5f;
    public float cursorBlinkTime = 0.5f;

    public bool leaveCursorInTheEnd = true;
    bool isCursorVisibleInTheEnd = false;

    void Start()
    {
        textField = GetComponent<Text>();
    }

    void Update()
    {
        timeValue += Time.fixedDeltaTime;
        if (curChar < text.Length)
        {
            if (timeValue >= delay)
            {
                timeValue = 0f;
                curText += text[curChar];
                curChar++;
                textField.text = curText + cursor;
            }
        }
        else
        {
            if (leaveCursorInTheEnd)
            {
                if (timeValue >= cursorBlinkTime)
                {
                    timeValue = 0f;
                    if (isCursorVisibleInTheEnd)
                    {
                        textField.text = curText + cursor;
                    }
                    else
                    {
                        textField.text = curText;
                    }
                }
                isCursorVisibleInTheEnd = !isCursorVisibleInTheEnd;
            }
            else
            {
                textField.text = curText;
                this.enabled = false;
            }
        }
    }
}
