using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayLight : MonoBehaviour
{
    public float rate = 30;
    // Start is called before the first frame update
    void Start()
    {
        rate *= Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rate, rate, rate);
    }
}
