using UnityEngine;
using System.Collections;

public class PlayMovieOnSpace : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {

            Renderer r = GetComponent<Renderer>();
            AudioSource audio = GetComponent<AudioSource>();
            MovieTexture movie = (MovieTexture)r.material.mainTexture;

            if (movie.isPlaying)
            {
                movie.Pause();
                audio.Pause();
            }
            else {
                movie.Play();
                audio.Play();
            }
        }
    }
}
