using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTile : MonoBehaviour
{
    public int row , col;

    public Piece piece;

    private void OnMouseUp() {
        if(piece != null)
        {
            piece.move(row , col);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
