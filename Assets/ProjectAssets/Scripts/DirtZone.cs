using UnityEngine;

public class DirtZone : MonoBehaviour
{
    [SerializeField] private bool isMuddy;
    [SerializeField] private float MuddyMultiplier;


    public void UpdateMuddyState(WeatherType weather)
    {
        Debug.Log(weather == WeatherType.Rain);
        if(weather == WeatherType.Rain)
        {
            isMuddy = true;
        }
        else
        {
            isMuddy = false;
        }
    }
    public float GetMuddyMultiplier()
    {
        if (isMuddy)
        {
            return MuddyMultiplier;
        }
        else
        {
            return 1;
        }
    }
}