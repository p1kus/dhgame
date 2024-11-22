using Unity.Cinemachine;
using UnityEngine;

public class CamSwitcher : MonoBehaviour
{
    public Transform Player;
    public CinemachineCamera activeCamera;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) 
        {
            activeCamera.Priority = 1;
        }
    }

    private void OnTriggerExit(Collider other) {
           if(other.CompareTag("Player")) 
        {
            activeCamera.Priority = 0;
        }
    }
}
