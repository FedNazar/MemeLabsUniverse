using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence12 : MonoBehaviour
{
    bool a = false;

    GameObject bm;
    BenchmarkAgent bmagent;

    void Start()
    {
        bm = GameObject.FindGameObjectWithTag("BMAgent");
        if (bm != null)
        {
            bmagent = bm.GetComponent<BenchmarkAgent>();
            bmagent.frameCount = Time.frameCount;
        }
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad >= 9f && !a)
        {
            a = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(10);
            }
            SceneManager.LoadScene(13);
        }
    }
}

