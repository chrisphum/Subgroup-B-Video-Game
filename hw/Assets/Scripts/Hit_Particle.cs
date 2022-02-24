using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Particle : MonoBehaviour
{
    public Transform sparkle;

    // Start is called before the first frame update
    void Start()
    {
        sparkle.GetComponent<ParticleSystem>().enableEmission = false;
    }

    void OnTriggerEnter()
    {
        sparkle.GetComponent<ParticleSystem>().enableEmission = true;
        StartCoroutine(stopSparkles());
    }
    IEnumerator stopSparkles()
    {
        yield return new WaitForSeconds(.4f);
        sparkle.GetComponent<ParticleSystem>().enableEmission = false;
    }

}
