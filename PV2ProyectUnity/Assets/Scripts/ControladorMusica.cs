using UnityEngine;

public class ControladorMusica : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip musicaVictoria;
    [SerializeField] private AudioClip musicaDerrota;

    public void MusicaVictoria() {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        audioSource.loop = false;//desactivo el loop para que suene una sola vez
        audioSource.clip = musicaVictoria;
        audioSource.Play();
    }
    public void MusicaDerrota()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        audioSource.loop = false;//desactivo el loop para que suene una sola vez
        audioSource.clip = musicaDerrota;
        audioSource.volume = 0.3f;
        audioSource.Play();
    }
}
