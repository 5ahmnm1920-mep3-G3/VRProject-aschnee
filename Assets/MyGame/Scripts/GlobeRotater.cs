using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobeRotater : MonoBehaviour
{
    public Animation globeRotation;
    public AudioSource winAudio;
    public int crystalsCollected = 0;
    public KeyCode restartButton = KeyCode.Escape;

    private void Update()
    {
        if (crystalsCollected >= 3)
        {
            globeRotation.Play();
            winAudio.Play();
        }

        if (Input.GetKeyDown(restartButton))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
