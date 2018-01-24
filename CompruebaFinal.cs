using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CompruebaFinal : MonoBehaviour {

    public UnityEvent mostrarBoton;
    public ManageScore final;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(final.score == 6)
        {
            mostrarBoton.Invoke();
        }
	}
}
