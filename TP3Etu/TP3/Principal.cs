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

    #region Code fourni
    
    // Représentation visuelles du jeu en mémoire.
    PictureBox[,] toutesImagesVisuelles = null;

    // Tableau des états qui correspond à ce qui sera associé au tableau de picturebox
    // François
    TypeBloc[,] tableauEtats = null;
    // François

    // Variables qui déterminent les dimensions du tableau de jeu
    //Jade
    int hauteurTabJeu = 20;
    int largeurTabJeu = 10;
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
    #endregion

    #region Code à développer
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
