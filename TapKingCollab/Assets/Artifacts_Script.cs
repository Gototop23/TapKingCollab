using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Artifacts_Script : MonoBehaviour
{

    public GameObject ArtifactsOverlay;

    public bool ArtifactsOverlayIsEnabled;



    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);

        ArtifactsOverlayIsEnabled = false;
        ArtifactsOverlay.SetActive(ArtifactsOverlayIsEnabled);


    }   

     private void TurnOnAndOff()
    {
        ArtifactsOverlayIsEnabled ^= true;
        ArtifactsOverlay.SetActive(ArtifactsOverlayIsEnabled);
    }
}
