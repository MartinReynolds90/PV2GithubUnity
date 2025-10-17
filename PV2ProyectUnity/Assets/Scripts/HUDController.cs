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
    [SerializeField] public UnityEvent OnTextoCondicion;

    //00000000000000------MENU-------000000000000000000000000000000
    [SerializeField] private GameObject PanelFinJuego;

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
