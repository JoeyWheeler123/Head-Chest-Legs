using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource charSounds;
    public AudioSource music;

    public static AudioManager Instance = null;
     
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(AudioClip clip)
    {
        charSounds.clip = clip;
        charSounds.Play();

    }

    public void PlayMusic(AudioClip clip)
    {
        music.clip = clip;
        music.Play();
    }
}
