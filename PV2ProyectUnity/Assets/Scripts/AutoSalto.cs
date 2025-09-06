using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSalto : MonoBehaviour
{
    //variables a configurar desde eleditor
    [Header("Configuracion")]
    [SerializeField] private float fuerzaSalto = 5f;

    private Rigidbody2D miRigitbody2D;
    //codigo ejecutado cuando el objeto se activa en el nivel
    // Update is called once per frame
    private void OnEnable()
    {
        miRigitbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        miRigitbody2D.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
    }
}
