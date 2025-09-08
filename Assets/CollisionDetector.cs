using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    public GameObject vfx;
    public AudioSource mySound;

    void OnTriggerEnter(Collider other){
        Instantiate(vfx, transform.position, transform.rotation);
        mySound.Play();
        Destroy(other.gameObject);
    }
}
