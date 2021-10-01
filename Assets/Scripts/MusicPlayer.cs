using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private void Awake()
    {
        int numMusicPlayer = FindObjectsOfType<MusicPlayer>().Length;
        if (numMusicPlayer > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }//Singleton Pattern 
    // Start is called before the first frame update

 
}
