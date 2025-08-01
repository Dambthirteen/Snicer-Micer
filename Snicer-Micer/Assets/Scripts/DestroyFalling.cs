using UnityEngine;

public class DestroyFalling : MonoBehaviour
{

    public int CountLostVeg;
    public int CountLostVegTotal;
    public int _maxHealth = 10;
    public int _currentHealth;
    public int _LevelHealth = 10;

    public bool isDead;
    public bool NoFall = false;

    [SerializeField] private HealthBarScript _hbscript;

    public GameManager _gamemanager;
    public AudioSource _audiosource;
    

    [SerializeField] GameObject SlicerDestroy;


    void Start()
    {
        _currentHealth = _maxHealth;
        _hbscript.UpdateHealthbar(_maxHealth, _currentHealth);
    }


    void Update()
    {
        Debug.Log(CountLostVeg);


        if (CountLostVeg >= _LevelHealth)
        {
            Destroy(SlicerDestroy);
            _gamemanager.gameOver();
            
        }
        


    }


    public void OnCollisionEnter(Collision other)
    {
        CountLostVegetables();
        _currentHealth -= 1;
        _hbscript.UpdateHealthbar(_maxHealth, _currentHealth);


        _audiosource.pitch = Random.Range(1f, 1.5f);
        _audiosource.Play();
        Destroy(other.gameObject);
        NoFall = true;
    }

    public void CountLostVegetables()
    {
        CountLostVeg += 1;
    }

    public void lose()
    {
        
    }
}
