using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auracontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextbutton.resetAura == "y")
        {
            GetComponent<ParticleSystem>().Stop();
        }

        if (nextbutton.resetAura == "n")
        {
            GetComponent<ParticleSystem>().Play();
        }

    }
}
