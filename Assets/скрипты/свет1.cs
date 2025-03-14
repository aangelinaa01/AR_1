using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class свет1 : MonoBehaviour
{
    public Button turnOnButton;
    public Button turnOffButton;
    public GameObject[] lightsObjects; 
    public Material lightOnMaterial;
    public Material lightOffMaterial;

    private Renderer[] lightRenderers;

    private void Start()
    {
        lightRenderers = new Renderer[lightsObjects.Length];

        for (int i = 0; i < lightsObjects.Length; i++)
        {
            if (lightsObjects[i] != null)
            {
                lightRenderers[i] = lightsObjects[i].GetComponent<Renderer>();
                if (lightRenderers[i] != null)
                {
                    lightRenderers[i].material = lightOffMaterial;
                }
            }
        }

        turnOnButton.onClick.AddListener(() => StartCoroutine(DelayedLightChange(true)));
        turnOffButton.onClick.AddListener(() => StartCoroutine(DelayedLightChange(false)));
    }

    private IEnumerator DelayedLightChange(bool turnOn)
    {
        yield return new WaitForSeconds(0.5f); 

        ChangeLightMaterial(turnOn);
    }

    private void ChangeLightMaterial(bool turnOn)
    {
        Material newMaterial = turnOn ? lightOnMaterial : lightOffMaterial;

        for (int i = 0; i < lightRenderers.Length; i++)
        {
            if (lightRenderers[i] != null)
            {
                lightRenderers[i].material = newMaterial;
            }
        }
    }
}
