using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class past_way : MonoBehaviour
{
    List<Vector2> pointsInTime;
    List<Vector2> temporary;
    public static bool play;
    public bool teste;
    // Start is called before the first frame update
    void Start()
    {
        if (pointsInTime == null)
        {
            pointsInTime = new List<Vector2>(Time_travel.pointsInTime);
            temporary = new List<Vector2>(pointsInTime);
            Time_travel.pointsInTime.Clear();
            play = true;
            teste = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (play==false) { teste = true; transform.position = pointsInTime[pointsInTime.Count - 1]; temporary = new List<Vector2>(pointsInTime); }
        if (play && teste)
        {
            past_walk();
        }
    }

    void past_walk() {
        if (temporary.Count > 0)
        {
            transform.position = temporary[temporary.Count - 1];
            temporary.RemoveAt(temporary.Count - 1);
        }
        else
        {
            temporary = new List<Vector2>(pointsInTime);
            teste = false;
        }
    }
}
