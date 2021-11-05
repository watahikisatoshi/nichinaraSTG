using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosses : MonoBehaviour
{


    public GameObject shellprefab;
    public float shotspeed;
    public AudioClip shotSound;

    private int count = 0;

    void Update()
    {

        count += 1;

        if (count % 100 == 0)
        {
            EnemyShot();
        }
    }





    public void EnemyShot()
    {

        GameObject shell = Instantiate(shellprefab, transform.position, Quaternion.identity) as GameObject;
        Rigidbody shellRighdbody = shell.GetComponent<Rigidbody>();
        shellRighdbody.AddForce(transform.forward * shotspeed);
        AudioSource.PlayClipAtPoint(shotSound, transform.position);
        Destroy(shell, 1.0f);
    }
}
            
    
