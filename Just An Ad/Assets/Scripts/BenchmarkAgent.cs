using UnityEngine;
using UnityEngine.SceneManagement;

public class BenchmarkAgent : MonoBehaviour
{
    [HideInInspector]
    public float[] fpsValues = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    [HideInInspector]
    public float frameCount;

    public void CalculateAverageFPS(int sceneNum)
    {
        fpsValues[sceneNum] =
            (Time.frameCount - frameCount) / Time.timeSinceLevelLoad;
        frameCount = Time.frameCount;
    }
}
