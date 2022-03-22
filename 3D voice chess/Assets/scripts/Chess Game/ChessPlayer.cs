using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ChessPlayer
{
    private TeamColor white;
    internal TeamColor team;

    public ChessPlayer(TeamColor white, Board board)
    {
        this.white = white;
    }