using UnityEngine;
using System.Collections;

public class DestroyByBoundaryScript : MonoBehaviour
{

    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}