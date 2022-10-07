using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence7 : MonoBehaviour
{
    bool[] a = { false, false, false, false, false };

    public GameObject[] tests;
    public AudioSource[] voice;

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
        if (Time.timeSinceLevelLoad >= 0.1f && !a[0])
        {
            a[0] = true;
            voice[0].Play();
        }
        if (Time.timeSinceLevelLoad >= 5 && !a[1])
        {
            a[1] = true;
            tests[0].SetActive(false);
            tests[1].SetActive(true);
            voice[1].Play();
        }
        if (Time.timeSinceLevelLoad >= 10 && !a[2])
        {
            a[2] = true;
            tests[1].SetActive(false);
            tests[2].SetActive(true);
            voice[2].Play();
        }
        if (Time.timeSinceLevelLoad >= 15 && !a[3])
        {
            a[3] = true;
            tests[2].SetActive(false);
            tests[3].SetActive(true);
            voice[3].Play();
        }
        if (Time.timeSinceLevelLoad >= 21 && !a[4])
        {
            a[4] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(5);
            }
            SceneManager.LoadScene(8);
        }
    }
}
