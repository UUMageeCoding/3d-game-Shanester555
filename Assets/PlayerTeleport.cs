using UnityEngine;
using System.Collections;

public class PlayerTeleport : MonoBehaviour
{
    public Transform teleportTarget;

    void OnTriggerEnter(Collider other)
    {
        CharacterController cc = other.GetComponent<CharacterController>();
        if (cc)
        {
            cc.enabled = false;
            other.transform.position = teleportTarget.position;     // teleport 
            cc.enabled = true;
        }
    }
}
