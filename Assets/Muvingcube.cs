using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muvingcube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * 0.8f * Time.deltaTime;
    }
}
