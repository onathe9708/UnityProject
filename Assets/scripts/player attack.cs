/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerattack : MonoBehaviour
{
    private GameObject attackArea = 2;
    private bool attacking = false;

    private float attacktimer = 0.25f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.getChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)){
            Attack();
        }
        if (attacking){
            timer += Time.deltaTime;
            if (timer >= attacktimer){
                timer = 0;
                attacking = false;
                attackArea.setActive(attacking);
            }
        }
    }
    private void Attack(){
        attacking = true;
        attackArea.setActive(attacking);
    }
}
*/