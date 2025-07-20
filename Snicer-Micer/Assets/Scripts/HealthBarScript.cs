using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    DestroyFalling _dsfalling;
    

    [SerializeField] Image _healthBarSprite;
    


    void Start()
    {
        
    }


    void Update()
    {
        _dsfalling = GetComponent<DestroyFalling>();
        
    }

    public void UpdateHealthbar(float _maxHealth, float _currentHealth)
    {

        _healthBarSprite.fillAmount = _currentHealth / _maxHealth;
        
    }
}
