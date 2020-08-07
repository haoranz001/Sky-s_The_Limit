using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonFloat : MonoBehaviour
{
    // Start is called before the first frame update
    public float RandomRotation;
    public float RandomForce;
    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<Rigidbody>().AddForce(Vector3.up * RandomForce);
        transform.Rotate(RandomRotation, RandomRotation, RandomRotation);
    }
}
