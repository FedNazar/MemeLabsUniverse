using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToInfoMenu : MonoBehaviour
{
    public GameObject infoMenu, currentCanvas;

    public void ChangeCanvas()
    {
        currentCanvas.SetActive(false);
        infoMenu.SetActive(true);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(14);
    }
}
