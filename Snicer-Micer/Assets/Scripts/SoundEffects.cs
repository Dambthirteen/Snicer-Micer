using UnityEngine;
using UnityEngine.InputSystem;

public class SoundEffects : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSound;
    [SerializeField] AudioSource SFXSoundFalling;


    [Header("Audio Clips")]
    public AudioClip backround;
    public AudioClip Slice;
    public AudioClip FallingVeg;

    void Start()
    {
        MusicSource.clip = backround;
        MusicSource.Play();
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

}
