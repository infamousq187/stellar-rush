using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10;
    public GameObject target;
    public Vector3 direction = Vector3.up;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, direction, speed * Time.deltaTime);
    }
}
