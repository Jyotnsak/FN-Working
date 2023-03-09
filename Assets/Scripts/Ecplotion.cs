using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ecplotion : MonoBehaviour
{
    public void Explode()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(gameObject, exp.main.duration);
    }

}
