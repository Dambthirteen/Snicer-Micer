using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class SoundEffects : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSound;
    [SerializeField] AudioSource SFXSoundFalling;
    [SerializeField] AudioSource Backroundmusic;


    [Header("Volume")]
    [SerializeField] float VolumeChange = 50f;

    [Header("Audio Clips")]
    public AudioClip backround;
    public AudioClip Slice;
    public AudioClip FallingVeg;

    void Start()
    {
        

        PlayBackround();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Invoke(nameof(PlaySlice), 0.1f);
        }
    }

    void PlaySlice()
    {
        SFXSound.Play();
    }

    void PlayBackround()
    {
        Backroundmusic.Play();
    }

}
