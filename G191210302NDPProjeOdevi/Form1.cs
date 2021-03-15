/****************************************************************************
**					SAKARYA UNIVERSITY
**				FACULTY OF COMPUTER AND INFORMATION SCIENCES
**				COMPUTER ENGINEERING
**				OBJECT ORIENTED PROGRAMMING COURSE
**					2019-2020 FALL SEMESTER
**	
**				HOMEWORK NUMBER...........: 04
**				STUDENT NAME..............: BERKAY ŞAHİN
**				STUDENT NUMBER............: G191210302
**              COURSE GROUP..............: 2C Group
****************************************************************************/

using System;
using System.Windows.Forms;

namespace G191210302NDPProjeOdevi
{
    public partial class Form1 : Form
    {
        // NECESSARY OBJECTS CREATED
        Glass _glass = new Glass();
        GlassWasteBin _glassWasteBin = new GlassWasteBin();
        GlassBottle _glassBottle = new GlassBottle();
        Magazine _magazine = new Magazine();
        Tomato _tomato = new Tomato();
        Newspaper _newspaper = new Newspaper();
        PaperWasteBin _paperWasteBin = new PaperWasteBin();
        CokeCan _cokeCan = new CokeCan();
        MetalWasteBin _metalWasteBin = new MetalWasteBin();
        OrganicWasteBin _organicWasteBin = new OrganicWasteBin();
        Cucumber _cucumber = new Cucumber();
        TomatoPaste _tomatoPaste = new TomatoPaste();

        Random _rnd;

        int _timer, _score;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset(); // Reset everything first
            _rnd = new Random();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            Reset();
            timer1.Enabled = true; // Timer is starting

            // REQUIRED ELEMENTS IN THE FORM ARE ACTIVATED
            btnGlass.Enabled = true;
            btnGlassDump.Enabled = true;
            btnPaper.Enabled = true;
            btnPaperWasteDump.Enabled = true;
            btnMetal.Enabled = true;
            btnMetalDump.Enabled = true;
            btnOrganic.Enabled = true;
            btnOrganicWasteDump.Enabled = true;

            lstGlass.Enabled = true;
            lstMetal.Enabled = true;
            lstPaper.Enabled = true;
            lstOrgranic.Enabled = true;

            GetRandomWaste();

            btnNewGame.Enabled = false; // New game button is disabled
        }

        private void GetRandomWaste() // A random waste will come
        {
            int random = _rnd.Next(0, 8); // Random numbers between 0 and 8 (not including 8) will be generated

            switch (random)
            {
                case 0:
                    pictureBox1.Image = _glassBottle.Image;
                    break;
                case 1:
                    pictureBox1.Image = _glass.Image;
                    break;
                case 2:
                    pictureBox1.Image = _newspaper.Image;
                    break;
                case 3:
                    pictureBox1.Image = _magazine.Image;
                    break;
                case 4:
                    pictureBox1.Image = _tomato.Image;
                    break;
                case 5:
                    pictureBox1.Image = _cucumber.Image;
                    break;
                case 6:
                    pictureBox1.Image = _cokeCan.Image;
                    break;
                case 7:
                    pictureBox1.Image = _tomatoPaste.Image;
                    break;
            }
        }

        private void BtnPaperWaste_Click(object sender, EventArgs e)
        {
            // If the photo of the waste is equal to the photo in the picturebox in the form
            // and is added to the add function in its paper waste bin and returns true, it will enter if. 

            if (pictureBox1.Image == _newspaper.Image && _paperWasteBin.Add(_newspaper))
            {
                lstPaper.Items.Add("Newspaper " + _newspaper.Volume); // Waste added to the list in the form
                _score += _newspaper.Volume; // Volume of waste added to the score
                progPaper.Value = (int)_paperWasteBin.FillRate; // Progressbar in the form is equal to the fill rate of the waste
                lblScore.Text = _score.ToString(); // The current score is printed on the score label in the form
                GetRandomWaste();
            }
            else if (pictureBox1.Image == _magazine.Image && _paperWasteBin.Add(_magazine))
            {
                lstPaper.Items.Add("Magazine " + _magazine.Volume); // Waste added to the list in the form
                _score += _magazine.Volume; // Volume of waste added to the score
                progPaper.Value = (int)_paperWasteBin.FillRate; // Progressbar in the form is equal to the fill rate of the waste
                lblScore.Text = _score.ToString(); // The current score is printed on the score label in the form
                GetRandomWaste();
            }
        }

