using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    // health bar, taking damage, asserting damage, UI, 
    private HealthMeter healthMeter;
    public int Health = 100;
    public int Power = 1;
    [SerializeField]
    private UnityEvent onHit;
    
    public bool IsDead
    {
        get
        {
            return Health == 0;
            
        }
    }
    public void TakeDamage(int amount)
    {
        Health -= amount;
        healthMeter.SetValue(Health);
        onHit?.Invoke();
        if (IsDead)
        {
            // return ded
        }
    }
    public void Attack()
    { 

    }
    void Start()
    {
        healthMeter.minHealth = 0;
        healthMeter.maxHealth = Health;
        healthMeter.SetValue(Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
