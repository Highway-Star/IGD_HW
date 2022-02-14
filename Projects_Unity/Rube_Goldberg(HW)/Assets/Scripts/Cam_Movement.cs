using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Attach to trigger; Moves Camera onto Target Posistion

public class Cam_Movement : MonoBehaviour
{
    BoxCollider2D boxCollider;
    public Transform cam;
    public Transform target;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    void Start()
    {
        boxCollider.isTrigger = true;
    }
    private void FixedUpdate()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //mover.position = new Vector3(5.0f, 0.0f, 0.0f);
        cam.position = target.position;
        Debug.Log("Entered Trigger");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exited Trigger");
    }
}
