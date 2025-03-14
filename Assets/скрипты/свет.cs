using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class свет : MonoBehaviour
{
    public Button turnOnButton; 
    public Button turnOffButton; 
    public GameObject[] lightsObjects; 

    private void Start()
    {
        for (int i = 0; i < lightsObjects.Length; i++)
        {
            if (lightsObjects[i] != null)
            {
                lightsObjects[i].SetActive(false);
            }
        }

        turnOnButton.onClick.AddListener(() => StartCoroutine(DelayedLightChange(true)));
        turnOffButton.onClick.AddListener(() => StartCoroutine(DelayedLightChange(false)));
    }

    private IEnumerator DelayedLightChange(bool turnOn)
    {
        yield return new WaitForSeconds(0.5f); 

        for (int i = 0; i < lightsObjects.Length; i++)
        {
            if (lightsObjects[i] != null)
            {
                lightsObjects[i].SetActive(turnOn);
            }
        }
    }
}
