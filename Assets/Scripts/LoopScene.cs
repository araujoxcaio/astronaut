using UnityEngine;

public class LoopScene : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Vector3 inicialPosition;

    private float realSizeImage;

    private void Awake()
    {
        this.inicialPosition = this.transform.position;
        float sizeImage = this.GetComponent<SpriteRenderer>().size.x;
        float scale = this.transform.localScale.x;
        this.realSizeImage = sizeImage * scale;

    }

    void Update()
    {
        float displacement = Mathf.Repeat(this.speed * Time.time, realSizeImage);
        this.transform.position = this.inicialPosition +  Vector3.left * displacement;
    }
}
