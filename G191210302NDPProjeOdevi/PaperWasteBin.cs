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

namespace G191210302NDPProjeOdevi
{
    class PaperWasteBin : WasteBin // Inherited from the WasteBin interface
    {
        public PaperWasteBin()
        {
            _volume = 1200;
            _scoreForEmptying = 1000;
        }
    }
}