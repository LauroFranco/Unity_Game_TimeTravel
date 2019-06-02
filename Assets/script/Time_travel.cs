using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_travel : MonoBehaviour
{
    public GameObject pastplayer;
    bool isRewinding = false;

    public float recordTime = 5f;

    public static List<Vector2> pointsInTime;

    Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        pointsInTime = new List<Vector2>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            StartCoroutine(Reset());
        }
    }

    void FixedUpdate()
    {
        Record();
    }

    void Record()
    {
        if (pointsInTime.Count > Mathf.Round(recordTime / Time.fixedDeltaTime))
        {
            pointsInTime.RemoveAt(pointsInTime.Count - 1);
        }

        pointsInTime.Insert(0, transform.position);
    }
    IEnumerator Reset() {
        past_way.play = false;
        yield return new WaitForSeconds(0.1f);
        transform.position = pointsInTime[pointsInTime.Count - 1];
        past_way.play = true;
        Instantiate(pastplayer);
    }
}

