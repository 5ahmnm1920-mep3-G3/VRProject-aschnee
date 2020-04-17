using UnityEngine;

public class GlobeRotater : MonoBehaviour
{
    public Animation globeRotation;
    public AudioSource winAudio;
    public int crystalsCollected = 0;

    private void Update()
    {
        if (crystalsCollected >= 3)
        {
            globeRotation.Play();
            winAudio.Play();
        }
    }
}
