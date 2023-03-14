using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystem : MonoBehaviour
{
    [SerializeField] private List<GameObject> sities;

    public void ShowSity(int id)
    {
        sities[id].SetActive(true);
    }

    public void HideSity()
    {
        foreach(var sity in sities)
        {
            sity.SetActive(false);
        }
    }
}
