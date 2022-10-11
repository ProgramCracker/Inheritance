using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HealthBase : MonoBehaviour
{ 
    [SerializeField] public int _maxHealth;
    [SerializeField] public int _currentHealth;

    PlayInput player;
    TankController tankController;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void DecreaseHealth(int damage)
    {
        _currentHealth -= damage;

        Debug.Log(gameObject + " current health is:" + _currentHealth);
        if (_currentHealth <= 0)
        {
           
            Kill();
        }
    }

    public void IncreaseHealth(int amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
    }

    public void Kill()
    {

        gameObject.SetActive(false);
    }
}
