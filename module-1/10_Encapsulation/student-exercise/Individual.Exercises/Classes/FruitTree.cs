namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            TypeOfFruit = typeOfFruit;
            PiecesOfFruitLeft = startingPiecesOfFruit;
        }

        public string TypeOfFruit { get; }
        public int PiecesOfFruitLeft { get; private set; }

        public bool PickFruit(int numberOfPiecesToRemove)
        {
            if(PiecesOfFruitLeft < numberOfPiecesToRemove)
            {
                return false;
            }
            else
            {
                PiecesOfFruitLeft -= numberOfPiecesToRemove;
                return true;
            }
        }
    }
}
