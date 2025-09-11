using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;//agrego el .Events para poder usar eventos

public class Jugador : MonoBehaviour
{
    [Header("Configuracion")]
    [SerializeField] private int vida = 12;
    [SerializeField] private UnityEvent<int> OnLivesChanged;//declaro un evento tipo entero para avisar cuando se modifiquen las vidas
    [SerializeField] private UnityEvent<string> OnTextChanged;//lo mismo pero para cambiar el texto de las vidas


    private void Start()
    {
        OnLivesChanged.Invoke(vida);//inicializo los eventos con invoke
        OnTextChanged.Invoke(vida.ToString());
    }
    // Update is called once per frame
    public void ModificarVida(int puntos)
    {
        vida += puntos;
        OnTextChanged.Invoke(vida.ToString());
        Debug.Log(EstasVivo());
    }
    private bool EstasVivo() {
        return vida > 0;
    }
    public int GetVidas()
    {
        return vida;
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (!collision.gameObject.CompareTag("Meta")) { return; }

        Debug.Log("GANASTE");
        
    }
}
