using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhEngine.Core;
using UnityEngine.Rendering.Universal;
namespace SuperGame
{
    public class PlayerlightManager: MonoBehaviour
    {   
        [SerializeField] Light2D PlayerLight;

        void Update()
        {
           TimeCheck();
        }

       void TimeCheck()
        {
             if(WeatherManager.Instance.TimeManager == 1)
            {
                PlayerLight.enabled = false;
            }
            if(WeatherManager.Instance.TimeManager == 2)
            {
                PlayerLight.enabled = false;
            }
            if(WeatherManager.Instance.TimeManager == 3)
            {
                PlayerLight.enabled = true;
            }
        }
    }
}
    
