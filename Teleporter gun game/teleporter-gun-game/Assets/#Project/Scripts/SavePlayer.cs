using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private Vector3 originalPosition;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        originalPosition = player.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CharacterController cc = player.GetComponent<CharacterController>();
            cc.enabled = false;
            player.transform.position = originalPosition;
            cc.enabled = true;
        }
    }

}
