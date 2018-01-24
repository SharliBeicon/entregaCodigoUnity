using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VirusVsCell : MonoBehaviour {

    private bool continuar1 = false, continuar = false;
    public GameObject objetivo;
    public GameObject linfoB;
    Animator anim;
    private float dist, dist_linfo;
    private bool cellInfectada = false;
    public bool success1 = false;
    public bool cura = false;
    public UnityEvent mostrarTexto, mostrarTexto1;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(objetivo.transform.position, transform.position);
        if (dist < 15 && objetivo.tag == "virus")
        {
            success1 = cellInfectada = true;
            anim.SetBool("infectada", true);
            if (!continuar1)
            {
                mostrarTexto1.Invoke();
                continuar1 = true;
            }

        }

        dist_linfo = Vector3.Distance(linfoB.transform.position, transform.position);
        if (dist_linfo < 15 && cellInfectada)
        {
            cura = true;
            anim.SetBool("desinfectada", true);
            if (!continuar)
            {
                mostrarTexto.Invoke();
                continuar = true;
            }

        }


    }
}
