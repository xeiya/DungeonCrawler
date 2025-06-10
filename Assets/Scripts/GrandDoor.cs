using UnityEngine;

public class GrandDoor : MonoBehaviour
{
    public Animator doorAnimator;

    private void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    public void OpenGrandDoor() 
    {
        doorAnimator.SetBool("isOpen", true);
    }
}
