using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece_Horse : Piece
{
    public bool firstmove;

    public override void _Start()
    {
        piece_Type = Piece_types.Horse;
    }

    public override void _Update()
    {
        base._Update();
    }

    public override List<(int,int)> show_available_move(List<List<Piece>> board)
    {
        var index = get_index(board);
        int row = index.Item1;
        int col = index.Item2;

        List<(int,int)> result = new List<(int,int)>();

        checkMove(row + 2 , col + 1 , result);
        checkMove(row + 2 , col - 1 , result);
        checkMove(row + 1 , col + 2 , result);
        checkMove(row + 1 , col - 2 , result);
        checkMove(row - 1 , col + 2 , result);
        checkMove(row - 1 , col - 2 , result);
        checkMove(row - 2 , col + 1 , result);
        checkMove(row - 2 , col - 1 , result);

        return result;
        
    }
}
