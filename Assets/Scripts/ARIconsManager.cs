using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  enum ARIcons { UD, XZ, Y }

[System.Serializable]

public class Icon
{
    public ARIcons iconType;   
    public GameObject iconObject; 
}

public class ARIconsManager : MonoBehaviour
{

    [SerializeField] List<Icon> icons = new List<Icon>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < icons.Count; i++) {
            icons[i].iconObject.SetActive(false);
        } 
    }

    public void EnableUD()
    {
        foreach (Icon icon_ in icons) {
            if (icon_.iconType == ARIcons.UD)
            {
                icon_.iconObject.SetActive(true);
            }
            else {
                icon_.iconObject.SetActive(false);
            }
        }
    }

    public void EnableXZ() {
        foreach(Icon icon_ in icons) {
            if (icon_.iconType == ARIcons.XZ)
            {
                icon_.iconObject.SetActive(true);
            }
            else
            {
                icon_.iconObject.SetActive(false);
            }
        }
    }

    public void EnableY() {
        foreach(Icon icon_ in icons) {
            if (icon_.iconType == ARIcons.Y)
            {
                icon_.iconObject.SetActive(true);
            }
            else
            {
                icon_.iconObject.SetActive(false);
            }
        }
    }
}
