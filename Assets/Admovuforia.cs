using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Admovuforia : MonoBehaviour
{
    public GameObject Tutorial;
    public GameObject Experiencia;
    public GameObject Reproductor;
    public GameObject Boton_Play;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Mostrar()
    {
        //Tutorial.SetActive(true);
        Experiencia.SetActive(false);
        //reiniciando
        Reproductor.GetComponent<VideoPlayer>().Stop();
        Reproductor.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 0);
        Boton_Play.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);//reiniciar boton
    }
    public void Ocultar()
    {
      // Tutorial.SetActive(false);
       Experiencia.SetActive(true);
       

    }
}
