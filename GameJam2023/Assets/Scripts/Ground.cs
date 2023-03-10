using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject[] Grounds;
    public int health = 100;

    private int state = 0;

    GameObject groundobject;

    void Start()
    {
        groundobject = Instantiate(Grounds[0], gameObject.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 75 && state == 0)
        {
            Destroy(groundobject);
            groundobject = Instantiate(Grounds[1], gameObject.transform.position, Quaternion.identity);
            state++;
        }
        else if (health <= 50 && state == 1)
        {
            Destroy(groundobject);
            groundobject = Instantiate(Grounds[2], gameObject.transform.position, Quaternion.identity);
            state++;
        }
        else if (health <= 25 && state == 2)
        {
            Destroy(groundobject);
            groundobject = Instantiate(Grounds[3], gameObject.transform.position, Quaternion.identity);
            state++;
        }
        else if (health <= 0)
        {
            Destroy(groundobject);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ijspegel"))
        {
            health -= 25;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("ball"))
        {
            health -= 50;
        }
    }
}
