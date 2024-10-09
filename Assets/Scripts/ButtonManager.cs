using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public XZMovement xzMovementScript;
    public UDMovement udMovementScript;
    public YRotation yRotationScript;

    public ARIconsManager arIconsManager;

    public void EnableXZMovement()
    {
        xzMovementScript.enabled = true;
        udMovementScript.enabled = false;
        yRotationScript.enabled = false;
        arIconsManager.EnableXZ();
    }

    public void EnableUDMovement()
    {
        xzMovementScript.enabled = false;
        udMovementScript.enabled = true;
        yRotationScript.enabled = false;
        arIconsManager.EnableUD();
    }

    public void EnableYRotation()
    {
        xzMovementScript.enabled = false;
        udMovementScript.enabled = false;
        yRotationScript.enabled = true;
        arIconsManager.EnableY();
    }
}
