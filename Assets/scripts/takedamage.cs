using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takedamage : MonoBehaviour
{
    public Health health;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>;
    }

    // Update is called once per frame
    void Update()
    {
        health = GameObject.FindGameObjectWithTag("player").GetComponent<Health>;
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "player"){
            health.sethealth(health.gethealth()-1);
        }
    }
}
