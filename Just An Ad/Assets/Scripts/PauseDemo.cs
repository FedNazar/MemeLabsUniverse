using UnityEngine;

public class PauseDemo : MonoBehaviour
{
    AudioSource music;
    public bool paused = false;

    void Start()
    {
        music = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Pause) && !paused)
        {
            paused = true;
            Time.timeScale = 0;
            music.Pause();
        }
        else if (Input.GetKeyUp(KeyCode.Pause) && paused)
        {
            paused = false;
            Time.timeScale = 1;
            music.UnPause();
        }
    }
}
