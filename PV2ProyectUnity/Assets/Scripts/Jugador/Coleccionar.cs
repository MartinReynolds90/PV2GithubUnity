using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionar : MonoBehaviour
{
  
    [SerializeField] private GameObject Bolsa;
    [SerializeField] private Transform padreObjetivos;

    private Queue<GameObject> objetivos;
    private Stack<GameObject> items;

    private Progresion progresionJugador;

    private bool presionado = false;

    private void Awake()
    {
        objetivos = new Queue<GameObject>();
        items = new Stack<GameObject>();

        CargarObjetivos();
        VerObjetivos();

        progresionJugador = GetComponent<Progresion>();
   

    }

    private void CargarObjetivos() {
        foreach (Transform objetivo in padreObjetivos) {
            objetivos.Enqueue(objetivo.gameObject);
        }

    }
    private void VerObjetivos() {
        foreach (GameObject objetivo in objetivos) {
            Debug.Log(objetivo.name);
        }
    }
    private bool EsObjetivoActual(GameObject objetivoActual, GameObject objetivoReal) {
        return objetivoActual == objetivoReal;
    }
    private void OnTriggerEnter2D(Collider2D colision)
    {


        if (!colision.gameObject.CompareTag("Coleccionables")) { return; }
        if (objetivos.Count == 0) { return; }//SI la lista esta vacia

        GameObject objetivo = objetivos.Peek(); //Obtiene la referencia al objeto sin sacarlo de la cola



        if (EsObjetivoActual(colision.gameObject, objetivo)) {
            objetivo.SetActive(false);
            objetivos.Dequeue(); //Quita el elemento de la cola a diferencia del Peek();
            items.Push(objetivo);

            VerObjetivos();
            objetivo.transform.SetParent(Bolsa.transform);

            progresionJugador.GanarExperiencia(10);

        }
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Debug.Log("Elementos en la lista: " + progresionJugador.Nivel);
            if (items.Count > 0)
            {
                UsarItem();
            }
            else {
                Debug.LogWarning("No hay mas elementos");
            }
        }

    }

    private void UsarItem()
    {
        GameObject item = items.Pop();
        item.transform.SetParent(null);
        item.SetActive(true);
    }

}
