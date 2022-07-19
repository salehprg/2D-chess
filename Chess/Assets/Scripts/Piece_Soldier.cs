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

    public override void move(int row, int col)
    {
        base.move(row, col);
        firstmove = false;
    }

    public override List<(int, int)> show_available_move(List<List<Piece>> board)
    {
        var index = get_index(board);
        int row = index.Item1;
        int col = index.Item2;

        List<(int, int)> result = new List<(int, int)>();

        if (gamecore.playerWhite == white)
        {
            checkMove(row + 1, col, result , false);

            Piece temp = gamecore.GetPiece(row + 1, col + 1).Item1;
            if (temp.piece_Type != Piece_types.None && temp.white != white)
            {
                checkMove(row + 1, col + 1, result);
            }

            temp = gamecore.GetPiece(row + 1, col - 1).Item1;
            if (temp.piece_Type != Piece_types.None && temp.white != white)
            {
                checkMove(row + 1, col - 1, result);
            }

            if (firstmove)
            {
                checkMove(row + 2, col, result , false);
            }

        }
        else
        {
            checkMove(row - 1, col, result , false);

            Piece temp = gamecore.GetPiece(row - 1, col + 1).Item1;
            if (temp.piece_Type != Piece_types.None && temp.white != white)
            {
                checkMove(row - 1, col + 1, result);
            }
            
            temp = gamecore.GetPiece(row - 1, col - 1).Item1;
            if (temp.piece_Type != Piece_types.None && temp.white != white)
            {
                checkMove(row - 1, col - 1, result);
            }

            if (firstmove)
            {
                checkMove(row - 2, col, result , false);
            }
        }



        return result;

    }
}
