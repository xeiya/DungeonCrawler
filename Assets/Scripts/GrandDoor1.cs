using UnityEngine;

public class TreasureDoor : MonoBehaviour
{
    private Animator doorAnimator;

    private void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    public void OpenGrandDoor() 
    {
        doorAnimator.SetBool("isOpen", true);
    }
}
