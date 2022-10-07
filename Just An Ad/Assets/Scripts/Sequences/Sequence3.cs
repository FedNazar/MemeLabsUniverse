using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence3 : MonoBehaviour
{
    bool[] a = { false, false, false, false, false, false };

    public GameObject greyBox;
    public FadeIn greyBoxFade;

    public AudioSource[] voice;
    public GameObject pendulum, generator, spoon, something3000;

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
        if (Time.timeSinceLevelLoad >= 4 && !a[1])
        {
            a[1] = true;
            pendulum.SetActive(false);
            generator.SetActive(true);
            voice[1].Play();
        }
        if (Time.timeSinceLevelLoad >= 10.5f && !a[2])
        {
            a[2] = true;
            generator.SetActive(false);
            spoon.SetActive(true);
            voice[2].Play();
        }
        if (Time.timeSinceLevelLoad >= 14.5f && !a[3])
        {
            a[3] = true;
            spoon.SetActive(false);
            something3000.SetActive(true);
            voice[3].Play();
        }
        if (Time.timeSinceLevelLoad >= 26.5f && !a[4])
        {
            a[4] = true;
            greyBox.SetActive(true);
            greyBoxFade.enabled = true;
        }
        if (Time.timeSinceLevelLoad >= 28 && !a[5])
        {
            a[5] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(1);
            }
            SceneManager.LoadScene(4);
        }
    }
}
