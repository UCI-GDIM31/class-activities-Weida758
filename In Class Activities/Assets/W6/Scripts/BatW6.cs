using UnityEngine;
using UnityEngine.Rendering.Universal;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    private bool chasing;

    public void StartChasing(Transform playerTransform)
    {
        chasing = true;
        if (chasing)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, _speed * Time.deltaTime);
        }
    }
    
    public void StopChasing()
    {
        chasing = false;
    }
}
