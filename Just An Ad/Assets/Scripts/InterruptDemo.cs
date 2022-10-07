using UnityEngine;
using UnityEngine.SceneManagement;

public class InterruptDemo : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(14);
        }
    }
}
