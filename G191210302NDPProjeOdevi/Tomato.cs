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
    class Tomato : Waste // Inherited from the Waste interface
    {
        public Tomato()
        {
            _volume = 150;
            _image = System.Drawing.Image.FromFile("Tomato.jpg");
        }
    }
}
