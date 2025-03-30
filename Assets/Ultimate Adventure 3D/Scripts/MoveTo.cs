using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private Vector3 target;
    [SerializeField] private float speed;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
