using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_axis : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "PlayerTime")
        {
            transform.parent = null;
            transform.parent =col.gameObject.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "PlayerTime")
        {
            transform.SetParent(null);        }
    }
}
