using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [Header("Configuracion")]
    [SerializeField] private float vida = 5f;
    

    // Update is called once per frame
    public void ModificarVida(float puntos)
    {
        vida += puntos;
    }
    private bool EstasVivo() {
        return vida > 0;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (!collision.gameObject.CompareTag("Meta")) { return; }

        Debug.Log("GANASTE");
        
    }
}
