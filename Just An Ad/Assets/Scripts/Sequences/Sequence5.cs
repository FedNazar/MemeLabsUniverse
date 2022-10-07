using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence5 : MonoBehaviour
{
    bool[] a = { false, false, false, false,
        false, false, false, false, false, false };

    public MoveObject knifeMover;
    public Animation knifeBendAnimation;

    public GameObject hammerBlock;
    public Rigidbody hammerBlockRigidbody;
    public PendulumMotion hammerControl;

    public MoveObject axeMover;
    public Animation axeBendAnimation;

    public GameObject knifeTest, hammerTest, axeTest;
    public Transform camPos2, camPos3, camPos4;
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
            knifeMover.enabled = true;
        }
        if (Time.timeSinceLevelLoad >= 3f && !a[1])
        {
            a[1] = true;
            knifeMover.enabled = false;
            transform.position = camPos2.position;
            transform.rotation = camPos2.rotation;
        }
        if (Time.timeSinceLevelLoad >= 5f && !a[2])
        {
            a[2] = true;
            knifeMover.enabled = true;
            knifeMover.speed = -0.15f;
            knifeBendAnimation.Play();
        }
        if (Time.timeSinceLevelLoad >= 5.3f && !a[3])
        {
            a[3] = true;
            knifeMover.enabled = false;
        }
        if (Time.timeSinceLevelLoad >= 8f && !a[4])
        {
            a[4] = true;
            knifeTest.SetActive(false);
            hammerTest.SetActive(true);
            voice[1].Play();
            transform.position = camPos3.position;
            transform.rotation = camPos3.rotation;
        }
        if (Time.timeSinceLevelLoad >= 13.7f && !a[5])
        {
            a[5] = true;
            hammerControl.enabled = false;
            hammerBlockRigidbody.isKinematic = false;
            hammerBlock.transform.parent = null;
        }
        if (Time.timeSinceLevelLoad >= 15f && !a[6])
        {
            a[6] = true;
            hammerTest.SetActive(false);
            axeTest.SetActive(true);
            voice[2].Play();
            transform.position = camPos4.position;
            transform.rotation = camPos4.rotation;
        }
        if (Time.timeSinceLevelLoad >= 15.5f && !a[7])
        {
            a[7] = true;
            axeBendAnimation.Play();
        }
        if (Time.timeSinceLevelLoad >= 15.8f && !a[8])
        {
            a[8] = true;
            axeMover.enabled = false;
        }
        if (Time.timeSinceLevelLoad >= 16.8f && !a[9])
        {
            a[9] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(3);
            }
            SceneManager.LoadScene(6);
        }
    }
}
