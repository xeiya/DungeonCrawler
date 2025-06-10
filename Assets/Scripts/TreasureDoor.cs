using UnityEngine;

public class TreasureDoor : MonoBehaviour
{
    public Animator doorAnimator;

    private void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    public void OpenTreasureDoor()
    {
        doorAnimator.SetBool("isOpen", true);
    }
}
