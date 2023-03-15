using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float failureDelay = 2f;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed;
   void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && !hasCrashed)
        {   hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            finishEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", failureDelay);
        }
    }

    void ReloadScene()
    {
     SceneManager.LoadScene(0);
    }
}
