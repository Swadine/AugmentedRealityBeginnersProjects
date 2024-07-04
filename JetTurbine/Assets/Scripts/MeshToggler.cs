using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggler : MonoBehaviour
{
    public GameObject TurbineObject;

    private bool isActive = true;

    public void toggleObject(){
        isActive = !isActive;
        TurbineObject.SetActive(isActive);
    }
}
