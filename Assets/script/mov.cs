using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public bool injump;
    void Start()
    {
        rb =GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKeyDown("w"))
        {
            if (injump)
            {
                injump = false;
                rb.AddForce(transform.up * 350);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            injump = true;
        }
        if (col.gameObject.tag == "PlayerTime")
        {
            transform.parent = col.gameObject.transform;
            injump = true;

        }
    }
        private void OnCollisionExit2D(Collision2D col)
        {
            if (col.gameObject.tag == "PlayerTime")
            {
                transform.SetParent(null);
            }
        }
}
