using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progresion : MonoBehaviour
{
    private int nivel;
    public int Nivel { get => nivel; }

    private int experiencia;

    [SerializeField]
    [Range(10,50)]
    private int experienciaProximoNivel;

    [SerializeField]
    [Range(10, 2000)]
    private int escalarExperiencia;

  

    public void GanarExperiencia(int nuevaExperiencia) {
        experiencia += nuevaExperiencia;
        
        if (experiencia >= experienciaProximoNivel) {
            SubirNivel();
        }
    }

    private void SubirNivel() {
        nivel++;
        experiencia -= experienciaProximoNivel;
        experienciaProximoNivel += escalarExperiencia;
    }
}
