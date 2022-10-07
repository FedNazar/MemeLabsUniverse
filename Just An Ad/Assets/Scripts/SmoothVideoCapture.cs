using System.Collections;
using UnityEngine;

public class SmoothVideoCapture : MonoBehaviour
{
    public float timeScale = 0.01666667f, interval = 1f;
    public int frameNum = 60;
    private int currentFrame;

    void Start()
    {
        Time.timeScale = timeScale;
        StartCoroutine(CaptureFrame());
    }
    
    IEnumerator CaptureFrame()
    {
        for (int frame = 0; frame < frameNum; frame++)
        {
            ScreenCapture.CaptureScreenshot("VideoCapture\\Frame" + frame + ".png");
            yield return new WaitForSecondsRealtime(interval);
        }
    }
}
