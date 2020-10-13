using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioClip walkSound;
    public float footstepDelay;

    private float nextFootstep = 0.1f;
    private float FootstepDelay = 0.3f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.S)
            || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Z))
        {
            nextFootstep -= Time.deltaTime;
            if (nextFootstep <= 0)
            {
                GetComponent<AudioSource>().PlayOneShot(walkSound, 0.1f);
                nextFootstep += FootstepDelay;
            }
        }
    }
}