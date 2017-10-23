using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : PooledMonoBehaviour {

    [SerializeField]
    private float speed = 10.0f;

    // Update is called once per frame
    void Update() {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}
