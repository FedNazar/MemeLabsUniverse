using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence4 : MonoBehaviour
{
    bool[] a = { false, false, false, false, false, false, false, false };

    public Transform camPos1, camPos2, camPos3, camPos4, camPos5;
    public CameraRotator cameraRotator;
    public MoveObject cameraMove;
    public AudioSource voice;

    public ScaleObject bgsvScreenScaler, woodStructScreenScaler;
    public GameObject bgsvScreen, woodStructScreen;
    public Camera woodStructCamera, bgsvCamera;

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
        if (Time.timeSinceLevelLoad >= 6 && !a[1])
        {
            a[1] = true;
            transform.position = camPos2.position;
            transform.rotation = camPos2.rotation;
            cameraRotator.enabled = false;
            cameraMove.enabled = true;
        }
        if (Time.timeSinceLevelLoad >= 12 && !a[2])
        {
            a[2] = true;
            transform.position = camPos3.position;
            transform.rotation = camPos3.rotation;
            cameraMove.forward = true;
            cameraMove.speed = -0.3f;
            cameraMove.up = false;
        }
        if (Time.timeSinceLevelLoad >= 18 && !a[3])
        {
            a[3] = true;
            transform.position = camPos4.position;
            transform.rotation = camPos4.rotation;
            cameraRotator.enabled = true;
        }
        if (Time.timeSinceLevelLoad >= 24 && !a[4])
        {
            a[4] = true;
            cameraRotator.enabled = false;
            cameraMove.up = true;
            cameraMove.forward = false;
            cameraMove.speed = -0.5f;
            transform.position = camPos5.position;
            transform.rotation = camPos5.rotation;
        }
        if (Time.timeSinceLevelLoad >= 30 && !a[5])
        {
            a[5] = true;
            transform.position = camPos1.position;
            transform.rotation = camPos1.rotation;
            cameraMove.enabled = false;
            cameraRotator.speed = 0.01f;
            cameraRotator.enabled = true;
            woodStructCamera.enabled = true;
            woodStructScreen.SetActive(true);
            bgsvCamera.enabled = true;
            bgsvScreen.SetActive(true);
        }
        if (Time.timeSinceLevelLoad >= 30.5f && !a[6])
        {
            a[6] = true;
            woodStructScreenScaler.enabled = false;
            bgsvScreenScaler.enabled = false;
        }
        if (Time.timeSinceLevelLoad >= 42f && !a[7])
        {
            a[7] = true;
            if (bmagent != null)
            {
                bmagent.CalculateAverageFPS(2);
            }
            SceneManager.LoadScene(5);
        }
    }
}
