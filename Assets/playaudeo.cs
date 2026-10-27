using UnityEngine;

public class playaudeo : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioClip wooshSoco1;
    [SerializeField] AudioSource footstepSource;
    [SerializeField] AudioClip footstepSoco1;
    [SerializeField] AudioClip footstepSourc;
    [SerializeField] AudioClip footstepSoco2;
    public void PlayWoosh()
    {
        Debug.Log("Play woosh");
        wooshSource.clip = wooshSoco1;

        wooshSource.Play();
        
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
