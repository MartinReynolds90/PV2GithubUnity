using UnityEngine;

public class DestruirProyectilPorTiempo : MonoBehaviour
{
    [SerializeField] private float tiempoVida;//tiempo de vida del proyectil}

    void OnEnable()
    {
        Invoke(nameof(Desactivar), tiempoVida);
    }

    void Desactivar() {
        gameObject.SetActive(false);
    }

    void OnDisable()
    {
        CancelInvoke();     
    }
}
