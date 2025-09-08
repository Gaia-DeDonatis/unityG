using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCubes());
    }
    IEnumerator SpawnCubes(){
        while(true){
            Instantiate(cubePrefab);
            yield return new WaitForSeconds(3f);
        }
    }

   
}
