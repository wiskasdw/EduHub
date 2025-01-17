﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EduHub.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public DateTime UploadDate { get; set; } = DateTime.Now;

    }
}