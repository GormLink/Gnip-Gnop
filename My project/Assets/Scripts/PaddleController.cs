using System.Xml.Serialization;
using UnityEngine;

public class PadleController
{
    public float moveSpeed = 10f; 
    public Vector3 launchDirection = Vector3.forward;

    private Rigidbody rb;

private void Start()
{
    rb = GetComponent<Rigidbody>();
}

private void Update()
{
    if(Input.GetKeyDown(KeyCode.Space))
{
    MovePaddle()
}

}

private void MovePaddle()
{
    rb.linearVelocity = launchDirection * moveSpeed;

    Invoke("StopPaddle", 0.2f);
}
    private void StopPaddle()
    {
        rb.linearVelocity = Vector3.zero;
    }
}
