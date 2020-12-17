using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMeter : MonoBehaviour
{
    // Start is called before the first frame update
    // min max current values
    public int minHealth;
    public int maxHealth;
    private int currentHealth;
    private float currentPercent; 

    public int CurrentHealth
    {
        get
        {
            return currentHealth;
        }
    }
    public float CurrentPercent
    {
        get
        {
            return currentPercent;
        }
    }
    public void SetValue(int health)
    {
        if(health != currentHealth)
        {
            if (maxHealth-minHealth == 0)
            {
                currentHealth = 0;
                currentPercent = 0;
            }
            else
            {
                currentHealth = health;
                currentPercent = (float)currentHealth / (float)(maxHealth - minHealth);
            }
            // TO DO update UI stuff
        }
    }
}
