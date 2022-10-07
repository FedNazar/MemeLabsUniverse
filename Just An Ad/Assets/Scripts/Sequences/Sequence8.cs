using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence8 : MonoBehaviour
{
    bool[] a = { false, false };

    public GameObject glass, glassFractured;

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
        if (Time.timeSinceLevelLoad >= 0.5f && !a[0])
        {
            a[0] = true;
            glass.SetActive(false);
            glassFractured.SetActive(true);
        }
        if (Time.timeSinceLevelLoad >= 4.5f && !a[1])
        {
            a[1] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(6);
            }
            SceneManager.LoadScene(9);
        }
    }
}
