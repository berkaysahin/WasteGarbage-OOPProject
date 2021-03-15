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
    class TomatoPaste : Waste // Inherited from the Waste interface
    {
        public TomatoPaste()
        {
            _volume = 550;
            _image = System.Drawing.Image.FromFile("TomatoPaste.jpg");
        }
    }
}
