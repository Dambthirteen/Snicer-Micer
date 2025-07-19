using UnityEngine;
using UnityEngine.UI;

public class AudioManagement : MonoBehaviour
{

    [SerializeField] float volumeSlider;
    AudioSource _audiosource;

    void Start()
    {
       _audiosource.Play();
    }


    void Update()
    {

    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider; 
    }
}
