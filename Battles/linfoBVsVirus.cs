using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class linfoBVsVirus : MonoBehaviour
{
    private bool continuar = false;
    public CellVsVirus cellvsvirus;
    public GameObject objetivo;
    Animator anim;
    private float dist;
    public bool success = false;
    public UnityEvent mostrarTexto;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cellvsvirus.virusActivo)
        {
            dist = Vector3.Distance(objetivo.transform.position, transform.position);
            if (dist < 15 && objetivo.tag == "virus")
            {
                anim.SetBool("muertePorVirus", true);
                success = true;
                if (!continuar)
                {
                    mostrarTexto.Invoke();
                    continuar = true;
                }

            }
        }
    }
}
