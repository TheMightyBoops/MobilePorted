using System;

namespace MobilePorted
{
    public class Movie
    {
        private String name;
        private Rating rating;
        private Genre genre;

        public Movie(String name, Rating rating, Genre genre) {
            this.name = name;
            this.rating = rating;
            this.genre = genre;
        }

        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public Rating getRating() {
            return rating;
        }

        public void setRating(Rating rating) {
            this.rating = rating;
        }

        public Genre getGenre() {
            return genre;
        }

        public void setGenre(Genre genre) {
            this.genre = genre;
        }

        
        public override bool Equals(Object o) {
            if (this == o) return true;
            if (!(o.GetType() ==  typeof(Movie))) return false;
            Movie movie = (Movie) o;
            return Object.Equals(getName(), movie.getName()) &&
                   getRating() == movie.getRating() &&
                   getGenre() == movie.getGenre();
        }

       
        public override int GetHashCode()
        {
            return name.GetHashCode() + rating.GetHashCode() + genre.GetHashCode();
        }

        public override String ToString() {
            return "Movie{" +
                   "name='" + name + '\'' +
                   ", rating=" + rating +
                   ", genre=" + genre +
                   '}';
        }
    }
}