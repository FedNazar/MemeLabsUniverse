using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence10 : MonoBehaviour
{
    bool[] a = { false, false, false };

    public Transform camPos2;
    public CameraRotator cameraRotator;
    public MoveObject tableMelter;
    public GameObject chipCamFootage, chipCam;
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
        if (Time.timeSinceLevelLoad >= 11f && !a[1])
        {
            a[1] = true;
            cameraRotator.enabled = false;
            tableMelter.enabled = true;
            chipCamFootage.SetActive(false);
            chipCam.SetActive(false);
            transform.position = camPos2.position;
            transform.rotation = camPos2.rotation;
            voice[1].Play();
        }
        if (Time.timeSinceLevelLoad >= 22f && !a[2])
        {
            a[2] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(8);
            }
            SceneManager.LoadScene(11);
        }
    }
}
