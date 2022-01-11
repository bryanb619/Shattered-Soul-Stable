using UnityEngine;

public class Tiles : MonoBehaviour
{
    public Vector3 targetPosition;
    private Vector3 correctPosition;
    private SpriteRenderer _sprite;


    void Awake()
    {
        targetPosition = transform.position;
        correctPosition = transform.position;
        _sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.position = Vector3.Lerp(a: transform.position, b: targetPosition, t: 0.05f);
       
        if (targetPosition == correctPosition)
        {
            _sprite.color = Color.green;
        }
        else
        {
            _sprite.color = Color.white; 

        }
       
    }
}
