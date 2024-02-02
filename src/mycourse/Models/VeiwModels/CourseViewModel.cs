using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mycourse.Models.VeiwModels
{
    public class CourseViewModel
    {
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImagePath { get; set; }
    public string Author { get; set; }
    public double Rating { get; set; }
    public Money FullPrice { get; set; }
    public Money CurrentPrice { get; set; } 
    }
}