using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhEngine.Core;
namespace SuperGame
{
    public class WeatherManager : Singleton<WeatherManager>
    {
        [SerializeField] GameObject WeatherUI;
    
    
        public int TimeManager => timeManager;
        [SerializeField] int timeManager;

   
        public int WeatherChoose => weatherChoose;
        [SerializeField] int weatherChoose;

        protected override void InitAfterAwake()
        {
            WeatherUI.SetActive(true);
        }
        public void SelectTime(int TimeChoice)
        {
            timeManager  = TimeChoice;
        }
        public void SelectWeather(int WeatherChoice)
        {
            weatherChoose = WeatherChoice;
        }
        public void SuccessFullButton()
        {
            WeatherUI.SetActive(false);
            GameManager.Instance.StartLevel();
        }

    }
}
