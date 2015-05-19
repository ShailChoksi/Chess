using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Chess
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
			
			Board ChessBoard = new Board();
			
			ChessBoard.Initialize();
            DisplayPieces(ChessBoard);
        }

        public void DisplayPieces(Board board)
        {
            foreach (Piece piece in board.Pieces)
            {
                string pieceType = piece.GetType().ToString();
                string imageName = pieceType + piece.PieceColor.ToString();
                string coordinates = piece.Coordinates.GetCoordinates();


            }
        }
    }
}
