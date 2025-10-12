using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herir : MonoBehaviour
{
    // Variables a configurar desde el editor
    [Header("Configuracion")]
    [SerializeField] int puntos = 5;

    public HUDController hud;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Jugador jugador = collision.gameObject.GetComponent<Jugador>(); 
            jugador.ModificarVida(-puntos);
            Debug.Log(" PUNTOS DE DAÑO REALIZADOS AL JUGADOR " + puntos);
            gameObject.SetActive(false);
            if (hud == null)
            {
                hud = GameObject.Find("HUD").GetComponent<HUDController>();
                Debug.Log("HUD = NULL---HUD = NULL--HUD = NULL ");
            }

            if (hud != null)
            {
                hud.ActualizaTexto(jugador.GetVidas().ToString()); //  las vidas actuales
                Debug.Log("HUD != NULL/////HUD != NULL////HUD != NULL ");
            }
            else
            {
                Debug.LogWarning("HUDController no encontrado");
            }

        }
    }
}
