using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour
{
    [SerializeField]
    private Player currentPlayer;
    private void OnCollisionEnter(Collision collision)
    {
        Player playerHit = collision.collider.GetComponent<Player>();
        if(playerHit)
        {
            if(collision.relativeVelocity.magnitude > 1)
            {

                playerHit.TakeDamage((currentPlayer.Power* (int)collision.relativeVelocity.magnitude));
            }
        }
    }
    private float CalcualateDamage() {
        return 0.0f;
    //calc damage here 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
