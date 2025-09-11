using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;//Para usar TextMeshPro

public class HUDController : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI miTexto;//creo un texto TextMeshPro

    public void ActualizaVidas(string VidasActualizadas) {
        Debug.Log("SE LLAMA " + VidasActualizadas);
        miTexto.text = "Vidas: " + VidasActualizadas;
    }
}
