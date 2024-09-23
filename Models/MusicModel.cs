using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZingM3p.Models
{
    public class MusicModel
    {
        [Key]
        public int MusicId { get; set; }

        [Required(ErrorMessage = "This fiend is required.")]
        [DisplayName("Music Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string MusicName { get; set; }

        [Required(ErrorMessage = "This fiend is required.")]
        [DisplayName("Artist Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string ArtistName { get; set; }

        [Required(ErrorMessage = "This fiend is required.")]
        [Column(TypeName = "nvarchar(100)")]
        public string Type { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "This fiend is required.")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "This fiend is required.")]
        public int Views { get; set; }
    }
}
