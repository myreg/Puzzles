﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Puzzle.cs" company="">
//   Copyright (c) Miroslav Klimos, myreggg@gmail.com. 
// </copyright>
// <summary>
//   A class representing an instance of a puzzle.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Puzzles.API.Webrole.WebRole.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    /// <summary>
    /// A class representing an instance of a puzzle.
    /// </summary>
    public class Puzzle
    {
        [Key]
        public int Id { get; set; }

        public int? TutorId { get; set; }

        [Required]
        public string TypeId { get; set; }
        
        public virtual PuzzleType Type { get; set; }

        public bool Hidden { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }

        public DateTime Created { get; set; }

        public string Definition { get; set; }

        public string InitialState { get; set; }

        // precomputed median time
        public TimeSpan? MedianTime { get; set; }

        // precomputed mean time
        public TimeSpan? MeanTime { get; set; }

        // precomputed histogram on solving times in JSON
        public string Histogram { get; set; } 
    }
}
