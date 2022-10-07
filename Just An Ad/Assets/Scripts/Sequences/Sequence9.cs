using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence9 : MonoBehaviour
{
    bool[] a = { false, false, false, false };

    public Rigidbody board;
    public Transform boardTransform;
    public ParticleSystem particle;
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
        if (Time.timeSinceLevelLoad >= 0.1f && !a[0])
        {
            a[0] = true;
            voice.Play();
        }
        if (Time.timeSinceLevelLoad >= 5f && !a[1])
        {
            a[1] = true;
            board.AddForce(boardTransform.forward * -0.7f, ForceMode.Impulse);
        }
        if (Time.timeSinceLevelLoad >= 7f && !a[2])
        {
            a[2] = true;
            particle.Play();
        }
        if (Time.timeSinceLevelLoad >= 11f && !a[3])
        {
            a[3] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(7);
            }
            SceneManager.LoadScene(10);
        }
    }
}
