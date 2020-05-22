using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    Rigidbody rdb;
    public GameObject fxPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rdb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        rdb.isKinematic = true;

        if (rdb.isKinematic)
            Explode();
    }

    void Explode()
    {
        Instantiate(fxPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
