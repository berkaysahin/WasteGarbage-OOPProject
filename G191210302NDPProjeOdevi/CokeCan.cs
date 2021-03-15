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
    class CokeCan : Waste // Inherited from the Waste interface
    {
        public CokeCan()
        {
            _volume = 350;
            _image = System.Drawing.Image.FromFile("CokeCan.png");
        }
    }
}
