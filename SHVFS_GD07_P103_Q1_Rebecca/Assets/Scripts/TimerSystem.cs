using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSystem : MonoBehaviour
{
    float timer;
    public float duration;

    // Update is called once per frame
    void Update()
    {
        if (timer < duration)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Debug.Log("hello");
            timer = 0;
        }

    }
}
