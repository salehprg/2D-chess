using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public Piece_types piece_Type;
    public bool white;
    public bool locked;
    public Gamecore gamecore;

    public Piece()
    {
        piece_Type = Piece_types.None;
    }


    void Start()
    {
        gamecore = Camera.main.GetComponent<Gamecore>();
        _Start();
    }
    public virtual void _Start(){}

    void Update()
    {
        _Update();
    }
    public virtual void _Update(){}


    public virtual void move(int row , int col){
        Vector2 newpos = new Vector2(gamecore.basePos.x + gamecore.offset_x * col , gamecore.basePos.y + gamecore.offset_y * row);
        transform.position = newpos;
        
        gamecore.UpdateBoard(this , row , col);
    }

    public int checkMove(int row , int col , List<(int,int)> result , bool attack = true)
    {
        Piece temp = gamecore.GetPiece(row , col ).Item1;
        int condition = gamecore.GetPiece(row , col ).Item2;

        if(condition != -1 && temp.gamecore == null)
        {
            result.Add((row,col));
            return 1;
        }
        else if(attack && temp?.gamecore != null && temp.white != this.white)
        {
            result.Add((row,col));
            return -1;
        }
        
        return -1;
    }
    
    public (int,int) get_index(List<List<Piece>> board)
    {
        for(int i=0;i<8;i++)
        {
            for(int j=0;j<8;j++)
            {
                if(board[i][j] == this)
                {
                    return (i,j);
                }
            }
        }

        return (-1,-1);
    }
    public virtual List<(int,int)> show_available_move(List<List<Piece>> board)
    {
        switch(piece_Type)
        {
            case Piece_types.Soldier:
                Debug.Log("soldier");
                break;
        }

        return null;
    }
}
