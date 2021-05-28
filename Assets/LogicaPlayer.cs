using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPlayer : MonoBehaviour
{
    private Animator anim;
    public bool estoyatacando;
 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || estoyatacando== true)
        {
            Furia();
        }
    }
    public void Furia()
    {
        anim.SetTrigger("Golpeo");
        estoyatacando = false;
    }
}
