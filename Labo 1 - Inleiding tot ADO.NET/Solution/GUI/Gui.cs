using Globals;
using Logic;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Gui : Form
    {
        private IDataProcessing logic;

        public Gui()
        {
            // Gui setup
            InitializeComponent();
            lblLbGame.Text = "Player".PadRight(28) + "Score";
            lblLbPlayer.Text = "Game".PadRight(27) + "Score".PadRight(10) + "TopScore";

            // Logic and Data setup
            logic = new DataProcessing();

            // ComboBox setup
            CbPlayer.DataSource = logic.GetPlayerList();
            CbPlayer.DisplayMember = "NameWithAvarage";

            CbGame.DataSource = logic.GetGameList();
            CbGame.DisplayMember = "Name";
        }

        private void CbPlayer_SelectedIndexChanged(object sender, EventArgs e) => LbPlayer.DataSource = logic.GetPlayerScoreList(CbPlayer.SelectedValue as Player);

        private void CbGame_SelectedIndexChanged(object sender, EventArgs e) => lbGame.DataSource = logic.GetGameScoreList(CbGame.SelectedValue as Game);
    }
}