        private void BtnGlassWaste_Click(object sender, EventArgs e)
        {
            // If the photo of the waste is equal to the photo in the picturebox in the form
            // and is added to the add function in its paper waste bin and returns true, it will enter if. 

            if (pictureBox1.Image == _glass.Image && _glassWasteBin.Add(_glass))
            {
                lstGlass.Items.Add("Glass (" + _glass.Volume + ")"); // Waste added to the list in the form
                _score += _glass.Volume; // Volume of waste added to the score
                progGlass.Value = (int)_glassWasteBin.FillRate; // Progressbar in the form is equal to the fill rate of the waste
                lblScore.Text = _score.ToString(); // The current score is printed on the score label in the form
                GetRandomWaste();
            }
            else if (pictureBox1.Image == _glassBottle.Image && _glassWasteBin.Add(_glassBottle))
            {
                lstGlass.Items.Add("Glass Bottle (" + _glassBottle.Volume + ")"); // Waste added to the list in the form
                _score += _glassBottle.Volume; // Volume of waste added to the score
                progGlass.Value = (int)_glassWasteBin.FillRate; // Progressbar in the form is equal to the fill rate of the waste
                lblScore.Text = _score.ToString(); // The current score is printed on the score label in the form
                GetRandomWaste();
            }
        }

        private void BtnMetalWaste_Click(object sender, EventArgs e)
        {
            // If the photo of the waste is equal to the photo in the picturebox in the form
            // and is added to the add function in its paper waste bin and returns true, it will enter if. 

            if (pictureBox1.Image == _cokeCan.Image && _metalWasteBin.Add(_cokeCan))
            {
                lstMetal.Items.Add("Coke Can (" + _cokeCan.Volume + ")"); // Waste added to the list in the form
                _score += _cokeCan.Volume; // Volume of waste added to the score
                progMetal.Value = (int)_metalWasteBin.FillRate; // Progressbar in the form is equal to the fill rate of the waste
                lblScore.Text = _score.ToString(); // The current score is printed on the score label in the form
                GetRandomWaste();
            }
            else if (pictureBox1.Image == _tomatoPaste.Image && _metalWasteBin.Add(_tomatoPaste))
            {
                lstMetal.Items.Add("TomatoPaste (" + _tomatoPaste.Volume + ")"); // Waste added to the list in the form
                _score += _tomatoPaste.Volume; // Volume of waste added to the score
                progMetal.Value = (int)_metalWasteBin.FillRate; // Progressbar in the form is equal to the fill rate of the waste
                lblScore.Text = _score.ToString(); // The current score is printed on the score label in the form
                GetRandomWaste();
            }
        }

        private void BtnOrganicWaste_Click(object sender, EventArgs e)
        {
            // If the photo of the waste is equal to the photo in the picturebox in the form
            // and is added to the add function in its paper waste bin and returns true, it will enter if. 

            if (pictureBox1.Image == _cucumber.Image && _organicWasteBin.Add(_cucumber))
            {
                lstOrgranic.Items.Add("Cucumber (" + _cucumber.Volume + ")"); // Waste added to the list in the form
                _score += _cucumber.Volume; // Volume of waste added to the score
                progOrganic.Value = (int)_organicWasteBin.FillRate; // Progressbar in the form is equal to the fill rate of the waste
                lblScore.Text = _score.ToString(); // The current score is printed on the score label in the form
                GetRandomWaste();
            }
            else if (pictureBox1.Image == _tomato.Image && _organicWasteBin.Add(_tomato))
            {
                lstOrgranic.Items.Add("Tomato (" + _tomato.Volume + ")"); // Waste added to the list in the form
                _score += _tomato.Volume; // Volume of waste added to the score
                progOrganic.Value = (int)_organicWasteBin.FillRate; // Progressbar in the form is equal to the fill rate of the waste
                lblScore.Text = _score.ToString(); // The current score is printed on the score label in the form
                GetRandomWaste();
            }
        }

