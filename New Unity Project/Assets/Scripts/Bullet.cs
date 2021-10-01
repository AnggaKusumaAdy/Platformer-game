using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player") && coll.gameObject.CompareTag("Ground"))
            Destroy(this.gameObject);
        if (coll.gameObject.CompareTag("Enemy"))
        {
            coll.gameObject.SendMessage("TakeDamage", 1);
        }
        Destroy(this.gameObject);
    }
}
