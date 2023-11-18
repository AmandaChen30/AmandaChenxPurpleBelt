using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_explosion : MonoBehaviour
{

    public GameObject explosion;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
