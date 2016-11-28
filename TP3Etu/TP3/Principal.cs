using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP3
{
  public partial class Principal : Form
  {
    public Principal( )
    {
      InitializeComponent( );
    }

    #region Jouer une partie
    
    // Représentation visuelles du jeu en mémoire.
    PictureBox[,] toutesImagesVisuelles = null;

    // Tableau des états qui correspond à ce qui sera associé au tableau de picturebox
    // François
    TypeBloc[,] tableauEtats = null;
    // François

    // Tableaux qui contient les positions relatives du bloc actif
    //Jade
    int[] blocActifX = null;
    int[] blocActifY = null;
    //Jade

    // Variables qui déterminent les dimensions du tableau de jeu
    //Jade
    int hauteurTabJeu = 20;
    int largeurTabJeu = 10;
    int pieceAleatoire = 1;
    //Jade
    
    /// <summary>
    /// Gestionnaire de l'événement se produisant lors du premier affichage 
    /// du formulaire principal.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void frmLoad( object sender, EventArgs e )
    {
      // Ne pas oublier de mettre en place les valeurs nécessaires à une partie.
      ExecuterTestsUnitaires();
      InitialiserSurfaceDeJeu(hauteurTabJeu,largeurTabJeu);
    }

    /// <summary>
    /// Innitialise le tableau de jeu au début d'une partie
    /// </summary>
    /// <param name="nbLignes"></param>
    /// <param name="nbCols"></param>
    private void InitialiserSurfaceDeJeu(int nbLignes, int nbCols)
    {
      // Création d'une surface de jeu x colonnes par y lignes
      toutesImagesVisuelles = new PictureBox[nbLignes, nbCols];
      //Jade
      tableauEtats = new TypeBloc[nbLignes, nbCols];
      //Jade
      tableauJeu.Controls.Clear();
      tableauJeu.ColumnCount = toutesImagesVisuelles.GetLength(1);
      tableauJeu.RowCount = toutesImagesVisuelles.GetLength(0);
      for (int i = 0; i < tableauJeu.RowCount; i++)
      {
        tableauJeu.RowStyles[i].Height = tableauJeu.Height / tableauJeu.RowCount;
        for (int j = 0; j < tableauJeu.ColumnCount; j++)
        {
          tableauJeu.ColumnStyles[j].Width = tableauJeu.Width / tableauJeu.ColumnCount;
          // Création dynamique des PictureBox qui contiendront les pièces de jeu
          PictureBox newPictureBox = new PictureBox();
          newPictureBox.Width = tableauJeu.Width / tableauJeu.ColumnCount;
          newPictureBox.Height = tableauJeu.Height / tableauJeu.RowCount;
          newPictureBox.BackColor = Color.Black;
          newPictureBox.Margin = new Padding(0, 0, 0, 0);
          newPictureBox.BorderStyle = BorderStyle.FixedSingle;
          newPictureBox.Dock = DockStyle.Fill;

          // Assignation de la représentation visuelle.
          toutesImagesVisuelles[i, j] = newPictureBox;
          // Ajout dynamique du PictureBox créé dans la grille de mise en forme.
          // A noter que l' "origine" du repère dans le tableau est en haut à gauche. // Modifier l'origine pour la génération des pièces lors de la partie?y
          tableauJeu.Controls.Add(newPictureBox, j, i);
          //Initialisation du tableau des états
          //Jade
          tableauEtats[i, j] = TypeBloc.None;
          //Jade
        }
      }
    }

    //Jade
    /// <summary>
    /// 
    /// </summary>
    void JouerPartie()
    {
      bool possibleDeJouer = true;
      bool possibleDeDaplacer = true;
      while (possibleDeJouer == true)
      {
        AllocationPieceAleatoire();
        while (possibleDeDaplacer == true)
        { 
          //joueur choisi deplacement
          //verification de possibilité de deplacement
        }
      }
    }
    //Jade

    //Jade
    /// <summary>
    /// 
    /// </summary>
    void AllocationPieceAleatoire()
    {
      //Random rnd = new Random();
      //pieceAleatoire = rnd.Next(1,8);
      blocActifX = new int[3];
      blocActifY = new int[3];
      #region Bloc carré
      if (pieceAleatoire == 1) 
      {
        blocActifX = new int[3];
        blocActifY = new int[3];

        blocActifX[0] = 0;
        blocActifX[1] = 1;
        blocActifX[2] = 0;
        blocActifX[3] = 1;

        blocActifY[0] = 0;
        blocActifY[1] = 0;
        blocActifY[2] = 1;
        blocActifY[3] = 1;
      }
      #endregion

      #region Bloc ligne
      else if (pieceAleatoire == 2) 
      {
        blocActifX = new int[4];
        blocActifY = new int[4];

        blocActifX[0] = 0;
        blocActifX[1] = 0;
        blocActifX[2] = 0;
        blocActifX[3] = 0;

        blocActifY[0] = 0;
        blocActifY[1] = 1;
        blocActifY[2] = 2;
        blocActifY[3] = 3;
      }
      #endregion

      #region Bloc L
      else if (pieceAleatoire == 3)
      {
        blocActifX = new int[3];
        blocActifY = new int[3];

        blocActifX[0] = 0;
        blocActifX[1] = 0;
        blocActifX[2] = 0;
        blocActifX[3] = 1;

        blocActifY[0] = 0;
        blocActifY[1] = 1;
        blocActifY[2] = 2;
        blocActifY[3] = 2;
      }
      #endregion

      #region Bloc J
      else if (pieceAleatoire == 4) 
      {
        blocActifX = new int[3];
        blocActifY = new int[3];

        blocActifX[0] = 1;
        blocActifX[1] = 1;
        blocActifX[2] = 0;
        blocActifX[3] = 1;

        blocActifY[0] = 0;
        blocActifY[1] = 1;
        blocActifY[2] = 2;
        blocActifY[3] = 2;
      }
      #endregion

      #region Bloc Z
      else if (pieceAleatoire == 5) 
      {
        blocActifX = new int[3];
        blocActifY = new int[3];

        blocActifX[0] = 0;
        blocActifX[1] = 1;
        blocActifX[2] = 1;
        blocActifX[3] = 2;

        blocActifY[0] = 0;
        blocActifY[1] = 0;
        blocActifY[2] = 1;
        blocActifY[3] = 1;
      }
      #endregion

      #region Bloc s
      else if (pieceAleatoire == 6)
      {
        blocActifX = new int[3];
        blocActifY = new int[3];

        blocActifX[0] = 1;
        blocActifX[1] = 2;
        blocActifX[2] = 0;
        blocActifX[3] = 1;

        blocActifY[0] = 0;
        blocActifY[1] = 0;
        blocActifY[2] = 1;
        blocActifY[3] = 1;
      }
      #endregion 

      #region Bloc T
      else 
      {
        blocActifX = new int[3];
        blocActifY = new int[3];

        blocActifX[0] = 1;
        blocActifX[1] = 0;
        blocActifX[2] = 1;
        blocActifX[3] = 2;

        blocActifY[0] = 0;
        blocActifY[1] = 1;
        blocActifY[2] = 1;
        blocActifY[3] = 1;
      }
      #endregion
    }
    //Jade
    #endregion

    #region Tests
    /// <summary>
    /// Faites ici les appels requis pour vos tests unitaires.
    /// </summary>
    void ExecuterTestsUnitaires()
    {      
      ExecuterTestABC();
      // A compléter...
    }

    // A renommer et commenter!
    void ExecuterTestABC()
    {
      // Mise en place des données du test
      
      // Exécuter de la méthode à tester
      
      // Validation des résultats
      
      // Clean-up
    }

    #endregion

  }

  enum TypeBloc { None, Gelé, Carré, Ligne, T, L, J, S, Z }

}
