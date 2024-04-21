using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BTNManager : MonoBehaviour
{
    public GameObject exampleFur;
    public GameObject planeManager;
    PlaneFinderBehaviour PFBehavior;
    // Start is called before the first frame update
    void Start()
    {
        PFBehavior = FindObjectOfType<PlaneFinderBehaviour>();
    }

    public void CreateFurniture()
    {
        Transform groundPlaneStageTransform = planeManager.transform.Find("GroundPlaneStage");
        GameObject expFur = Instantiate(exampleFur, groundPlaneStageTransform.position, Quaternion.identity, groundPlaneStageTransform);
        expFur.transform.position = PFBehavior.PlaneIndicator.transform.position;
        expFur.transform.localScale *= 0.1f;
    }
}
