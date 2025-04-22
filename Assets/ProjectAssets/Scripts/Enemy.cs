using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform shelterTranform;
    [SerializeField] private float speed;
    [SerializeField] private float patrolTime;

    public void ReactToWeather(WeatherType weather)
    {
        if (weather == WeatherType.Rain)
        {
            Debug.Log("SeekShelter");
        }
        else
        {
            Debug.Log("Patrol");
        }
    }
    public IEnumerator PatrolRandrom()
    {
        

        yield return null;
    }
    public void SeekShelter()
    {
        transform.position = Vector2.Lerp(transform.position, shelterTranform.position, Time.deltaTime * speed);
    }
}