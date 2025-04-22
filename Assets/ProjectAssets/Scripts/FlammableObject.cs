using UnityEngine;

public class FlammableObject : MonoBehaviour
{
    [SerializeField] private GameObject flame;
    [SerializeField] private bool canIgnite;

    public void SetIgnite(WeatherType weather)
    {
        Debug.Log(weather);
        if (weather == WeatherType.Rain || weather == WeatherType.Snow)
        {
            canIgnite = false;
        }
        else if(weather == WeatherType.Sunny)
        {
            canIgnite = true;
        }
    }
    public void TryIgnite()
    {
        if (canIgnite)
        {
            flame.SetActive(true);
            Debug.Log("Flame");
        }
    }
}