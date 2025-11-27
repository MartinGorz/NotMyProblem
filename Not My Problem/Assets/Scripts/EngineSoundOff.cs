using Unity.VisualScripting;
using UnityEngine;

public class EngineSoundOff : MonoBehaviour
{

    public ParticleSystem fire;
    public AudioSource engineAudio;

    private bool wasPlaying;


    // Update is called once per frame
    void Update()
    {
        bool fireIsOn = fire.isPlaying;

        if (fireIsOn && engineAudio.isPlaying)
        {
            engineAudio.Pause();
        }

        else if (!fireIsOn && !engineAudio.isPlaying)
        {
            engineAudio.UnPause();



        }
    }
}
