using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    public AudioSource AudioSource;
    private float GameVolume = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();
    }

    // Update is called once per frame
    // sound update per FPS
    void Update()
    {
        AudioSource.volume = GameVolume;

    }
    // Slider button
    public void VolumeUpdater(float volume)
    {
        GameVolume = volume;
    }
}
