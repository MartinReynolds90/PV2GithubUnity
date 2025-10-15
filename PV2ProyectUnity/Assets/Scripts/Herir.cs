using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herir : MonoBehaviour
{
    // Variables a configurar desde el editor
    [Header("Configuracion")]
    [SerializeField] int puntos = 5;

    public HUDController hud;
    [SerializeField] private AudioClip golpeSFX;//sonido de golpe



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Jugador jugador = collision.gameObject.GetComponent<Jugador>(); 
            jugador.ModificarVida(-puntos);
            GameObject.Find("Musica").GetComponents<AudioSource>()[1].PlayOneShot(golpeSFX);

            Debug.Log(" PUNTOS DE DAÑO REALIZADOS AL JUGADOR " + puntos);//mensaje en consola
            gameObject.SetActive(false);//desactiva el objeto que colisiona con el jugador
         


            if (hud == null)
            {
                hud = GameObject.Find("HUD").GetComponent<HUDController>();
                Debug.Log("HUD = NULL---HUD = NULL--HUD = NULL ");
            }

            if (hud != null)
            {
                hud.ActualizaTexto(jugador.GetVidas().ToString()); // Actualiza el texto de vidas
                Debug.Log("HUD != NULL/////HUD != NULL////HUD != NULL ");
            }
            else
            {
                Debug.LogWarning("HUDController no encontrado");
            }

        }
    }
}
