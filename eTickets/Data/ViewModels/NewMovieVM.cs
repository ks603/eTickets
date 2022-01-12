using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        [Display(Description = "Movie name")]
        [Required(ErrorMessage = "Name is required")]     
        public string Name { get; set; }

        [Display(Description = "Movie descritption")]
        [Required(ErrorMessage = "description is required")]
        public string Description { get; set; }

        [Display(Description = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Description = "Movie poster URL")]
        [Required(ErrorMessage = "Movies poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Description = "Movie start Date")]
        [Required(ErrorMessage = "Start Date is required")]
        public DateTime StartDate { get; set; }

        [Display(Description = "Movie end Date")]
        [Required(ErrorMessage = "End Date is required")]
        public DateTime EndDate { get; set; }

        [Display(Description = "Select a category")]
        [Required(ErrorMessage = "Movie category is required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Description = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required")]
        public List<int> ActorsIds { get; set; }

        [Display(Description = "select a cinema")]
        [Required(ErrorMessage = "Movie cinema is required")]

        public int CinemaId { get; set; }

        [Display(Description = "select a producer")]
        [Required(ErrorMessage = "Movie producer is required")]

        public int ProducerId { get; set; }




    }
}
