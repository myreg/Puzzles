﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PuzzleType.cs" company="">
//   Copyright (c) Miroslav Klimos, myreggg@gmail.com. 
// </copyright>
// <summary>
//   A class representing a type of puzzle (e.g. Rush Hour)
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Puzzles.API.Webrole.WebRole.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// A class representing a type of puzzle (e.g. Rush Hour)
    /// </summary>
    public class PuzzleType
    {
        [Key]
        public string Id { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Rules { get; set; }

        public int? TrainingPuzzleId { get; set; }

        public virtual Puzzle TrainingPuzzle { get; set; }
    }
}
