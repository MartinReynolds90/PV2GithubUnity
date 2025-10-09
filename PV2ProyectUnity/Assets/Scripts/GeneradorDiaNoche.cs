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
        Color colorDestino = camara.backgroundColor == colorDia ? colorNoche : colorDia;
        float duracionCiclo = tiempo * 0.6f;
        float duracionCambio = tiempo * 0.4f;

        for (int i = 0; i< duracionDia; i++) { 
            yield return new WaitForSeconds(tiempo);

            float tiempoTranscurrido = 0;

            while (tiempoTranscurrido < duracionCambio) {
                tiempoTranscurrido += Time.deltaTime;
                float t = tiempoTranscurrido / duracionCambio;

                float smoothT = Mathf.SmoothStep(0f, 1f, t);//suavisa t
                camara.backgroundColor = Color.Lerp(camara.backgroundColor, colorDestino, smoothT);
                yield return null;
            }

            colorDestino = camara.backgroundColor == colorDia ? colorNoche : colorDia;
        }
    }
}

