using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Reproductor : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayCanvas()
    {
        

    }
   /* //VideoPlayer es la variable del video
    IEnumerator FadeIn()
    {
        //antes
        float a = 0;
        while (a < 1)
        {
            //durante
            a += Time.deltaTime; //incrementando el valor del alpha
                                 //Hacer Vsible el objeto
            videoPlayer.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, a);
            yield return null;
        }
        //despues
        //Hacer Vsible el objeto
        videoPlayer.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 1);

    }
    IEnumerator FadeUp()
    {
        //antes
        float a = 1;
        while (a < 1)
        {
            //durante
            a += Time.deltaTime; //incrementando el valor del alpha
                                 //Hacer Vsible el objeto
            videoPlayer.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, a);
            yield return null;
        }
        //despues
        //Hacer Vsible el objeto
        videoPlayer.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 1);

    }*/
}
