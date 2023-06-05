using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireParticleHandler : MonoBehaviour
{
    public Light fireLight;
    bool isZero;
    private void Start()
    {
        fireLight = GameObject.Find("Point Light").GetComponent<Light>();
    }
    
    // Chech if light of fire's intensty is zero
    private bool CheckIfIndenstyZero()
    {
        isZero = fireLight.intensity <= 0 ? true : false;
        return isZero;
    }

    // Stop particle if intensity is zero otherwise active it
    public void StopPartcile()
    {
        if (CheckIfIndenstyZero() == true)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);
    }
}