        private void BtnPaperWasteDump_Click(object sender, EventArgs e)
        {
            if (_paperWasteBin.Clear()) // If the waste bin is over 75%, it will be emptied and return true
            {
                lstPaper.Items.Clear(); // The list in the form will be cleared
                progPaper.Value = 0; // The progressbar of the waste bin will be reset
                _timer += 3; // 3 seconds will be added to the duration
                _score += _paperWasteBin.ScoreForEmptying; // The waste bin emptying points have been added to the score

                // Current data are printed on time and score labels
                lblTimer.Text = _timer.ToString();
                lblScore.Text = _score.ToString();
            }
        }

        private void BtnGlassWasteDump_Click(object sender, EventArgs e)
        {
            if (_glassWasteBin.Clear()) // If the waste bin is over 75%, it will be emptied and return true
            {
                lstGlass.Items.Clear(); // The list in the form will be cleared
                progGlass.Value = 0; // The progressbar of the waste bin will be reset
                _timer += 3; // 3 seconds will be added to the duration
                _score += _glassWasteBin.ScoreForEmptying; // The waste bin emptying points have been added to the score

                // Current data are printed on time and score labels
                lblTimer.Text = _timer.ToString();
                lblScore.Text = _score.ToString();
            }
        }

        private void BtnMetalWasteDump_Click(object sender, EventArgs e)
        {
            if (_metalWasteBin.Clear()) // If the waste bin is over 75%, it will be emptied and return true
            {
                lstMetal.Items.Clear(); // The list in the form will be cleared
                progMetal.Value = 0; // The progressbar of the waste bin will be reset
                _timer += 3; // 3 seconds will be added to the duration
                _score += _metalWasteBin.ScoreForEmptying; // The waste bin emptying points have been added to the score

                // Current data are printed on time and score labels
                lblTimer.Text = _timer.ToString();
                lblScore.Text = _score.ToString();
            }
        }

        private void BtnOrganicWasteDump_Click(object sender, EventArgs e)
        {
            if (_organicWasteBin.Clear()) // If the waste bin is over 75%, it will be emptied and return true
            {
                lstOrgranic.Items.Clear(); // The list in the form will be cleared
                progOrganic.Value = 0; //  The progressbar of the waste bin will be reset
                _timer += 3; // 3 seconds will be added to the duration
                lblTimer.Text = _timer.ToString(); // The waste bin emptying points have been added to the score

                // When the organic box is emptied, there will be no points additions, so the code was not written
            }
        }

        private void Timer1(object sender, EventArgs e)
        {
            if (_timer != 0) // If the timer is not 0
            {
                _timer--; // Timer will decrease by 1 second
                lblTimer.Text = _timer.ToString(); // The time will be printed on the time label on the form
            }
            else // If the timer is 0
            {
                // Timer and game buttons lists are inactive

                btnGlass.Enabled = false;
                btnGlassDump.Enabled = false;
                btnPaper.Enabled = false;
                btnPaperWasteDump.Enabled = false;
                btnMetal.Enabled = false;
                btnMetalDump.Enabled = false;
                btnOrganic.Enabled = false;
                btnOrganicWasteDump.Enabled = false;

                lstGlass.Enabled = false;
                lstMetal.Enabled = false;
                lstPaper.Enabled = false;
                lstOrgranic.Enabled = false;

                btnNewGame.Enabled = true;

                timer1.Enabled = false;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset() // Reset the game
        {
            timer1.Interval = 1000; // Timer set to 1 second
            timer1.Enabled = false; // Timer is passive

            // Starting values are printed on time and score labels
            lblTimer.Text = "60";
            lblScore.Text = "0";

            _timer = 60;
            _score = 0;

            // The lists on the form are being cleared
            lstGlass.Items.Clear();
            lstPaper.Items.Clear();
            lstMetal.Items.Clear();
            lstOrgranic.Items.Clear();

            // The progressbars in the form are getting 0
            progGlass.Value = 0;
            progPaper.Value = 0;
            progMetal.Value = 0;
            progOrganic.Value = 0;

            // Unnecessary buttons are passive
            btnGlass.Enabled = false;
            btnGlassDump.Enabled = false;
            btnPaper.Enabled = false;
            btnPaperWasteDump.Enabled = false;
            btnMetal.Enabled = false;
            btnMetalDump.Enabled = false;
            btnOrganic.Enabled = false;
            btnOrganicWasteDump.Enabled = false;

            // The filled parts of the boxes are reset
            _paperWasteBin.ResetVolume();
            _metalWasteBin.ResetVolume();
            _organicWasteBin.ResetVolume();
            _glassWasteBin.ResetVolume();
        }
    }
}