
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Heartbeat : MonoBehaviour
{
    public GameObject GameObject;
    public GameObject enemy;
    public float Distance;
    public AudioClip heartbeat;
    public AudioClip heartbeat2;
    public AudioClip heartbeat3;

    void Update()
    {
        Distance = Vector3.Distance(GameObject.transform.position, enemy.transform.position);
        if (Vector3.Distance(GameObject.transform.position, enemy.transform.position) <= 35 && !GetComponent<AudioSource>().isPlaying)
        {
            GetComponent<AudioSource>().clip = heartbeat;
            GetComponent<AudioSource>().Play(); 
        }
        if (Vector3.Distance(GameObject.transform.position, enemy.transform.position) > 35 )
        {
            GetComponent<AudioSource>().clip = heartbeat;
            GetComponent<AudioSource>().Stop();
        }
      
       
    }
}