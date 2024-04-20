using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;

public class AudioMixerController : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    
    public void BgmToggle(bool on)
    {
        if(on) audioMixer.SetFloat("BGM", 0);
        else audioMixer.SetFloat("BGM", -80);
    }

    public void SFXToggle(bool on)
    {
        if (on) audioMixer.SetFloat("SFX", 0);
        else audioMixer.SetFloat("SFX", -80);
    }

}
