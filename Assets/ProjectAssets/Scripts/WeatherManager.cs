using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public enum WeatherType { Rain, Snow, Sunny }
public class WeatherManager : MonoBehaviour
{
    public UnityEvent<WeatherType> OnWeatherChange;
    [SerializeField] float changeInterval;
    private WeatherType currentWeather;
    private WeatherType[] weatherTypes = new WeatherType[3] {WeatherType.Rain, WeatherType.Snow, WeatherType.Sunny};

    private void Start()
    {
        StartCoroutine(AutoWeatherChange(changeInterval));
    }
    public void Initialize()
    {
         
    }
    public void SetRandomWeather()
    {
        currentWeather = weatherTypes[Random.Range(0, weatherTypes.Length)];
        Debug.Log(currentWeather);
    }
    public IEnumerator AutoWeatherChange(float time)
    {
        while (true)
        {
            SetRandomWeather();
            OnWeatherChange?.Invoke(currentWeather);
            yield return new WaitForSeconds(time);
        }
    }
}