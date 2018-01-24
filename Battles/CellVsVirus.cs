using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CellVsVirus : MonoBehaviour {

    private bool continuar = false;
    public GameObject objetivo;
    public GameObject linfoB;
    Animator anim;
    private float dist_cell;
    public bool virusActivo = true;
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
       dist_cell = Vector3.Distance(objetivo.transform.position, transform.position);
       if (dist_cell < 15 && objetivo.tag == "celula")
       {
            virusActivo = false;
            anim.SetBool("boolCell", true);
            success = true;
            if (!continuar)
            {
                mostrarTexto.Invoke();
                continuar = true;
            }

        }
    }
}
