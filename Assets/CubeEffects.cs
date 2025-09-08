using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEffects : MonoBehaviour
{
    public ParticleSystem explodeFX;

    public void PlayFX()
    {
        if(explodeFX != null){
            ParticleSystem fx = Instantiate(explodeFX, transform.position, Quaternion.identity);
            //fx.Play();
            //Destroy(fx.gameObject, fx.main.duration);
        }
    }

    public void HideCube(){
        gameObject.SetActive(false);
    }
}
