using UnityEngine;

public class DestroyFalling : MonoBehaviour
{

    public int CountLostVeg;
    public int CountLostVegTotal;
    public int _maxHealth = 10;
    public int _currentHealth;
    public int _LevelHealth = 10;

    public bool isDead;

    [SerializeField] private HealthBarScript _hbscript;

    public GameManager _gamemanager;


    void Start()
    {
        _currentHealth = _maxHealth;
        _hbscript.UpdateHealthbar(_maxHealth, _currentHealth);
    }


    void Update()
    {
        Debug.Log(CountLostVeg);
        

        if (CountLostVeg >= _LevelHealth && !isDead)
        {
            isDead = true;
            _gamemanager.gameOver();
        }

    }


    public void OnCollisionEnter(Collision other)
    {
        CountLostVegetables();
        _currentHealth -= 1;
        _hbscript.UpdateHealthbar(_maxHealth, _currentHealth);




        Destroy(other.gameObject);
    }

    public void CountLostVegetables()
    {
        CountLostVeg += 1;
    }

    public void lose()
    {
        
    }
}
