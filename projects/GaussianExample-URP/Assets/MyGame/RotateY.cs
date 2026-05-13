using UnityEngine;

public class RotateY : MonoBehaviour
{
    [SerializeField] private Vector3 m_rotationSpeed = new Vector3(0, 1, 0);
    [SerializeField] private Vector3 m_moveSpeed = new Vector3(0, 0, 1);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(m_rotationSpeed * Time.deltaTime);
        transform.Translate(m_moveSpeed * Time.deltaTime);
    }
}
