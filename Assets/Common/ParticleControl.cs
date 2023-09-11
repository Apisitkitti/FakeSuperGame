using System;
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
    public ParticleSystem  RainSystem;
    public ParticleSystem SnowSystem;
    public Slider minParticleSlider;
    public Slider RainParticleSlider;
    public Slider SnowParticleSlider;

    void Update()
    {
      ParticleAmount();
      SnowParticle();
      RainParticle();
    }
    void ParticleAmount()
    {
        particleSystem.maxParticles = Mathf.RoundToInt(minParticleSlider.value);

    }

    void SnowParticle()
    {
      SnowSystem.maxParticles = Mathf.RoundToInt(SnowParticleSlider.value);
    }

    void RainParticle()
    {
      RainSystem.maxParticles = Mathf.RoundToInt(RainParticleSlider.value);
    }
}
}
