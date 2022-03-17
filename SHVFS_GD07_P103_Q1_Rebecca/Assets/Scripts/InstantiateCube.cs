using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{

    float timer;
    public float duration;
    public GameObject cube;

    // Update is called once per frame
    void Update()
    {
        if (timer < duration)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(cube);
            timer = 0;
        }

    }
}
