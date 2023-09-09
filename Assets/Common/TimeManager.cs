using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhEngine.Core;
using UnityEngine.Rendering.Universal;
namespace SuperGame
{
    public class TimeManager : MonoBehaviour
    {
         
        [SerializeField] Light2D LightSource;

        void Update()
        {
           TimeCheck();
        }

       
       
       void TimeCheck()
        {
             if(WeatherManager.Instance.TimeManager == 1)
            {
                LightSource.color = new Color(1f,0.7375f,0.6650f,1f);
            }
            if(WeatherManager.Instance.TimeManager == 2)
            {
                 LightSource.color = Color.black;
            }
            if(WeatherManager.Instance.TimeManager == 3)
            {
                LightSource.color = Color.blue;
            }
        }
    }
}
    
