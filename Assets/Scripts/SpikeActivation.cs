using UnityEngine;

public class SpikeActivation : MonoBehaviour
{
    public Animator spikeAnimator;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Spike")
        {
            spikeAnimator.SetBool("IsActive", true);
        }
        else 
        {
            spikeAnimator.SetBool("IsActive", false);
        }
    }
}
