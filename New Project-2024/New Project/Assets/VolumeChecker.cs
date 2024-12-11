using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChecker : MonoBehaviour
{
    public GameObject lights;
    public GameObject crab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            lights.SetActive(false);
            crab.SetActive(true);

        }
    }
}
