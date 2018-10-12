using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    public float StartTime;
    // Use this for initialization
    void Start()
    {
        StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = StartTime + Time.time;
        //Visar på skärmen hur lång tid som gått
        string minutes = ((int)t / 60).ToString();
        //Visar hur många minuter som gått
        string seconds = (t % 60).ToString("f2");
        //Visar hur många sekunder som gått.
        TimerText.text = minutes + ":" + seconds;
    }
}
