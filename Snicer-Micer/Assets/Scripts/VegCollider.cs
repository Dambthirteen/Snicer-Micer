using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class VegCollider : MonoBehaviour
{

    public GameObject[] GmVeg;

    //Counter Spawn & Destroy
    int CarrotCounter;
    int PotatoCounter;
    int AvocadoCounter;
    [SerializeField] float _DestroyTimeOffset;
    [SerializeField] float _FracturedSpawn = 0.2f;

    //Counter UI
    int CarrotCounterMax;
    int PotatoCounterMax;
    int AvocadoCounterMax;
    int TotalSliced;
    [SerializeField] TextMeshProUGUI _ScoreCarrot;
    [SerializeField] TextMeshProUGUI _ScorePotato;
    [SerializeField] TextMeshProUGUI _ScoreAvocado;
    [SerializeField] TextMeshProUGUI _TotalSliced;

    //Keys
    public KeyCode SliceKey = KeyCode.Space;

    //Sounds
    AudioSource _audioSource;

    //Particles
    [SerializeField] private ParticleSystem _DestroyParticlesCarrot;
    [SerializeField] private ParticleSystem _DestroyParticlesPotato;
    [SerializeField] private ParticleSystem _DestroyParticlesAvocado;
    private ParticleSystem _DamageParticleSystem;

    void Awake()
    {

    }


    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        _ScoreCarrot.text = CarrotCounterMax.ToString();
        _ScorePotato.text = PotatoCounterMax.ToString();
        _ScoreAvocado.text = AvocadoCounterMax.ToString();
        _TotalSliced.text = TotalSliced.ToString();
        SliceKey = KeyCode.Space;

    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Carrot"))
        {
            CarrotCounter += 1;
        }

        if (other.gameObject.CompareTag("Potato"))
        {
            PotatoCounter += 1;
        }

        if (other.gameObject.CompareTag("Avocado"))
        {
            AvocadoCounter += 1;
        }
        ///Instantiate(GmVeg[1], new Vector3(transform.position.x, -1f, transform.position.z), quaternion.identity);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(SliceKey))
        {

            if (other.gameObject.CompareTag("Carrot"))
            {
                _DamageParticleSystem = Instantiate(_DestroyParticlesCarrot, transform.position, Quaternion.identity);
            }
            if (other.gameObject.CompareTag("Potato"))
            {
                _DamageParticleSystem = Instantiate(_DestroyParticlesPotato, transform.position, Quaternion.identity);
            }
            if (other.gameObject.CompareTag("Avocado"))
            {
                _DamageParticleSystem = Instantiate(_DestroyParticlesAvocado, transform.position, Quaternion.identity);
            }
            
            Destroy(other.gameObject, _DestroyTimeOffset);
            
            SpawnVegetables();
            UICounter();

            CarrotCounter = 0;
            PotatoCounter = 0;
            AvocadoCounter = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Carrot"))
        {
            CarrotCounter -= 1;
        }

        if (other.gameObject.CompareTag("Potato"))
        {
            PotatoCounter -= 1;
        }

        if (other.gameObject.CompareTag("Avocado"))
        {
            AvocadoCounter -= 1;
        }
    }

    private void PlaySoundFalling()
    {
        _audioSource.Play();
    }

    private void SpawnVegetables()
    {
        for (int i = 0; i < PotatoCounter; i++)
        {
            Instantiate(GmVeg[0], new Vector3(transform.position.x, _FracturedSpawn, transform.position.z), quaternion.identity);
        }
        for (int i = 0; i < CarrotCounter; i++)
        {
            Instantiate(GmVeg[1], new Vector3(transform.position.x, _FracturedSpawn, transform.position.z), quaternion.identity);
        }
        for (int i = 0; i < AvocadoCounter; i++)
        {
            Instantiate(GmVeg[2], new Vector3(transform.position.x, _FracturedSpawn, transform.position.z), quaternion.identity);
        }

        Invoke(nameof(PlaySoundFalling), 0.3f);

    }

    private void UICounter()
    {
        CarrotCounterMax += CarrotCounter;
        PotatoCounterMax += PotatoCounter;
        AvocadoCounterMax += AvocadoCounter;
        TotalSliced += CarrotCounter + PotatoCounter + AvocadoCounter;
    }

        


}
