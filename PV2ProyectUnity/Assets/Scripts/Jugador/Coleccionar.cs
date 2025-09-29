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

    private bool presionado = false;

    private void Awake()
    {
        objetivos = new Queue<GameObject>();
        items = new Stack<GameObject>();
        CargarObjetivos();
        VerObjetivos();

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

        Debug.Log("Colisionó con: " + colision.gameObject.name);
        Debug.Log("Objeto raíz: " + colision.transform.root.name);
        Debug.Log("Objetivo esperado: " + objetivo.name);

        if (EsObjetivoActual(colision.gameObject, objetivo)) {
            objetivo.SetActive(false);
            objetivos.Dequeue(); //Quita el elemento de la cola a diferencia del Peek();
            items.Push(objetivo);
            VerObjetivos();
            objetivo.transform.SetParent(Bolsa.transform);
        }
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1)) {
            if (items.Count == 0) return;
            items.Pop();
            UsarItem();
        }
    }

    private void UsarItem()
    {
        GameObject item = items.Pop();
        item.transform.SetParent(null);
        item.SetActive(true);
    }
}
