using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    public GameObject vfx;

    void OnTriggerEnter(Collider other){
        Instantiate(vfx, transform.position, transform.rotation);
        Destroy(other.gameObject);
    }
}
