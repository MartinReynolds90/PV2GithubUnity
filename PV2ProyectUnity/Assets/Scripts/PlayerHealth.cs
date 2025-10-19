using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]private int puntos = 1;
    public Jugador jugador;
    public HUDController hud;

    private void Awake()
    {
        if (hud == null) {
            hud = GameObject.Find("HUD").GetComponent<HUDController>();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            jugador = collision.gameObject.GetComponent<Jugador>();
            jugador.ModificarVida(-puntos);
           

            if (hud != null)
            {
                hud.ActualizaTexto(jugador.GetVidas().ToString()); //  las vidas actuales
            }
            else
            {
                Debug.LogWarning("HUDController no encontrado");
            }
            Debug.Log("PUNTOS DE DAÑO REALIZADOS " + puntos);
        }

    }

}