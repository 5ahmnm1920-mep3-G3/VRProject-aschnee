using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobeRotater : MonoBehaviour
{
    public Animation globeRotation;
    public AudioSource winAudio;
    public AudioSource[] ambientAudio;
    public int crystalsCollected = 0;
    public KeyCode restartButton = KeyCode.Escape;

    private void Update()
    {
        if (crystalsCollected >= 3)
        {
            globeRotation.Play();
            winAudio.Play();

            foreach (AudioSource source in ambientAudio)
            {
                source.Pause();
            }
        }

        if (Input.GetKeyDown(restartButton))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
