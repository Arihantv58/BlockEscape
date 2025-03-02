using UnityEngine;

public class scr : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideForce = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // rb.AddForce(0, 200, 500);
        Debug.Log("Added force successfully");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce (0, 0, forwardForce*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}
