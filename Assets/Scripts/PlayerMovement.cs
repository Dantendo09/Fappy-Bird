using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpHeigh;
    private Rigidbody rb;
    [SerializeField] private float _velocity = 1.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector3.up * jumpHeigh * _velocity;
        }
        

        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, -10, 5);
        transform.position = position;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameManager.instance.GameOver();
    }
}
