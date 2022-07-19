using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece_Minister : Piece
{
    public bool firstmove;

    public override void _Start()
    {
        piece_Type = Piece_types.Minister;
    }

    public override void _Update()
    {
        base._Update();
    }


    public override List<(int,int)> show_available_move(List<List<Piece>> board)
    {
        base.show_available_move(board);
        List<(int,int)> result = new List<(int,int)>();

        var index = get_index(board);
        int row = index.Item1;
        int col = index.Item2;

        for(int i = 1; i < 8;i++)
        {
            if(checkMove(row + i , col + i , result) < 1)
                break;
        }

        for(int i = 1; i < 8;i++)
        {
            if(checkMove(row + i , col - i , result) < 1)
                break;
        }

        for(int i = 1; i < 8;i++)
        {
            if(checkMove(row - i , col + i , result) < 1)
                break;
        }

        for(int i = 1; i < 8;i++)
        {
            if(checkMove(row - i , col - i , result) < 1)
                break;
        }



        for(int i = 1; i < 8;i++)
        {
            if(checkMove(row + i , col , result) < 1)
                break;
        }

        for(int i = 1; i < 8;i++)
        {
            if(checkMove(row - i , col , result) < 1)
                break;
        }

        for(int i = 1; i < 8;i++)
        {
            if(checkMove(row , col + i , result) < 1)
                break;
        }

        for(int i = 1; i < 8;i++)
        {
            if(checkMove(row , col - i , result) < 1)
                break;
        }


        return result;
        
    }
}
