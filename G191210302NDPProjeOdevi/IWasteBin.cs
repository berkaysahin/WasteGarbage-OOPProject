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
    public interface IWasteBin : ICanBeFilled // Inherited from the ICanBeFilled interface
    {
        /// <summary>
        /// Returns how many points will be added to game points when the waste bin is emptied.
        /// </summary>
        int ScoreForEmptying { get; }
        /// <summary>
        /// If there is enough space to receive the waste sent in the waste box, it adds the waste to the box.
        /// </summary>
        /// <param name="waste">Waste to add</param>
        /// <returns>Returns whether the waste is added to the bin.</returns>
        bool Add(Waste waste);
        /// <summary>
        /// If the waste bin is over 75% full, it empties the waste box.
        /// </summary>
        /// <returns>Returns whether the waste bin has been emptied.</returns>
        bool Clear();

        void ResetVolume(); // Method to reset the full volume
    }
}
