namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {

        public HomeworkAssignment(int possibleMark, string submitterName)
        {
            SubmitterName = submitterName;
            PossibleMarks = possibleMark;
        }
        public int EarnedMarks { get; set; }

        public int PossibleMarks { get; }

        public string SubmitterName { get; }

        public string LetterGrade {
            get
            {
                if(((double)EarnedMarks / (double)PossibleMarks)*100 >= 90)
                {
                    return "A";
                }
                else if(((double)EarnedMarks / (double)PossibleMarks) *100 >= 80)
                {
                    return "B";
                }
                else if(((double)EarnedMarks / (double)PossibleMarks) *100 >= 70)
                {
                    return "C";
                }
                else if (((double)EarnedMarks / (double)PossibleMarks) *100 >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }


    }
}
