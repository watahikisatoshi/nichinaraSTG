using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosscontroller : MonoBehaviour
{
    public GameObject BossBullet;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shot", 2f, 1f);
    }

    void Shot()
    {

        Instantiate(BossBullet, transform.position, transform.rotation);
        // Update is called once per frame
        void Update()
        {


        }
    }
}