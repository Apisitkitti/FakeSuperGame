using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PhEngine.Core;

public class WeatherManager : Singleton<WeatherManager>
{
     [SerializeField] GameObject WeatherUI;
    
    
    public int TimeManager => timeManager;
    [SerializeField] int timeManager;

   
    public int WeatherChoose => weatherChoose;
    [SerializeField] int weatherChoose;

    public int StarCount => starCount;
    [SerializeField] int starCount;

    public int RainSnowCounting => raisnnowCounting;
    [SerializeField] int  raisnnowCounting;


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
    public void SnowRainManager(int Count)
    {
        raisnnowCounting = Count;
    }
    public void StarManager(int StarChoice)
    {
        starCount = StarChoice;
    }
    public void SuccessFullButton()
    {
        WeatherUI.SetActive(false);
    }

}
