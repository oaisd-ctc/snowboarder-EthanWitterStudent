using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
        Debug.Log("You shattered your skull!");
        SceneManager.LoadScene(0);
        }
}}
