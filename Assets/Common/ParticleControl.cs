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

    private void Start()
    {
        // กำหนดค่าเริ่มต้นของ Slider เป็นค่า Min Particle ปัจจุบันของ Particle System
        var emission = particleSystem.emission;
        minParticleSlider.value = emission.rateOverTime.constant;
    }

    public void SetMinParticles(float value)
    {
        // เมื่อมีการเปลี่ยนค่าของ Slider ให้อัปเดต Min Particle ของ Particle System
        var emission = particleSystem.emission;
        var rateOverTime = emission.rateOverTime;
        rateOverTime.constant = value;
        emission.rateOverTime = rateOverTime;
    }
}
}
