using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{

    private Coroutine songCoroutine;
    [Header("Audio Component")]
    public AudioSource audioSource;

    [Header("Audio Clips")]
    [Header("Low Keys")]
    public AudioClip lowC;
    public AudioClip lowD;
    public AudioClip lowE;
    public AudioClip lowF;
    public AudioClip lowG;
    public AudioClip lowA;
    public AudioClip lowB;
    public AudioClip lowCs;
    public AudioClip lowDs;
    public AudioClip lowFs;
    public AudioClip lowGs;
    public AudioClip lowAs;

    [Header("High Keys")]
    public AudioClip highC;
    public AudioClip highD;
    public AudioClip highE;
    public AudioClip highF;
    public AudioClip highG;
    public AudioClip highA;
    public AudioClip highB;
    public AudioClip highCs;
    public AudioClip highDs;
    public AudioClip highFs;
    public AudioClip highGs;
    public AudioClip highAs;



    //low key fumction
    public void PlayLowC()
    {
        audioSource.PlayOneShot(lowC);
    }
    public void PlayLowD()
    {
        audioSource.PlayOneShot(lowD);
    }
    public void PlayLowE()
    {
        audioSource.PlayOneShot(lowE);
    }
    public void PlayLowF()
    {
        audioSource.PlayOneShot(lowF);
    }
    public void PlayLowG()
    {
        audioSource.PlayOneShot(lowG);
    }
    public void PlayLowA()
    {
        audioSource.PlayOneShot(lowA);
    }
    public void PlayLowB()
    {
        audioSource.PlayOneShot(lowB);
    }
    public void PlayLowCs()
    {
        audioSource.PlayOneShot(lowCs);
    }
    public void PlayLowDs()
    {
        audioSource.PlayOneShot(lowDs);
    }
    public void PlayLowFs()
    {
        audioSource.PlayOneShot(lowFs);
    }
    public void PlayLowGs()
    {
        audioSource.PlayOneShot(lowGs);
    }
    public void PlayLowAs()
    {
        audioSource.PlayOneShot(lowAs);
    }

    //high key functions

    public void PlayHighC()
    {
        audioSource.PlayOneShot(highC);
    }
    public void PlayHighD()
    {
        audioSource.PlayOneShot(highD);
    }
    public void PlayHighE()
    {
        audioSource.PlayOneShot(highE);
    }
    public void PlayHighF()
    {
        audioSource.PlayOneShot(highF);
    }
    public void PlayHighG()
    {
        audioSource.PlayOneShot(highG);
    }
    public void PlayHighA()
    {
        audioSource.PlayOneShot(highA);
    }
    public void PlayHighB()
    {
        audioSource.PlayOneShot(highB);
    }
    public void PlayHighCs()
    {
        audioSource.PlayOneShot(highCs);
    }
    public void PlayHighDs()
    {
        audioSource.PlayOneShot(highDs);
    }
    public void PlayHighFs()
    {
        audioSource.PlayOneShot(highFs);
    }
    public void PlayHighGs()
    {
        audioSource.PlayOneShot(highGs);
    }
    public void PlayHighAs()
    {
        audioSource.PlayOneShot(highAs);
    }
    public void StartSong()
    {
        // If a song is already playing, stop it
        if (songCoroutine != null)
        {
            StopCoroutine(songCoroutine);
            audioSource.Stop();   // Stop any current note
        }

        // Start from the beginning
        songCoroutine = StartCoroutine(AutoSong());
    }


    IEnumerator AutoSong()
    {
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(lowC);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(lowG);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highC);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highG);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highG);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highF);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highE);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highD);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(lowD);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(lowG);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highC);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highD);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highD);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highE);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highF);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highE);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(lowE);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(lowA);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(lowB);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highC);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highD);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highE);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highF);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highE);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highD);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highC);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(lowB);
        yield return new WaitForSeconds(0.3f);
        audioSource.PlayOneShot(highC);
    }
}