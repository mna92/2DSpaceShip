using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public HealthBar healthBar;
    public GameObject gameOver;
    public GameObject enemyStartLocation;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHealth(int damageHealth)
    {
        currentHealth -= damageHealth;
        healthBar.SetCurrentHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            gameOver.SetActive(true);
            enemyStartLocation.SetActive(false);
        }
    }
}
