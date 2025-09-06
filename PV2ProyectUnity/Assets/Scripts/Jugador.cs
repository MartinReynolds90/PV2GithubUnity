using System.Collections;
using System.Collections.Generic;
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
}
