using System;

namespace BookTracker.Domain.Models
{
    public class Book
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Status { get; private set; } // "Reading" (Читаю), "Completed" (Прочитано)
        public int? Rating { get; private set; }

        public Book(Guid id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            Status = "Reading";
        }

        // Бизнес-логика: завершение чтения с выставлением оценки
        public void CompleteReading(int rating)
        {
            if (rating < 1 || rating > 5)
            {
                throw new ArgumentException("Рейтинг должен быть от 1 до 5 звёзд.");
            }

            this.Rating = rating;
            this.Status = "Completed";
        }
    }
}