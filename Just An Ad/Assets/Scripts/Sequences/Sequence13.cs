using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence13 : MonoBehaviour
{
    GameObject bm;
    bool a = false;

    void Start()
    {
        Destroy(GameObject.FindGameObjectWithTag("MainCanvas"));
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad >= 7f && !a)
        {
            a = true;
            bm = GameObject.FindGameObjectWithTag("BMAgent");
            if (bm != null)
            {
                SceneManager.LoadScene(17);
            }
            else
            {
                SceneManager.LoadScene(14);
            }
        }
    }
}
