using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private static Sound music;

    void Awake()
    {
        if(music == null)
        {
            music = this;
            DontDestroyOnLoad(music);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
