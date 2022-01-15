using UnityEngine;

public class GeminiPuzzle : MonoBehaviour
{
    /*[SerializeField] private Transform emptySpace = null;
    private Camera _camera;
    [SerializeField] private Tiles[] tiles;


    void Start()
    {
        _camera = Camera.main;
        Shuffle();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit)
            {

                Debug.Log(hit.transform.name);

                if (Vector2.Distance(a: emptySpace.position, b: hit.transform.position) < 2)
                {
                    Debug.Log(hit.transform.name + "Second if was tested");

                    Vector2 lastEmptySpacePosition = emptySpace.position;
                    GeminiPuzzle thisTile = hit.transform.GetComponent<GeminiPuzzle>();
                    emptySpace.position = thisTile.target.position;
                    thisTile.targetPosition = lastEmptySpacePosition;
                }

            }
        }
    }

    public void Shuffle()
    {
        for (int i = 0; i <15; i++)
        {
            if (tiles[i] != null)
            {
                var lastPos = tiles[i].targetPosition;
                int randomIndex = Random.Range(0, 11);
                tiles[i].targetPosition = tiles[randomIndex].targetPosition;
                tiles[randomIndex].targetPosition = lastPos;
            }
        }
    }*/
    

}
