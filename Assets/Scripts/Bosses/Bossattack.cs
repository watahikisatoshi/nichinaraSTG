using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossattack : MonoBehaviour
{
    // Start is called before the first frame updat

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position -= new Vector3(5 * Time.deltaTime, 0, 0);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BossBullet") == true)
        {
            return;     
        }

        
        Destroy(gameObject);
        Destroy(collision.gameObject);
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
   
        
       
}