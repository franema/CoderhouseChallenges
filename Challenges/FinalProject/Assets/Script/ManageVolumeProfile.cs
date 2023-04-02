using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ManageVolumeProfile : MonoBehaviour
{
    [SerializeField] private VolumeProfile m_profile;
    [SerializeField] private Timer m_timer;
    private ClampedFloatParameter deadSat = new ClampedFloatParameter(-100, -100, 100, false);
    private ClampedFloatParameter aliveSat = new ClampedFloatParameter(100, -100, 100, false);



    private void Start()
    {
        SetVignette(0.22f, false);
        SetSaturation(aliveSat);
        m_timer.onTimeOver += OnTimeOverHandler;
    }

    private void Update() 
    {
        if(GameManager.instance.timeLeft < 20)
        {
            SetVignette(2/GameManager.instance.timeLeft, true);
        }
    }
    private void SetVignette(float p_intensity, bool isActive)
    {
        if (m_profile.TryGet(out Vignette p_vignette))
        {
            p_vignette.color.overrideState = isActive;
            p_vignette.intensity.Override(p_intensity);
        }
    }

    private void OnTimeOverHandler()
    {
        SetSaturation(deadSat);
    }

    private void SetSaturation (ClampedFloatParameter satToSet)
    {
        if(m_profile.TryGet(out ColorAdjustments colorAdjustments))
        {
            colorAdjustments.saturation.SetValue(satToSet);
        }
    }
}
