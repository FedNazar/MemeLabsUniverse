using UnityEngine;
using UnityEngine.SceneManagement;

public class InformationMenu : MonoBehaviour
{
    public GameObject mainMenu, makingOf, financialStats;

    void Start()
    {
        Cursor.visible = true;
        Screen.sleepTimeout = SleepTimeout.SystemSetting;
        Destroy(GameObject.FindGameObjectWithTag("BMAgent"));
        Destroy(GameObject.FindGameObjectWithTag("MainTheme"));
        Destroy(GameObject.FindGameObjectWithTag("MainCanvas"));
    }

    public void ReplayDemo()
    {
        Cursor.visible = false;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        SceneManager.LoadScene(1);
    }

    public void ShowMakingOf()
    {
        mainMenu.SetActive(false);
        makingOf.SetActive(true);
    }

    public void ShowFinancialStats()
    {
        mainMenu.SetActive(false);
        financialStats.SetActive(true);
    }

    public void OpenJukebox()
    {
        SceneManager.LoadScene(16);
    }

    public void QuitDemo()
    {
        Application.Quit();
    }
}
