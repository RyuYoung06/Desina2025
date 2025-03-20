using UnityEngine;

public class Phiysics : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float jumpForce = 5f;

    public Rigidbody rb;
    public bool isGrounded;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 Direction = new Vector3(moveX, 0, moveZ);

        rb.MovePosition(transform.position + Direction * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);


        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
