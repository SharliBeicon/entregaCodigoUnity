using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{

    private void OnTriggerEnter(Collider objBad)
    {
        if(objBad.gameObject.tag == "bacteria")
            objBad.GetComponent<Animation>().Play();
    }

    private void OnTriggerExit(Collider objBad)
    {
        if (objBad.GetComponent<Animation>().IsPlaying("ReduceTam"))
            objBad.GetComponent<Animation>().Stop();
    }
}
