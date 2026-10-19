using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject enemy;
    Rigidbody rb;

    [SerializeField] float stepTime = 0.15f;
    float endTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = enemy.GetComponent<Rigidbody>();
        endTime = Time.time + stepTime;
    }

    // Update is called once per frame
    void Update()
    {
        Move();        
    }

    void Move()
    {
        if (CanMove())
        {
            DefaultMove();
        }
    }

    void DefaultMove()
    {
        float step = Random.Range(-10f, 10f);
        rb.linearVelocity = Vector3.zero;
        rb.linearVelocity = new Vector3(step, 0, 0);
    }

    bool CanMove()
    {
        if(Time.time > endTime)
        {
            endTime = Time.time + stepTime;
            return true;
        }
        return false;
    }
}
