using UnityEngine;

public class CreateRocks : MonoBehaviour
{
    [SerializeField]
    private float generateTime;
    [SerializeField]
    private float timer;
    [SerializeField]
    private GameObject rocks;

    private Vector3 inicialPosition;

    private void Awake()
    {
        this.timer = this.generateTime;
        this.inicialPosition = this.transform.position;

    }

    private void Update()
    {
        this.timer -= Time.deltaTime;
        if (this.timer < 0) {
            GameObject.Instantiate(this.rocks, inicialPosition, Quaternion.identity);
            //GameObject.Destroy(this.rocks);
            this.timer = this.generateTime;
        }
    }
}
