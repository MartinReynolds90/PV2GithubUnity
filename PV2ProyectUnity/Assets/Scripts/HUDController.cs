using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;//Para usar TextMeshPro

public class HUDController : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI miTexto;//creo un texto TextMeshPro
    [SerializeField] public UnityEvent OnTextoCondicion;

    public void ActualizaTexto(string TextoActualizado) {
        Debug.Log("SE LLAMA " + TextoActualizado);
        miTexto.text = "Vidas: " + TextoActualizado;
    }

    public void TextoFinJuego(string TextoCondicionJuego) { //((((((((((((((((((
        Debug.Log(TextoCondicionJuego);
        miTexto.text = TextoCondicionJuego;
    }

}
