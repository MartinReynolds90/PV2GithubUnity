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

    //public UnityEvent<int> OnLivesChanged;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            jugador = collision.gameObject.GetComponent<Jugador>();
            jugador.ModificarVida(-puntos);
   
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
            Debug.Log("PUNTOS DE DAÑO REALIZADOS " + puntos);
        }

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (!collision.gameObject.CompareTag("Meta")) { return; }

    //    Debug.Log("GANASTE");
    //}
    //public void LoseLife()
    //{
    //    lives--;
    //    OnLivesChanged.Invoke(lives);

    //    if (lives <= 0)
    //    {
    //        // Aquí puedes manejar la situación de Game Over
    //    }
    //}
}