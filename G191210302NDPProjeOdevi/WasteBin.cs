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

using System.Collections.Generic;

namespace G191210302NDPProjeOdevi
{
    public class WasteBin : IWasteBin // Inherited from the IWasteBin interface
    {
        protected int _scoreForEmptying;
        public int ScoreForEmptying
        {
            get { return _scoreForEmptying; }
        }

        protected double _volume;
        public double Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        double _fullStatus;
        public double FullStatus
        {
            get { return _fullStatus; }
        }

        double _fillRate;
        public double FillRate
        {
            get
            {
                _fillRate = (FullStatus / _volume) * 100; // The occupancy rate is calculated
                return _fillRate;
            }
        }

        public WasteBin()
        {
            _fullStatus = 0; // Initially the full status will be 0
        }

        public List<Waste> _wastes = new List<Waste>(); // List of holdings of waste
        public bool Add(Waste waste)
        {
            if (waste.Volume <= Volume - FullStatus) // If the volume of the waste is equal to or less than the empty quantity, it will not be added
            {
                _fullStatus += waste.Volume;
                _wastes.Add(waste);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Clear() // The method to empty the contents of the waste bin
        {
            if (FillRate > 75) // If it is above 75% it will not be emptied
            {
                _fullStatus = 0;
                _wastes.Clear();

                return true;
            }
            else
            {
                return false;
            }
        }

        public void ResetVolume()
        {
            _fullStatus = 0;
        }
    }
}
