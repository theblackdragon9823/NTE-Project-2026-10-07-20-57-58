using UnityEngine;

public class slidingpuzzlegamemanager : MonoBehaviour
{
    [SerializeField] private Transform gameTransform;
    [SerializeField] private Transform piecePrefab;

    private int emptylocation;
    private int size;

    private void CreateGamePieces(float gapThickness)
    {
        //make board width 1 in total, so 3 squares in width 1, bc size = 3
        float width = 1 / (float)size;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++) {
                Transform piece = Instantiate(piecePrefab, gameTransform);
                // centre the puzzle on x and y axes
                piece.localPosition = new Vector3(-1 + (2 * width * col) + width, +1 - (2 * width * row) - width, 0);
                piece.localScale = 
            
            
            }
        }

    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        size = 3;
        CreateGamePieces(0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
