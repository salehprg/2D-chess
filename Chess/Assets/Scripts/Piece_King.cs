using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece_King : Piece
{
    public bool firstmove;

    public override void _Start()
    {
        piece_Type = Piece_types.King;
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

        checkMove(row + 1 , col + 1 , result);
        checkMove(row + 1 , col , result);
        checkMove(row + 1 , col - 1 , result);
        checkMove(row , col - 1 , result);
        checkMove(row , col + 1 , result);
        checkMove(row - 1 , col + 1 , result);
        checkMove(row - 1 , col - 1 , result);
        checkMove(row - 1 , col , result);

        return result;
        
    }
}
