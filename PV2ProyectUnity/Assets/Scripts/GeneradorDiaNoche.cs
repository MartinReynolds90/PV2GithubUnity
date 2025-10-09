using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Camera camara;
    [SerializeField] private Color colorNoche;

    [SerializeField][Range(4 ,128)] private float duracionDia;
    [SerializeField][Range(4, 24)] private int dias;
   
    private Color colorDia;

    void Start()
    {
        colorDia = camara.backgroundColor;
        StartCoroutine(CambiarColor(duracionDia));
    }

    
    IEnumerator CambiarColor(float tiempo)
    {
        for(int i = 0; i< duracionDia; i++) { 
            yield return new WaitForSeconds(tiempo);
            camara.backgroundColor = camara.backgroundColor == colorDia ?
                                      camara.backgroundColor = colorNoche :
                                      camara.backgroundColor = colorDia;
            
        }
    }
}

