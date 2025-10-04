using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;//agrego el .Events para poder usar eventos

public class Jugador : MonoBehaviour
{
    [Header("Configuracion")]
    //<<<<<<< Updated upstream
    [SerializeField] private int vida = 5;
    [SerializeField] private UnityEvent<int> OnLivesChanged;//declaro un evento tipo entero para avisar cuando se modifiquen las vidas
    [SerializeField] private UnityEvent<string> OnTextChanged;//lo mismo pero para cambiar el texto de las vidas
    [SerializeField] private UnityEvent OnVelocidadCero;//////////////////////
    [SerializeField] private UnityEvent OnSaltoStop;//-----------------------
    [SerializeField] private UnityEvent<string> OnTextFin;//(((((((((((((((((
    private void Start()
    {
         OnLivesChanged.Invoke(vida);//inicializo los eventos con invoke
         OnTextChanged.Invoke(vida.ToString());
        
    }
//=======
    //[SerializeField] private int vida = 5;


//>>>>>>> Stashed changes
    // Update is called once per frame
    public void ModificarVida(int puntos)
    {
        vida += puntos;
        Debug.Log(EstasVivo());
    }
    private bool EstasVivo() {
        return vida > 0;
    }
    public int GetVidas()
    {
        if (vida <= 0) {
            OnVelocidadCero.Invoke();/////////////////////////////////////
            OnTextFin.Invoke("GAME OVER");//((((((((((((((((((((((((((((((((
            OnSaltoStop.Invoke();//-----------------------------------
            Debug.Log("GAME OVER");
        }
        return vida;
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (!collision.gameObject.CompareTag("Meta")) { return; }
        OnVelocidadCero.Invoke();//////////////////////////////////////////
        OnTextFin.Invoke("GANASTE");//(((((((((((((((((((((((((((((((((((((((
        OnSaltoStop.Invoke();//-----------------------------------
        Debug.Log("GANASTE");
        
    }

}
