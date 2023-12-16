using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public AudioClip collectedClip;
    // Start is called before the first frame update
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<Bird>() != null)
        {
            GameControl.instance.BirdScored();
            
        }
    }
}
