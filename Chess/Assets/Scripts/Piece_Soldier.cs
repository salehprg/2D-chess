using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece_Soldier : Piece
{
    public bool firstmove = true;

    public override void _Start()
    {
        firstmove = true;
        piece_Type = Piece_types.Soldier;
    }

    public override void _Update()
    {
        base._Update();
    }

    public override List<(int, int)> show_available_move(List<List<Piece>> board)
    {
        var index = get_index(board);
        int row = index.Item1;
        int col = index.Item2;

        List<(int, int)> result = new List<(int, int)>();

        checkMove(row + 1, col, result);
        checkMove(row + 1, col + 1, result);
        checkMove(row + 1, col - 1, result);

        if (firstmove)
        {
            checkMove(row + 2 , col , result);
        }

        return result;

    }
}
