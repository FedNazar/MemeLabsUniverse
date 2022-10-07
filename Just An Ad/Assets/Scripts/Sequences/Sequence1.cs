using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence1 : MonoBehaviour
{
    bool[] a = { false, false, false, false };

    public ScaleObject so;
    public MoveObjectLerp mol;
    public AudioSource voice;
    public GameObject photo, descrBox, descr2;

    void Update()
    {
        if (Time.timeSinceLevelLoad >= 4 && !a[0])
        {
            a[0] = true;
            so.enabled = true;
            mol.enabled = true;
            voice.Play();
        }
        if (Time.timeSinceLevelLoad >= 5f && !a[1])
        {
            a[1] = true;
            so.enabled = false;
            photo.SetActive(true);
            descrBox.SetActive(true);
        }
        if (Time.timeSinceLevelLoad >= 6.5f && !a[2])
        {
            a[2] = true;
            mol.enabled = false;
            descr2.SetActive(true);
        }
        if (Time.timeSinceLevelLoad >= 12.7f && !a[3])
        {
            a[3] = true;
            SceneManager.LoadScene(2);
        }
    }
}
