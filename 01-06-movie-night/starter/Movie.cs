namespace movienight
{
    // MARK: Write your solution in this class
    public class Movie
    {
        public string title;
        public string rating;
        public int reviewScore;

        public Movie(string title, string rating, int score)
        {
            this.title = title;
            this.reviewScore = score;
            this.rating = rating;
        }

        public override string ToString()
        {
            /*
             * Criteria:
             * - Must contain title, rating and review score
             * - If review score > 75, description needs to contain "certified fresh"
             */
            string formattedOutput = $"{title} - Rated {rating} - {reviewScore}% on RT";

            if (reviewScore > 75)
            {
                formattedOutput += " (certified fresh)";
            }

            return formattedOutput;
        }
    }
}