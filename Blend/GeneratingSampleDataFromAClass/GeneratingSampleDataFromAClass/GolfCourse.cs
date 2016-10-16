using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace GeneratingSampleDataFromAClass
{
   public class GolfCourse
   {
      public string Name { get; set; }
      public string Address { get; set; }
      public DateTime? LastPlayed { get; set; }
      public int Rating { get; set; }
   }
}
