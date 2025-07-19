using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    DestroyFalling _dsfalling;
    public float maxHealth;
    public float currenHealth;

    [SerializeField] Image _healthBarSprite;


    void Start()
    {
        currenHealth = maxHealth;
    }


    void Update()
    {
        _dsfalling = GetComponent<DestroyFalling>();
        
    }

    public void UpdateHealthbar(float maxHealth, float currenHealth)
    {
        currenHealth = _dsfalling.CountLostVeg;
        _healthBarSprite.fillAmount = currenHealth / maxHealth;
    }
}
