using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Pieces;

namespace Chess
{
    public class Board
    {
		#region Constructor
		public Board()
		{
			Pieces = new List<Piece>();
            BoardCoordinates = new List<Coordinate>();
		}
		#endregion
		
		#region Fields
		public List<Piece> Pieces {
			get; 
			set;
		}
		
		public List<Coordinate> BoardCoordinates
		{
			get; 
			set;
		}
		#endregion
		
		#region Public Methods
		public void Initialize(){
			//Initialize all pieces

            int whiteMajorPieceRank = 1;
            int whitePawnRank = 2;
            int blackPawnRank = 7;
            int blackMajorPieceRank = 8;

            File queenRookFile = File.A;
            File queenKnightFile = File.B;
            File queenBishopFile = File.C;
            File queenFile = File.D;
            File kingFile = File.E;
            File kingBishopFile = File.F;
            File kingKnightFile = File.G;
            File kingRookFile = File.H;

            #region Pawns
            for (int i = 0; i < 16; i++)
            {
                Pawn pawn = new Pawn();
                pawn.PieceColor = i < 8 ? PieceColor.White : PieceColor.Black;
                pawn.Coordinates.Rank = i < 8 ? whitePawnRank : blackPawnRank;
                pawn.Coordinates.File = (File)(i%8);
                pawn.IsOnBoard = true;
                Pieces.Add(pawn);
            }
            #endregion

            #region Rooks
            Rook whiteKingRook = new Rook();
            whiteKingRook.Coordinates.Rank = whiteMajorPieceRank;
            whiteKingRook.Coordinates.File = kingRookFile;
            whiteKingRook.IsOnBoard = true;
            whiteKingRook.PieceColor = PieceColor.White;
            Pieces.Add(whiteKingRook);

            Rook whiteQueenRook = new Rook();
            whiteQueenRook.Coordinates.Rank = whiteMajorPieceRank;
            whiteQueenRook.Coordinates.File = queenRookFile;
            whiteQueenRook.IsOnBoard = true;
            whiteQueenRook.PieceColor = PieceColor.White;
            Pieces.Add(whiteQueenRook);

            Rook blackKingRook = new Rook();
            blackKingRook.Coordinates.Rank = blackMajorPieceRank;
            blackKingRook.Coordinates.File = kingRookFile;
            blackKingRook.IsOnBoard = true;
            blackKingRook.PieceColor = PieceColor.Black;
            Pieces.Add(blackKingRook);

            Rook blackQueenRook = new Rook();
            blackQueenRook.Coordinates.File = queenRookFile;
            blackQueenRook.Coordinates.Rank = blackMajorPieceRank;
            blackQueenRook.IsOnBoard = true;
            blackQueenRook.PieceColor = PieceColor.Black;
            Pieces.Add(blackQueenRook);

            #endregion

            #region Knights
            Knight whiteQueenKnight = new Knight();
            whiteQueenKnight.Coordinates.File = queenKnightFile;
            whiteQueenKnight.Coordinates.Rank = whiteMajorPieceRank;
            whiteQueenKnight.IsOnBoard = true;
            whiteQueenKnight.PieceColor = PieceColor.White;
            Pieces.Add(whiteQueenKnight);

            Knight whiteKingKnight = new Knight();
            whiteQueenKnight.Coordinates.File = kingKnightFile;
            whiteQueenKnight.Coordinates.Rank = whiteMajorPieceRank;
            whiteKingKnight.IsOnBoard = true;
            whiteKingKnight.PieceColor = PieceColor.White;
            Pieces.Add(whiteKingKnight);

            Knight blackQueenKnight = new Knight();
            whiteQueenKnight.Coordinates.File = queenKnightFile;
            whiteQueenKnight.Coordinates.Rank = blackMajorPieceRank;
            blackQueenKnight.IsOnBoard = true;
            blackQueenKnight.PieceColor = PieceColor.Black;
            Pieces.Add(blackQueenKnight);

            Knight blackKingKnight = new Knight();
            whiteQueenKnight.Coordinates.File = kingKnightFile;
            whiteQueenKnight.Coordinates.Rank = blackMajorPieceRank;
            blackQueenKnight.IsOnBoard = true;
            blackQueenKnight.PieceColor = PieceColor.Black;
            #endregion

            #region Bishop
            Bishop whiteKingBishop = new Bishop();
            whiteKingBishop.Coordinates.Rank = whiteMajorPieceRank;
            whiteKingBishop.Coordinates.File = kingBishopFile;
            whiteKingBishop.IsOnBoard = true;
            whiteKingBishop.PieceColor = PieceColor.White;
            Pieces.Add(whiteKingBishop);

            Bishop whiteQueenBishop = new Bishop();
            whiteQueenBishop.Coordinates.Rank = whiteMajorPieceRank;
            whiteQueenBishop.Coordinates.File = queenBishopFile;
            whiteQueenBishop.IsOnBoard = true;
            whiteQueenBishop.PieceColor = PieceColor.White;
            Pieces.Add(whiteQueenBishop);

            Bishop blackKingBishop = new Bishop();
            blackKingBishop.Coordinates.Rank = blackMajorPieceRank;
            blackKingBishop.Coordinates.File = kingBishopFile;
            blackKingBishop.IsOnBoard = true;
            blackKingBishop.PieceColor = PieceColor.Black;
            Pieces.Add(blackKingBishop);

            Bishop blackQueenBishop = new Bishop();
            blackQueenBishop.Coordinates.Rank = blackMajorPieceRank;
            blackQueenBishop.Coordinates.File = queenBishopFile;
            blackQueenBishop.IsOnBoard = true;
            blackQueenBishop.PieceColor = PieceColor.Black;
            Pieces.Add(blackQueenBishop);

            #endregion

            #region Queens
            Queen whiteQueen = new Queen();
            whiteQueen.Coordinates.Rank = whiteMajorPieceRank;
            whiteQueen.Coordinates.File = queenFile;
            whiteQueen.IsOnBoard = true;
            whiteQueen.PieceColor = PieceColor.White;
            Pieces.Add(whiteQueen);

            Queen blackQueen = new Queen();
            blackQueen.Coordinates.Rank = blackMajorPieceRank;
            blackQueen.Coordinates.File = queenFile;
            blackQueen.IsOnBoard = true;
            blackQueen.PieceColor = PieceColor.Black;
            Pieces.Add(blackQueen);

            #endregion

            #region Kings
            King whiteKing = new King();
            whiteKing.Coordinates.Rank = whiteMajorPieceRank;
            whiteKing.Coordinates.File = kingFile;
            whiteKing.IsOnBoard = true;
            whiteKing.PieceColor = PieceColor.White;
            Pieces.Add(whiteKing);

            King blackKing = new King();
            blackKing.Coordinates.File = kingFile;
            blackKing.Coordinates.Rank = blackMajorPieceRank;
            blackKing.IsOnBoard = true;
            blackKing.PieceColor = PieceColor.Black;
            Pieces.Add(blackKing);
            #endregion


        }
		#endregion
    }
}
