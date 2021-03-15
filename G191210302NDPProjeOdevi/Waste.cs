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

using System.Drawing;

namespace G191210302NDPProjeOdevi
{
    public class Waste : IWaste // Inherited from the IWaste interface
    {
        protected int _volume;
        public int Volume // Keep the volume of the waste
        {
            get { return _volume; }
        }

        protected Image _image;
        public Image Image // Keep the image of the waste
        {
            get { return _image; }
        }
    }
}
