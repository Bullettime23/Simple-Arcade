using UnityEngine;

public class MoveTowardsAndBackWithTimer : MonoBehaviour
{
    [SerializeField] private Vector3 target;
    [SerializeField] private float speed;
    [SerializeField] private GameObject timerSound;

    [SerializeField] private float timer;
    private float initialtimer;
    private Vector3 initialPosition;
    private bool isReachedTarget = false;

    private void Start()
    {
        initialPosition = transform.position;
        initialtimer = timer;
    }

    private void OnEnable()
    {
        Instantiate(timerSound);
    }

    private void Update()
    {
        if(!isReachedTarget)
        {
            MoveTowards();

            if(transform.position == target)
            {
                isReachedTarget = true;
            }

            return;
        }

        if (isReachedTarget && timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }

        MoveBackwards();
        if (transform.position == initialPosition)
        {
            ToInitial();
        }
    }

    private void MoveTowards()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void MoveBackwards()
    {
        transform.position = Vector3.MoveTowards(transform.position, initialPosition, speed * Time.deltaTime);
    }

    private void ToInitial()
    {
        this.enabled = false;
        this.isReachedTarget = false;
        this.timer = initialtimer;
    }

}
