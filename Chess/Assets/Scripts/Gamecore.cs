using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecore : MonoBehaviour
{
    public List<List<Piece>> board;

    public Piece_Soldier soldier_black;
    public Piece_Elephent elephent_black;
    public Piece_Horse horse_black;
    public Piece_Tower tower_black;
    public Piece_King king_black;
    public Piece_Minister minister_black;

    public Piece_Soldier soldier_white;
    public Piece_Elephent elephent_white;
    public Piece_Horse horse_white;
    public Piece_Tower tower_white;
    public Piece_King king_white;
    public Piece_Minister minister_white;

    public GameObject highlight;

    public float offset_x,offset_y;
        
    public List<GameObject> highlights;

    public bool playerWhite = false;

    public Vector2 basePos;

    bool selected = false;
    
    void spawn_black(int row , bool player)
    {
        Vector2 piecepos = new Vector2(basePos.x + offset_x*0 , basePos.y + offset_y*row);
        GameObject temp = GameObject.Instantiate(tower_black.gameObject , piecepos , new Quaternion());
        board[row][0] = temp.GetComponent<Piece>();
        board[row][0].white = false;

        piecepos = new Vector2(basePos.x + offset_x*1 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(horse_black.gameObject , piecepos , new Quaternion());
        board[row][1] = temp.GetComponent<Piece>();
        board[row][1].white = false;

        piecepos = new Vector2(basePos.x + offset_x*2 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(elephent_black.gameObject , piecepos , new Quaternion());
        board[row][2] = temp.GetComponent<Piece>();
        board[row][2].white = false;

        piecepos = new Vector2(basePos.x + offset_x*3 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(minister_black.gameObject , piecepos , new Quaternion());
        board[row][3] = temp.GetComponent<Piece>();
        board[row][3].white = false;

        piecepos = new Vector2(basePos.x + offset_x*4 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(king_black.gameObject , piecepos , new Quaternion());
        board[row][4] = temp.GetComponent<Piece>();
        board[row][4].white = false;

        piecepos = new Vector2(basePos.x + offset_x*5 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(elephent_black.gameObject , piecepos , new Quaternion());
        board[row][5] = temp.GetComponent<Piece>();
        board[row][5].white = false;

        piecepos = new Vector2(basePos.x + offset_x*6 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(horse_black.gameObject , piecepos , new Quaternion());
        board[row][6] = temp.GetComponent<Piece>();
        board[row][6].white = false;

        piecepos = new Vector2(basePos.x + offset_x*7 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(tower_black.gameObject , piecepos , new Quaternion());
        board[row][7] = temp.GetComponent<Piece>();
        board[row][7].white = false;

        for(int i=0; i < 8;i++)
        {
            piecepos = new Vector2(basePos.x + offset_x*i , basePos.y + offset_y * (player ? row + 1 : row-1));
            temp = GameObject.Instantiate(soldier_black.gameObject , piecepos , new Quaternion());
            board[row + (player ? 1 : -1)][i] = temp.GetComponent<Piece>();
            board[row + (player ? 1 : -1)][i].white = false;
        }
    }

    void spawn_white(int row , bool player)
    {
        Vector2 piecepos = new Vector2(basePos.x + offset_x*0 , basePos.y + offset_y*row);
        GameObject temp = GameObject.Instantiate(tower_white.gameObject , piecepos , new Quaternion());
        board[row][0] = temp.GetComponent<Piece>();
        board[row][0].white = true;

        piecepos = new Vector2(basePos.x + offset_x*1 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(horse_white.gameObject , piecepos , new Quaternion());
        board[row][1] = temp.GetComponent<Piece>();
        board[row][1].white = true;

        piecepos = new Vector2(basePos.x + offset_x*2 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(elephent_white.gameObject , piecepos , new Quaternion());
        board[row][2] = temp.GetComponent<Piece>();
        board[row][2].white = true;

        piecepos = new Vector2(basePos.x + offset_x*3 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(minister_white.gameObject , piecepos , new Quaternion());
        board[row][3] = temp.GetComponent<Piece>();
        board[row][3].white = true;

        piecepos = new Vector2(basePos.x + offset_x*4 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(king_white.gameObject , piecepos , new Quaternion());
        board[row][4] = temp.GetComponent<Piece>();
        board[row][4].white = true;

        piecepos = new Vector2(basePos.x + offset_x*5 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(elephent_white.gameObject , piecepos , new Quaternion());
        board[row][5] = temp.GetComponent<Piece>();
        board[row][5].white = true;

        piecepos = new Vector2(basePos.x + offset_x*6 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(horse_white.gameObject , piecepos , new Quaternion());
        board[row][6] = temp.GetComponent<Piece>();
        board[row][6].white = true;

        piecepos = new Vector2(basePos.x + offset_x*7 , basePos.y + offset_y*row);
        temp = GameObject.Instantiate(tower_white.gameObject , piecepos , new Quaternion());
        board[row][7] = temp.GetComponent<Piece>();
        board[row][7].white = true;

        for(int i=0; i < 8;i++)
        {
            piecepos = new Vector2(basePos.x + offset_x * i , basePos.y + offset_y * (player ? row + 1 : row-1));
            temp = GameObject.Instantiate(soldier_white.gameObject , piecepos , new Quaternion());
            board[row + (player ? 1 : -1)][i] = temp.GetComponent<Piece>();
            board[row + (player ? 1 : -1)][i].white = true;
        }
    }


    void Start()
    {
        board = new List<List<Piece>>();

        for(int i=0;i<8;i++)
        {
            board.Add(new List<Piece>());
            for(int j=0;j<8;j++)
            {
                board[i].Add(new Piece());
            }
        }


        if(playerWhite)
        {
            spawn_white(0 , true);
            spawn_black(7 , false);
        }
        else
        {
            spawn_white(7 , false);
            spawn_black(0 , true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Vector2 raypos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(raypos , Vector2.zero); 

            if(hit.collider != null)
            {
                highlights.ForEach(x => Destroy(x));
                highlights = new List<GameObject>();

                Piece piece = hit.collider.gameObject.GetComponent<Piece>();
                var results = !piece.locked ? piece.show_available_move(board) : new List<(int, int)>();

                foreach(var available_move in results)
                {
                    Vector2 pos = new Vector2(available_move.Item2 * offset_x + basePos.x , 
                                                    available_move.Item1 * offset_y + basePos.y);

                    var temp = GameObject.Instantiate(highlight , pos , new Quaternion());
                    temp.GetComponent<SelectTile>().piece = piece;
                    temp.GetComponent<SelectTile>().row = available_move.Item1;
                    temp.GetComponent<SelectTile>().col = available_move.Item2;

                    highlights.Add(temp);
                }
                selected = true;

            }
            else if(hit.collider == null)
            {
                selected = false;
                highlights.ForEach(x => Destroy(x));
                highlights = new List<GameObject>();
            }
        }
    }

    public (Piece,int) GetPiece(int row , int col)
    {
        if(row >= 0 && row < 8 && col >= 0 && col < 8)
        {
            return (board[row][col],0);
        }

        return (null,-1);
    }
    public void UpdateBoard(Piece piece , int row , int col)
    {
        var old_index = piece.get_index(board);
        board[old_index.Item1][old_index.Item2] = new Piece();

        if(board[row][col].gamecore != null)
        {
            Destroy(board[row][col].gameObject);
        }

        board[row][col] = piece;

        selected = false;
        highlights.ForEach(x => Destroy(x));
        highlights = new List<GameObject>();
    }
}
