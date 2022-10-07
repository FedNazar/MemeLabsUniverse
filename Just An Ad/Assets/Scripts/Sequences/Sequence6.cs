using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence6 : MonoBehaviour
{
    bool[] a = { false, false, false, false, false, false };

    public GameObject drillTest, sawTest;
    public Transform camPos2;
    public AudioSource[] voice;

    public MoveObject drillCylinderMover, drillMover;
    public ScaleObject drillCylinderScaler;
    public ObjectRotator drillCylinderRotator;
    public ParticleSystem particle1, particle2;

    public Transform sawTransform;
    public Rigidbody sawRigidbody;
    public MeshRenderer sawtooth;
    public Material brokenSawtooth;
    public ParticleSystem particle1_s, particle2_s, particle3_s, particle4_s;

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
        if (Time.timeSinceLevelLoad >= 4.7f && !a[1])
        {
            a[1] = true;
            drillCylinderMover.enabled = false;
            drillMover.enabled = false;
            drillCylinderScaler.enabled = false;
            drillCylinderRotator.enabled = false;
            particle1.Stop();
            particle2.Stop();
        }
        if (Time.timeSinceLevelLoad >= 7f && !a[2])
        {
            a[2] = true;
            drillCylinderMover.speed = 0.3f;
            drillMover.speed = 0.3f;
            drillCylinderMover.enabled = true;
            drillMover.enabled = true;
        }
        if (Time.timeSinceLevelLoad >= 9f && !a[3])
        {
            a[3] = true;
            drillTest.SetActive(false);
            sawTest.SetActive(true);
            voice[1].Play();
            transform.position = camPos2.position;
            transform.rotation = camPos2.rotation;
        }
        if (Time.timeSinceLevelLoad >= 12.7f && !a[4])
        {
            a[4] = true;
            sawTransform.parent = null;
            sawRigidbody.isKinematic = false;
            sawRigidbody.AddForce(transform.up * 2, ForceMode.Impulse);
            sawRigidbody.AddForce(transform.forward * -2, ForceMode.Impulse);
            sawtooth.material = brokenSawtooth;
            particle1_s.Stop();
            particle2_s.Stop();
            particle3_s.Play();
            particle4_s.Play();
        }
        if (Time.timeSinceLevelLoad >= 17f && !a[5])
        {
            a[5] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(4);
            }
            SceneManager.LoadScene(7);
        }
    }
}
