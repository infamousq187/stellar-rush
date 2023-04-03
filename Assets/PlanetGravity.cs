using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public GameObject planet;
    Rigidbody2D rb;
    public float gravityForce;
    public float gravityDistance;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, planet.transform.position);
        Vector3 v = planet.transform.position- transform.position;
        rb.AddForce(v.normalized * (1.0f - dist/gravityDistance) * gravityForce);

    }
}
