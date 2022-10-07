using UnityEngine;
using UnityEngine.SceneManagement;

public class HiddenPartActivator : MonoBehaviour
{
    KeyCode[] cheatCode = {
        KeyCode.L,
        KeyCode.E,
        KeyCode.T,
        KeyCode.M,
        KeyCode.E,
        KeyCode.I,
        KeyCode.N
        };
    int index = 0;

    void Update()
    {
        if (Input.anyKeyDown && index < cheatCode.Length)
        {
            if (Input.GetKeyDown(cheatCode[index]))
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }

        if (index == cheatCode.Length)
        {
            Destroy(GameObject.FindGameObjectWithTag("MainTheme"));
            Destroy(GameObject.FindGameObjectWithTag("MainCanvas"));
            SceneManager.LoadScene(15);
        }
    }
}
