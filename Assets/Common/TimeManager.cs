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
        [SerializeField] GameObject Star;
        [SerializeField] GameObject Snow;
        [SerializeField] GameObject Rain;
        void Update()
        {
           TimeCheck();
           WeatherCheck();
        }
        
       void TimeCheck()
        {
             if(WeatherManager.Instance.TimeManager == 1)
            {
                LightSource.color = new Color(1f,0.7375f,0.6650f,1f);
                Star.SetActive(false);
            }
            if(WeatherManager.Instance.TimeManager == 2)
            {
                LightSource.color = new Color(1f,1f,1f,1f);
                Star.SetActive(false);
            }
            if(WeatherManager.Instance.TimeManager == 3)
            {
                LightSource.color = new Color(0.2404522f,0.1950872f,0.3018868f,1f);
                Star.SetActive(true);
            }
        }
        void WeatherCheck()
        {
            if(WeatherManager.Instance.WeatherChoose == 1)
            {
               Snow.SetActive(false);
               Rain.SetActive(false);
            }
             if(WeatherManager.Instance.WeatherChoose == 2)
            {
               Rain.SetActive(true);
            }
            if(WeatherManager.Instance.WeatherChoose == 3)
            {
               Snow.SetActive(true);
            }
        }
    }
}
    
