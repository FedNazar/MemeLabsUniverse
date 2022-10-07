using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BenchmarkStats : MonoBehaviour
{
    public Text[] labels;
    BenchmarkAgent bmagent;
    double averageFPS = 0f, averageSceneFPS;

    void Start()
    {
        Cursor.visible = true;
        bmagent = GameObject.FindGameObjectWithTag("BMAgent").GetComponent<BenchmarkAgent>();
        for (int i = 0; i < 11; i++)
        {
            averageSceneFPS = Mathf.Round(bmagent.fpsValues[i] * 100) * 0.01;
            labels[i + 1].text += averageSceneFPS;
            averageFPS += averageSceneFPS;
        }
        labels[0].text += averageFPS / 10;
    }
    
    public void LoadInfoMenu()
    {
        SceneManager.LoadScene(14);
    }
}
