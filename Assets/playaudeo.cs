using UnityEngine;

public class playaudeo : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioClip wooshSoco1;
    [SerializeField] AudioSource footstepSource;
    [SerializeField] AudioClip footstepSoco1;
    [SerializeField] AudioClip footstepSourc;
    [SerializeField] AudioClip footstepSoco2;
    [SerializeField] AudioSource damageSource;
    [SerializeField] AudioClip damageSoco3;
    public void PlayWoosh()
    {
        Debug.Log("Play woosh");
        wooshSource.clip = wooshSoco1;

        wooshSource.Play();

        damageSource.clip = damageSoco3;
        damageSource.Play();
        
    }
    public void PlayFootstep()
    {
        footstepSource.clip = footstepSoco1;
        footstepSource.Play();
    }
    public void patras()
    {
        footstepSource.clip = footstepSoco2;
        footstepSource.Play();
    }

}
