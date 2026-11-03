using UnityEngine;
using System.Collections.Generic;
public class playaudeo : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioClip wooshSoco1;

    [SerializeField] AudioSource footstepSource;
    [SerializeField] AudioClip footstepSoco1;
    [SerializeField] AudioClip footstepSourc;
    [SerializeField] AudioClip footstepSoco2;
    [SerializeField] List<AudioClip> grunts;
    [SerializeField] List<AudioClip> steps;
    [SerializeField] AudioSource damageSource;
    [SerializeField] AudioClip damageSoco3;
    public void PlayWoosh()
    {
        Debug.Log("Play woosh");
        wooshSource.clip = wooshSoco1;

        wooshSource.Play();

        damageSource.clip = grunts[Random.Range(0,grunts.Count)];
        damageSource.pitch = Random.Range(0.7f, 1.4f);
        damageSource.Play();

        
    }
    public void PlayFootstep()
    {
        footstepSource.clip = footstepSoco1;
        footstepSource.clip = steps[Random.Range(0, steps.Count)];
        footstepSource.pitch = Random.Range(0.9f, 1.3f);

        footstepSource.Play();
    }
    
}
