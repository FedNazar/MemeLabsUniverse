using UnityEngine;
using UnityEngine.UI;

public class JukeboxEngine : MonoBehaviour
{
    public MeshRenderer vinyl;
    public Material vinylSideA, vinylSideB;
    public Text currentlyPlaying;
    AudioSource musicPlayer;
    public AudioClip[] music;

    void Start()
    {
        musicPlayer = GetComponent<AudioSource>(); 
    }

    public void PlayTrack(int trackNumber)
    {
        musicPlayer.Stop();
        if (trackNumber < 2)
        {
            vinyl.material = vinylSideA;
        }
        else
        {
            vinyl.material = vinylSideB;
        }
        musicPlayer.clip = music[trackNumber];
        musicPlayer.Play();
        currentlyPlaying.text = music[trackNumber].name;
    }
}
