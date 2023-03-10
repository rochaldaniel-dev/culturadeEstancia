using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonEBrilho : MonoBehaviour
{

    [SerializeField] private AudioSource fundoMusica; 
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void volumeMusical(float Value)
    {
        fundoMusica.volume = Value;
    }
}
