using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NuevoPerfilJugador", menuName = "SO/PerfilJugador")]
public class PerfilJugador : ScriptableObject
{
    [SerializeField]
    float velocidad = 5f;
    public float Velocidad{ get => velocidad; set => velocidad = value; }

    [SerializeField]
    private float fuerzaSalto = 5f;
    public float FuerzaSalto { get => fuerzaSalto; set => fuerzaSalto = value; }

    [SerializeField]
    [Range(10, 50)]
    private int experienciaProximoNivel;

    public int ExperienciaProximoNivel { get => experienciaProximoNivel; set => experienciaProximoNivel = value; }

    [SerializeField]
    [Range(10, 2000)]
    private int escalarExperiencia;

    public int EscalarExperiencia { get => escalarExperiencia; set => escalarExperiencia = value; }

    private int nivel;
    public int Nivel { get => nivel; set => nivel = value; }

    private int experiencia;

    public int Experiencia{ get => experiencia; set => experiencia = value; }
}
