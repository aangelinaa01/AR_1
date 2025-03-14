using UnityEngine;
using UnityEngine.UI;

public class Lever : MonoBehaviour
{
    public Button turnOnButton; 
    public Button turnOffButton; 
    public Animator animator1; 
    public Animator animator2; 

    private void Start()
    {
        animator1.enabled = false;
        animator2.enabled = false;

        turnOnButton.onClick.AddListener(PlayTurnOnAnimation);
        turnOffButton.onClick.AddListener(PlayTurnOffAnimation);
    }

    private void PlayTurnOnAnimation()
    {
        animator1.enabled = true;
        animator2.enabled = true;

        animator1.Play("ON1", -1, 0f); 
        animator2.Play("ON2", -1, 0f); 
    }

    private void PlayTurnOffAnimation()
    {
        animator1.enabled = true;
        animator2.enabled = true;

        animator1.Play("OFF1", -1, 0f); 
        animator2.Play("OFF2", -1, 0f); 
    }
}