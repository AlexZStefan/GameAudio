using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioManager instance { get; private set; }

    void Awake()
    {
        if (instance == null) instance = this;

        Debug.Log(instance.name);
    }

   public void PlayOneShot(EventReference _event, Vector3 position)
    {
        RuntimeManager.PlayOneShot(_event, position);
    }
}
