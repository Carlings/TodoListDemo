﻿using System.ComponentModel.DataAnnotations;

namespace TodoListDemo.Data.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsCompleted { get; set; } = default;
    }
}
