using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D myRigibody;
    // Start is called before the first frame update

    private void OnEnable()
    {
        Refences.player = this;
    }

    private void OnDisable()
    {
        Refences.player = null;
    }


    void Start()
    {
        myRigibody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float RealSpeed = speed * Time.deltaTime;
        Vector3 MovePosition = new Vector3(Input.GetAxis("Horizontal") * RealSpeed, Input.GetAxis("Vertical") * RealSpeed);
        myRigibody.velocity = MovePosition;
    }
}
