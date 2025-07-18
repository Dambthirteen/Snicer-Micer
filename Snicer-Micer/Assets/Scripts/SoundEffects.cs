using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSound;

    [Header("Audio Clips")]
    public AudioClip backround;
    public AudioClip Slice;
    public AudioClip FallingVeg;
}
