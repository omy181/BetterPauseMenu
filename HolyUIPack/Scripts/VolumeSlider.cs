using Holylib.HolySoundEffects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] MenuSliderSection slider;
    [SerializeField] string volumeName;
    void Start()
    {
        slider.OnValueSet += ChangeVolume;

        ChangeVolume(PlayerPrefs.GetFloat(slider.Save_Name));
    }

    public void ChangeVolume(float value)
    {
        SoundEffectController.SetVolume(value, volumeName);
    }
}
