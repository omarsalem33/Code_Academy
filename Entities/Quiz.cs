﻿namespace CodeAcademy.Entities
{
    public abstract class Quiz
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public int CourseId { get; set; }
       
        public Course Course { get; set; }
    }
}
