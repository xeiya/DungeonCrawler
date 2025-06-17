using UnityEngine;

public class SpikeActivation : MonoBehaviour
{
    public Animator spikeAnimator;

    private void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            spikeAnimator.SetBool("IsActive", true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            spikeAnimator.SetBool("IsActive", false);
        }
    }
}
