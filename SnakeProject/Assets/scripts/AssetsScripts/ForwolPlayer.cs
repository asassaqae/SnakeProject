using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwolPlayer : MonoBehaviour
{
    Transform playerTransform;
    [SerializeField] float speedToMoveToPlayer;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = Refences.player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = new Vector3(playerTransform.position.x, playerTransform.position.y, -10f);
        Vector3 cameraPosition = new Vector3(transform.position.x, transform.position.y, -10f);
        transform.position = Vector3.Lerp(playerPosition, cameraPosition, speedToMoveToPlayer);
    }
}
