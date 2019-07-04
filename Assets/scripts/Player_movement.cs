using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysforce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello, world!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardForce  * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -4)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
