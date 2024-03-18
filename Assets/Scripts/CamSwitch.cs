using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject humanCam;
    public GameObject dogCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("1Key"))
        {
            humanCam.SetActive(true);
            dogCam.SetActive(false);
        }
        if (Input.GetButtonDown("2Key"))
        {
            humanCam.SetActive(false);
            dogCam.SetActive(true);
        }
    }
}
