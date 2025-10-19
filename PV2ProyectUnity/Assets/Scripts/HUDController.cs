using System.Collections;
using System.Collections.Generic;
using TMPro;//Para usar TextMeshPro
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class HUDController : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI miTexto;//creo un texto TextMeshPro


    [SerializeField] private GameObject PanelPausa;
    [SerializeField] private TextMeshProUGUI textoDescripcion;

    private bool pausado = false;


    [SerializeField] private GameObject PanelFinJuego;

    private void Start()
    {
        if (miTexto != null && !miTexto.gameObject.activeInHierarchy)
        {
            miTexto.gameObject.SetActive(true);
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (pausado)
            {
                ContinuarJuego();
            }
            else {
                PausarJuego();
            }
        }
    }

    public void PausarJuego() {
        PanelPausa.SetActive(true);
        Time.timeScale = 0f;
        pausado = true;
        textoDescripcion.text = "Consigue escapar de este lugar, busca una de las cuevas para salir. Pero con cuidado, estan infectadas de enemigos. En el camino encontraras posiones de curacion, usalas con F1. Ten cuidado con las rocas lanzadas por el Jefe.";
    }
    public void ContinuarJuego() {
        PanelPausa.SetActive(false);
        Time.timeScale = 1f;
        pausado = false;
    }
    
    //00000000000000------MENU-------000000000000000000000000000000
    public void MostrarMenu()
    {
        Debug.Log("MOSTRANDO PANELFINJUEGO");
        PanelFinJuego.SetActive(true);//activo el PanelfinJuego
        Time.timeScale = 0f;
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("reiniciando");
    }
    public void Salir()
    {
        Debug.Log("Cerrando");
        Application.Quit();
    }

    //000000000000000000000000000000000000000000000000000000000000000
 
    public void ActualizaTexto(string TextoActualizado) {
        Debug.Log("SE LLAMA " + TextoActualizado);
        miTexto.text = "Vidas: " + TextoActualizado;

    }


}
