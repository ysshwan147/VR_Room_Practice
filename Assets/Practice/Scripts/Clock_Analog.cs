using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock_Analog : MonoBehaviour
{ 
    [SerializeField] private GameObject clock_hour;
    [SerializeField] private GameObject clock_minute;
    [SerializeField] private GameObject clock_second;

    private Transform clock_hour_t;
    private Transform clock_minute_t;
    private Transform clock_second_t;

    private DateTime localDate;

    private float hour;
    private float minute;
    private float second;

    // Start is called before the first frame update
    void Start()
    {
        clock_hour_t = clock_hour.transform;
        clock_minute_t = clock_minute.transform;
        clock_second_t = clock_second.transform;
    }

    // Update is called once per frame
    void Update()
    {
        setClock();
    }

    
    private void setClock()
    {
        localDate = DateTime.Now;

        hour = localDate.Hour;
        minute = localDate.Minute;
        second = localDate.Second;

        clock_hour_t.rotation = Quaternion.Euler(30 * hour, 0, 0);
        clock_minute_t.rotation = Quaternion.Euler(6 * minute, 0, 0);
        clock_second_t.rotation = Quaternion.Euler(6 * second, 0, 0);
    }
}
