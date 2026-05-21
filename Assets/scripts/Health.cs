using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxhealth = 10;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    
    public void takeDamage(int amt)
    {
        health -= amt;
        if (health <= 0){
            Destroy(gameObject);
        }
    }
}
