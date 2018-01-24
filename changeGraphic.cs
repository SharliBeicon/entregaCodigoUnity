using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeGraphic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void resolucionBaja()
    {
        QualitySettings.SetQualityLevel(0);
    }

    public void resolucionMedia()
    {
        QualitySettings.SetQualityLevel(2);
    }

    public void resolucionAlta()
    {
        QualitySettings.SetQualityLevel(5, true);
    }

}
