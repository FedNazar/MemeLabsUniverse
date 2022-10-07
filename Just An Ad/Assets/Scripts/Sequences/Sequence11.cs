using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence11 : MonoBehaviour
{
    bool[] a = { false, false };
    public GameObject text;

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
        if (Time.timeSinceLevelLoad >= 15f && !a[0])
        {
            a[0] = true;
            text.SetActive(true);
        }
        if (Time.timeSinceLevelLoad >= 32f && !a[1])
        {
            a[1] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(9);
            }
            SceneManager.LoadScene(12);
        }
    }
}
