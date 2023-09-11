using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhEngine.Core;
using UnityEngine.UI;
using UnityEngine.Rendering.Universal;
namespace SuperGame
{
public class ParticleControl : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public Slider minParticleSlider;
    void Update()
    {
      ParticleAmount();
    }
    void ParticleAmount()
    {
        particleSystem.maxParticles = Mathf.RoundToInt(minParticleSlider.value);

    }
}
}
