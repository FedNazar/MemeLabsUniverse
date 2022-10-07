using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence2 : MonoBehaviour
{
    bool[] a = { false, false, false, false };

    public GameObject locationText;
    public GameObject greyBox;
    public FadeIn greyBoxFade;
    public AudioSource voice;

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
        if (Time.timeSinceLevelLoad >= 0.2f && !a[0])
        {
            a[0] = true;
            voice.Play();
        }
        if (Time.timeSinceLevelLoad >= 3 && !a[1])
        {
            a[1] = true;
            locationText.SetActive(true);
            greyBox.SetActive(false);
        }
        if (Time.timeSinceLevelLoad >= 18f && !a[2])
        {
            a[2] = true;
            greyBox.SetActive(true);
            greyBoxFade.enabled = true;
        }
        if (Time.timeSinceLevelLoad >= 20f && !a[3])
        {
            a[3] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(0);
            }
            SceneManager.LoadScene(3);
        }
    }
}
