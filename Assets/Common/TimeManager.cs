using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhEngine.Core;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
namespace SuperGame
{
    public class TimeManager : MonoBehaviour
    {
         
        [SerializeField] Light2D LightSource;
        [SerializeField] GameObject Star;
        [SerializeField] GameObject Snow;
        [SerializeField] GameObject Rain;
        [SerializeField] AudioSource ThunderSound; 
        [SerializeField] Slider RainTimeAdjustment;
        float thunderCountdown = 0;
         void Start()
        {
            UpdateThunderCountdown();
        }
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
            if (WeatherManager.Instance.WeatherChoose == 1)
            {
                Snow.SetActive(false);
                Rain.SetActive(false);
            }
            if (WeatherManager.Instance.WeatherChoose == 2)
            {
                Snow.SetActive(false);
                Rain.SetActive(true);

                // Decrease the thunder countdown over time
                if (thunderCountdown > 0)
                {
                    thunderCountdown -= Time.deltaTime;
                }
                else
                {
                    // When the countdown reaches zero, play the thunder sound
                    PlayThunderSound();

                    // Update the countdown based on the slider value
                    UpdateThunderCountdown();
                }
            }

            if (WeatherManager.Instance.WeatherChoose == 3)
            {
                Snow.SetActive(true);
                Rain.SetActive(false);
            }
        }

        void PlayThunderSound()
        {
            AudioManager.Instance.Play("ThunderBolt");
        }

        void UpdateThunderCountdown()
        {
            // Calculate the countdown based on the slider value
            float sliderValue = RainTimeAdjustment.value;
            
            // Adjust the range and scaling factor as needed
            // Here, I'm assuming a range of 1 to 10, but you can adjust this based on your requirements.
            thunderCountdown = Mathf.Lerp(5f, 1f, sliderValue / RainTimeAdjustment.maxValue);
        }
    }
  }

    
