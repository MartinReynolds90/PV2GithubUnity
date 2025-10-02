using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    //[SerializeField] float velocidad = 5f;
    [SerializeField]
    private PerfilJugador perfilJugador;

    // Variables de uso interno en el script
    private float moverHorizontal;
    private Vector2 direccion;
    

    // Variable para referenciar otro componente del objeto
    private Rigidbody2D miRigidbody2D;
    public void detenerMovimiento() {///////////////////////////////////
        perfilJugador.Velocidad = 0f;
    }
    // Codigo ejecutado cuando el objeto se activa en el nivel
    private void OnEnable()
    {
        miRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Codigo ejecutado en cada frame del juego (Intervalo variable)
    private void Update()
    {
        moverHorizontal = Input.GetAxis("Horizontal");
        direccion = new Vector2(moverHorizontal, 0f);
    }
    private void FixedUpdate()
    {
        miRigidbody2D.AddForce(direccion * perfilJugador.Velocidad);
    }

}
