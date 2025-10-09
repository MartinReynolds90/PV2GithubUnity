using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObjetoAleatorio : MonoBehaviour
{                            //ARREGLO//
    [SerializeField] private GameObject[] objetoPrefabs;

    [SerializeField]
    [Range(0.5f, 5f)]
    private float tiempoEspera;

    [SerializeField]
    [Range(0.5f, 5f)]
    private float tiempoIntervalo;


    void Start()
    {
        //Debug.Log("GeneradorObjetoAleatorio activo en: " + gameObject.name);


        //InvokeRepeating(nameof(GenerarObjetoAleatorio), tiempoEspera, tiempoIntervalo);
    }

    // Update is called once per frame
    void GenerarObjetoAleatorio()
    {
        int indexAleatorio = Random.Range(0, objetoPrefabs.Length);//elige un indice aleatorio utilizando el largo del arreglo y el inicio(0) y lo guarda en la variable local indexaleatorio
        GameObject prefabAleatorio = objetoPrefabs[indexAleatorio];//guarda en un objeto local el objeto del arreglo que indica el indice indexAleatorio
        Instantiate(prefabAleatorio, transform.position, Quaternion.identity);
    }

    private void OnBecameInvisible()
    {
        Debug.Log("El spriteRender deja de ser vidible por las camaras en la escena");
        CancelInvoke(nameof(GenerarObjetoAleatorio));
    }

    private void OnBecameVisible()
    {
        Debug.Log("El spriteRende es visible por las camaras en la escena");
        InvokeRepeating(nameof(GenerarObjetoAleatorio), tiempoEspera, tiempoIntervalo);
    }
}

