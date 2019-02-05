using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

    Rigidbody2D rb;
    Rocket r;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        r = GameObject.FindGameObjectWithTag("Player").GetComponent<Rocket>();
    }

    // Update is called once per frame
    void Update()
    {
        if (r.isOn)
        {
            r.rb.AddForce((transform.position - r.transform.position) * 0.25f);
        }
    }
}
