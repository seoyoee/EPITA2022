using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARAccMove : MonoBehaviour
{
    public ARFaceManager arFaceManager;

    public GameObject[] accessories;

    private GameObject accObj;

    private int num;

    public static double vertical, parallel = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        arFaceManager = gameObject.GetComponent<ARFaceManager>();

        if (arFaceManager != null)
        {
            foreach (ARFace face in arFaceManager.trackables)
            {
                if (face.trackingState == TrackingState.Tracking)
                {
                    face.gameObject.transform.Translate((float)parallel, (float)vertical, 0);
                }
            }
        }
    }

    public void OnclickButtonLeft()
    {
        parallel += 0.002;
    }

    public void OnclickButtonRight()
    {
        parallel -= 0.002;
    }

    public void OnclickButtonUp()
    {
        vertical += 0.002;
    }

    public void OnclickButtonDown()
    {
        vertical -= 0.002;
    }

    public void SwitchAcc(int num)
    {
        ARAccMove.vertical = 0;
        ARAccMove.parallel = 0;

        if (arFaceManager != null)
        {
            foreach (ARFace face in arFaceManager.trackables)
            {
                if (face.trackingState == TrackingState.Tracking)
                    face.gameObject.SetActive(false);
            }
            DestroyImmediate(accObj);
            DestroyImmediate(arFaceManager);
        }

        accObj = Instantiate(accessories[num]);
        arFaceManager = gameObject.AddComponent<ARFaceManager>();
        arFaceManager.facePrefab = accObj;
    }
}